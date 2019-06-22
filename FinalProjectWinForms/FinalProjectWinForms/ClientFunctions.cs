using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        /// Constructs an editing mesaage and sends it.
        /// </summary>
        private void ConstructAndSendEdit()
        {
            string messageWithoutLength = string.Format("{0},{1},{2},{3}", name, Constants.EDIT_MESSAGE, GetBeforeAndAfter(), rtb.Rtf);
            int length = messageWithoutLength.Length;
            string message = string.Format("{0},{1}", length, messageWithoutLength);
            SendMessage(message);
        }

        /// <summary>
        /// Constructs a chat mesaage and sends it.
        /// </summary>
        private void ConstructAndSendChat()
        {
            string trimmedMessage = GetTrimmedChatMessage();

            string messageWithoutLength = string.Format("{0},{1},{2}", name, Constants.CHAT_MESSAGE, trimmedMessage);
            int length = messageWithoutLength.Length;
            string message = string.Format("{0},{1}", length, messageWithoutLength);
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
                MessageBox.Show("ERROR SEND!!!");
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
            if (length == -1)
            {
                Close();
                return;
            }
            string message = ReceiveSomeCharacters(length);
            if (message == "bye")
            {
                MessageBox.Show("Host Disconnected", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            int firstComma = message.IndexOf(',');
            int secondComma = message.IndexOf(',', firstComma + 1);

            string name = message.Substring(0, firstComma);
            string messageType = message.Substring(firstComma + 1, secondComma - firstComma - 1);
            if (messageType == "edit")
            {
                int thirdComma = message.IndexOf(',', secondComma + 1);
                int fourthComma = message.IndexOf(',', thirdComma + 1);

                string beforeAsString = message.Substring(secondComma + 1, thirdComma - secondComma - 1);
                string afterAsString = message.Substring(thirdComma + 1, fourthComma - thirdComma - 1);
                string newRtf = message.Substring(fourthComma + 1);

                int otherCursorBefore = int.Parse(beforeAsString);
                int otherCursorAfter = int.Parse(afterAsString);
                int myCursorBefore = rtb.SelectionStart;

                int selectionLength = rtb.SelectionLength;

                serverChange = true;
                rtb.Rtf = newRtf;
                serverChange = false;

                if (rtb.Text.Trim() == "")
                {
                    rtb.Rtf = newRtf;
                    //MessageBox.Show("EMPTY!!!!!!");
                    //MessageBox.Show(string.Format("LEN: {0}\nrealLen: {1}\n{2}\n\n\nRTF:{3}\n\n\nreal RTF:\n{4}\n\nText: [{5}]", length, message.Length, message, newRtf, rtb.Rtf, rtb.Text));
                }

                if (otherCursorBefore < otherCursorAfter)  // Text was added
                    TextAdded(myCursorBefore, selectionLength, otherCursorBefore, otherCursorAfter);
                else if (otherCursorBefore > otherCursorAfter)  // Text was deleted
                    TextDeleted(myCursorBefore, selectionLength, otherCursorBefore, otherCursorAfter);
                else  // Text's style was changed
                    TextStyleChanged(myCursorBefore, selectionLength);

                editsLabel.Text = string.Format("      {0} edited the file in {1}", name, DateTime.Now.ToString("HH:mm:ss"));
            }
            else
            {

                string messageFromUser = message.Substring(secondComma + 1);
                AddNewMessage(name, messageFromUser);
            }
        }

        /// <summary>
        /// Receives the length of the message.
        /// </summary>
        /// <returns>The length of the message</returns>
        private long ReceiveLength()
        {
            string lengthAsString = "";
            string chunk = "";
            while (chunk != ","&&chunk!= "ERROR")
            {
                chunk = ReceiveSomeCharacters(1);
                if (chunk != ",")
                    lengthAsString += chunk;
            }
            if (chunk == "ERROR")
                return -1;
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
            try
            {
                byte[] data = new byte[amount];
                int bytes = stream.Read(data, 0, data.Length);
                string responseData = Encoding.ASCII.GetString(data, 0, bytes);
                return responseData;
            }
            catch
            {
                //MessageBox.Show(string.Format("ERROR RECEIVE!!!, {0}", stopAll));
                Close();
                return "ERROR";
            }
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
            if (connectOrHost == ConnectOrHost.Host)
            {
                SendMessage("3,bye");
                Thread.Sleep(10);
            }

            stopAll = true;

            stream.Close();
            client.Close();

            try
            {
                pythonProcess.Kill();
            }
            catch
            {

            }
        }

        #endregion close

        public static string GetLocalIPAddress()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

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
