using Caliburn.Micro;
using MahApps.Metro.Controls.Dialogs;
using MahAppsDialog.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MahAppsDialog.ViewModels
{
    public class ButtonViewModel : Screen
    {
        private IDialogCoordinator dialogCoordinator;

        public ButtonViewModel(IDialogCoordinator instance)
        {
            dialogCoordinator = instance;
        }

        public ICommand ShowDialogCommand => new RelayCommand(ExecuteShowDialog);

        public async void ExecuteShowDialog(object o)
        {
            await dialogCoordinator.ShowMessageAsync(this, "HEADER", "MESSAGE");
        }
    }
}
