using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_TODO.Shared
{
    internal class Command : ICommand
    {
        public bool CanExecute(Object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(Object parameter)
        {
            action();
        }

        private Action action;
        public Command(Action action)
        {
            this.action = action;
        }
    }
}
