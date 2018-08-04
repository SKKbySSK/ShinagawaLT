using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SharedLibrary
{
    /// <summary>
    /// ラムダ式からコマンドを生成するクラス。XamarinではCommandクラスがあります
    /// </summary>
    public class ActionCommand : ICommand
    {
        Action action;

        public ActionCommand(Action action)
        {
            this.action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action?.Invoke();
        }
    }
}
