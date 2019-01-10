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
    public class ShellViewModel : Conductor<Screen>
    {
        public ShellViewModel()
        {
            ActivateItem(new ButtonViewModel(DialogCoordinator.Instance));
        }
    }
}
