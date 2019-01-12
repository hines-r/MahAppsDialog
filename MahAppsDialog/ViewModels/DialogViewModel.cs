using Caliburn.Micro;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MahAppsDialog.ViewModels
{
    public class DialogViewModel : Screen
    {
        private ButtonViewModel buttonViewModel;

        private string _input;
        private string _otherInput;

        public DialogViewModel(ButtonViewModel buttonViewModel)
        {
            this.buttonViewModel = buttonViewModel;
        }

        public string Input
        {
            get { return _input; }
            set
            {
                _input = value;
                NotifyOfPropertyChange(() => Input);
            }
        }

        public string OtherInput
        {
            get { return _otherInput; }
            set
            {
                _otherInput = value;
                NotifyOfPropertyChange(() => OtherInput);
            }
        }

        public ICommand OkCommand => new RelayCommand(ExecuteOk);

        public void ExecuteOk(object o)
        {
            Console.WriteLine("Ok button pressed from dialog view model");
            Console.WriteLine("Input: " + Input);
            Console.WriteLine("Other Input: " + OtherInput);

            CloseDialog();
        }

        public ICommand CloseCommand => new RelayCommand(ExecuteClose);

        public void ExecuteClose(object o)
        {
            Console.WriteLine("Close button pressed from dialog view model");
            Console.WriteLine("Input: " + Input);
            Console.WriteLine("Other Input: " + OtherInput);

            CloseDialog();
        }

        private async void CloseDialog()
        {
            var dc = buttonViewModel.dialogCoordinator;
            var dialog = buttonViewModel.Dialog;

            await dc.HideMetroDialogAsync(buttonViewModel, dialog);
        }
    }
}
