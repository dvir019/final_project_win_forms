using System;
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
        
        #region send

        /// <summary>
        /// Constructs the mesaage and sends it.
        /// </summary>
        private void ConstructAndSend()
        {
            string messageWithoutLength = string.Format("{0},{1},{2}", name, GetBeforeAndAfter(), rtb.Rtf);
            int length = messageWithoutLength.Length;
            string message = string.Format("{0},{1}", length, messageWithoutLength);
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
        private string ReceiveSomeCharacters(int amount)
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
        private void TextAdded(int myCursorBefore, int otherCursorBefore, int otherCursorAfter)
        {
            if (otherCursorBefore <= myCursorBefore)
                rtb.SelectionStart = myCursorBefore + (otherCursorAfter - otherCursorBefore);
        }

        /// <summary>
        /// Move the cursor backward if needed when text was deleted.
        /// </summary>
        /// <param name="myCursorBefore">My cursor before the change</param>
        /// <param name="otherCursorBefore">The other user cursor before the change</param>
        /// <param name="otherCursorAfter">The other user cursor after the change</param>
        private void TextDeleted(int myCursorBefore, int otherCursorBefore, int otherCursorAfter)
        {
            if (myCursorBefore >= otherCursorBefore)
                rtb.SelectionStart = myCursorBefore - (otherCursorBefore - otherCursorAfter);
            else if (myCursorBefore < otherCursorBefore && myCursorBefore > otherCursorAfter)
                rtb.SelectionStart = otherCursorAfter;
        }
        
        #endregion receive
    }
}
