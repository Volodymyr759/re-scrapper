using System;
using System.Windows.Forms;

namespace UI
{
    public partial class DeleteConfirmView : Form, IDeleteConfirmView
    {
        public event EventHandler<int> DeleteConfirmViewOKEventRaised;
        int _idToDelete;

        public DeleteConfirmView()
        {
            InitializeComponent();
        }

        public void ShowDeleteConfirmMessageView(string windowTitle, string deleteConfirmMessage, int idToDelete)
        {
            Text = windowTitle;
            labelMessage.Text = deleteConfirmMessage;
            _idToDelete = idToDelete;
            ShowDialog();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            DeleteConfirmViewOKEventRaised(this, _idToDelete);
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
