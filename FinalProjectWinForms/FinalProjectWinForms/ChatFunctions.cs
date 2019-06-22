using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectWinForms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Add new message to the chatBox.
        /// The name of the sender will be in bold.
        /// </summary>
        /// <param name="senderName">The name of the sender</param>
        /// <param name="message">The message</param>
        private void AddNewMessage(string senderName, string message)
        {
            //MessageBox.Show(string.Format("Name: {0}\nmessage: {1}\nchatBox.Text.Length: {2}", senderName, message, chatBox.Text.Length, ));
            int selectionStart = chatBox.SelectionStart;
            int selectionLength = chatBox.SelectionLength;
            if (chatBox.Text != "")
                chatBox.AppendText("\n\n");
            chatBox.AppendText(string.Format("{0}: ", senderName));
            int indexBeforeName = chatBox.Text.Length - (senderName.Length + 2);
            chatBox.Select(indexBeforeName, senderName.Length + 1);
            chatBox.SelectionFont = new Font(chatBox.SelectionFont, FontStyle.Bold);
            chatBox.DeselectAll();
            chatBox.AppendText(message);
        }

        private void sendChatButton_Click(object sender, EventArgs e)
        {
            string trimmedMessage = GetTrimmedChatMessage();
            if (trimmedMessage == "")
                return;
            AddNewMessage(name, GetTrimmedChatMessage());
            ConstructAndSendChat();
            inputChatBox.ResetText();
        }

        private string GetTrimmedChatMessage()
        {
            return inputChatBox.Text.Trim();
        }
    }
}
