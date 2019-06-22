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
            int selectionStart = chatBox.SelectionStart;
            int selectionLength = chatBox.SelectionLength;
            if (chatBox.Text != "")
                chatBox.AppendText("\n\n");
            chatBox.AppendText(string.Format("{0}: ", name));
            int indexBeforeName = chatBox.Text.Length - (name.Length + 2);
            chatBox.Select(indexBeforeName, name.Length + 1);
            chatBox.SelectionFont = new Font(chatBox.SelectionFont, FontStyle.Bold);
            chatBox.DeselectAll();
            chatBox.AppendText(message);
        }
    }
}
