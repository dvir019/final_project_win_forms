﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectWinForms
{
    public partial class MainForm : Form
    {
        private string previousText;
        private bool serverChange;
        private bool stopAll;
        
        #region send

        /// <summary>
        /// Constructs the mesaage and sends it.
        /// </summary>
        private void ConstructAndSend()
        {
            string messageWithoutLength = string.Format("{0},{1},{2}", name, GetBeforeAndAfter(), rtb.Rtf);
            int length = messageWithoutLength.Length;
            string message = string.Format("{0},{1}", length, messageWithoutLength);
            MessageBox.Show(string.Format("length: {0}, len: {1}", length, message.Length));
            SendMessage(message);
        }

        /// <summary>
        /// Get the string represents the cursor befor and after the change.
        /// </summary>
        /// <returns>String represents the cursor befor and after the change</returns>
        private string GetBeforeAndAfter()
        {
            int changesLength = rtb.Text.Length - previousText.Length;
            int after = rtb.SelectionStart;
            int before = after - changesLength;
            return string.Format("{0},{1}", before, after);
        }

        /// <summary>
        /// Sends a fiven message
        /// </summary>
        /// <param name="message">The message to send</param>
        private void SendMessage(string message)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch
            {
                
            }
        }
        #endregion send

        #region receive

        /// <summary>
        /// Waits all the time to receive data.
        /// Once it received, it updates the textBox and the cursor.
        /// </summary>
        private void ReceiveAllTime()
        {
            while (!stopAll)
                ReciveAndUpdate();
        }

        /// <summary>
        /// Receives data and updates the textBox according to it.
        /// </summary>
        private void ReciveAndUpdate()
        {
            long length = ReceiveLength();
            string message = ReceiveSomeCharacters(length);
            int firstComma = message.IndexOf(',');
            int secondComma = message.IndexOf(',', firstComma + 1);
            int thirdComma = message.IndexOf(',', secondComma + 1);

            string name = message.Substring(0, firstComma);
            string beforeAsString = message.Substring(firstComma + 1, secondComma - firstComma - 1);
            string afterAsString = message.Substring(secondComma + 1, thirdComma - secondComma - 1);
            string newRtf = message.Substring(thirdComma + 1);

            int otherCursorBefore = int.Parse(beforeAsString);
            int otherCursorAfter = int.Parse(afterAsString);
            int myCursorBefore = rtb.SelectionStart;

            int selectionLength = rtb.SelectionLength;

            serverChange = true;
            rtb.Rtf = newRtf;
            serverChange = false;

            if (otherCursorBefore < otherCursorAfter)  // Text was added
                TextAdded(myCursorBefore, selectionLength, otherCursorBefore, otherCursorAfter);
            else if (otherCursorBefore > otherCursorAfter)  // Text was deleted
                TextDeleted(myCursorBefore, selectionLength, otherCursorBefore, otherCursorAfter);
            else  // Text's style was changed
                TextStyleChanged(myCursorBefore, selectionLength);
        }

        /// <summary>
        /// Receives the length of the message.
        /// </summary>
        /// <returns>The length of the message</returns>
        private long ReceiveLength()
        {
            string lengthAsString = "";
            string chunk = "";
            while (chunk != ",")
            {
                chunk = ReceiveSomeCharacters(1);
                if (chunk != ",")
                    lengthAsString += chunk;
            }
            long length = long.Parse(lengthAsString);
            return length;
        }

        /// <summary>
        /// Receives a given amount of characters.
        /// </summary>
        /// <param name="amount">The amout of characters to receive</param>
        /// <returns></returns>
        private string ReceiveSomeCharacters(long amount)
        {
            byte[] data = new byte[amount];
            int bytes = stream.Read(data, 0, data.Length);
            string responseData = Encoding.ASCII.GetString(data, 0, bytes);
            return responseData;
        }

        /// <summary>
        /// Move the cursor forward if needed when text was added.
        /// </summary>
        /// <param name="myCursorBefore">My cursor before the change</param>
        /// <param name="otherCursorBefore">The other user cursor before the change</param>
        /// <param name="otherCursorAfter">The other user cursor after the change</param>
        private void TextAdded(int myCursorBefore, int selectionLength, int otherCursorBefore, int otherCursorAfter)
        {
            //MessageBox.Show("Added!");
            if (otherCursorBefore < myCursorBefore)
            {
                rtb.SelectionStart = myCursorBefore + (otherCursorAfter - otherCursorBefore);
                //MessageBox.Show(string.Format("Added and moved, {0}->{1}",myCursorBefore, rtb.SelectionStart));
            }
            else
            {
                rtb.SelectionStart = myCursorBefore;
                //MessageBox.Show(string.Format("Added NOT moved, {0}->{1}", myCursorBefore, rtb.SelectionStart));
            }
            rtb.SelectionLength = selectionLength;
        }

        /// <summary>
        /// Move the cursor backward if needed when text was deleted.
        /// </summary>
        /// <param name="myCursorBefore">My cursor before the change</param>
        /// <param name="otherCursorBefore">The other user cursor before the change</param>
        /// <param name="otherCursorAfter">The other user cursor after the change</param>
        private void TextDeleted(int myCursorBefore, int selectionLength, int otherCursorBefore, int otherCursorAfter)
        {
            //MessageBox.Show("Deleted!");
            if (myCursorBefore >= otherCursorBefore)
            {
                rtb.SelectionStart = myCursorBefore - (otherCursorBefore - otherCursorAfter);
            }
            else if (myCursorBefore < otherCursorBefore && myCursorBefore > otherCursorAfter)
            {
                rtb.SelectionStart = otherCursorAfter;
                //MessageBox.Show(string.Format("Deleted and moved if [2], {0}->{1}", myCursorBefore, rtb.SelectionStart));
            }
            else
            {
                rtb.SelectionStart = myCursorBefore;
                //MessageBox.Show(string.Format("Deleted NOT moved, {0}->{1}", myCursorBefore, rtb.SelectionStart));
            }
            rtb.SelectionLength = selectionLength;
        }

        /// <summary>
        /// Move the cursor to were it was when text's style was changed.
        /// </summary>
        /// <param name="myCursorBefore"></param>
        /// <param name="selectionLength"></param>
        private void TextStyleChanged(int myCursorBefore, int selectionLength)
        {
            rtb.SelectionStart = myCursorBefore;
            rtb.SelectionLength = selectionLength;
        }

        #endregion receive

        #region close

        /// <summary>
        /// Close the sockets
        /// </summary>
        private void CloseSockets()
        {
            stream.Close();
            client.Close();
            stopAll = true;
        }

        #endregion close

        #region error

        private void Error()
        {
            string message = "Unable to connect to server\nTry to connect again?\n";
            if (connectOrHost == ConnectOrHost.Connect)
                message += "If you choose no, the program will be closed.";
            else if (connectOrHost == ConnectOrHost.Host)
                message += "If you choose no, you will be able to save the file and then the program will be closed";
            DialogResult result = MessageBox.Show("Unable to connect to server\nTry to connect again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

        }

        #endregion error
    }
}
