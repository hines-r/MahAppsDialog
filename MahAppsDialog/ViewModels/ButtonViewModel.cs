using Caliburn.Micro;
using MahApps.Metro.Controls.Dialogs;
using MahAppsDialog.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MahAppsDialog.ViewModels
{
    public class ButtonViewModel : Screen
    {
        public IDialogCoordinator dialogCoordinator;

        public DialogView Dialog { get; set; }

        public ButtonViewModel()
        {
            dialogCoordinator = DialogCoordinator.Instance;
        }

        public ICommand ShowDialogCommand => new RelayCommand(ExecuteShowDialog);

        public async void ExecuteShowDialog(object o)
        {
            // Creates new instance of a dialog with corresponding datacontext
            var dialogViewModel = new DialogViewModel(this);
            Dialog = new DialogView()
            {
                DataContext = dialogViewModel
            };

            await dialogCoordinator.ShowMetroDialogAsync(this, Dialog);          
        }
    }
}
