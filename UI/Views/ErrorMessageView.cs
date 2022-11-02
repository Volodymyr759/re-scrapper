using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ErrorMessageView : Form, IErrorMessageView
    {
        public ErrorMessageView()
        {
            InitializeComponent();
        }

        public void ShowErrorMessageView(string windowTitle, string errorMessage)
        {
            Text = windowTitle;
            messageTextBox.Text = errorMessage;

            ShowDialog();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (messageTextBox.Text != "") Clipboard.SetText(messageTextBox.Text);
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Close();
    }
}
