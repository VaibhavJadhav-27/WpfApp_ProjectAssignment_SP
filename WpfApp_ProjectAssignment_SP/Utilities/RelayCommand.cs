using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_ProjectAssignment_SP
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public Action action { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }

        public RelayCommand(Action action)
        {
            this.action = action;
        }
    }
}
