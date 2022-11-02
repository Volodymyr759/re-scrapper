using System;

namespace UI
{
    public interface IDeleteConfirmView
    {
        event EventHandler<int> DeleteConfirmViewOKEventRaised;
        void ShowDeleteConfirmMessageView(string windowTitle, string deleteConfirmMessage, int idToDelete);
    }
}