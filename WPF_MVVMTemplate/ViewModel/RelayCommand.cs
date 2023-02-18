using System;
using System.Windows.Input;

namespace WPF_MVVMTemplate.ViewModel;
public class RelayCommand : ICommand
{
    private Action<object> execute;
    private Predicate<object> canExecute;

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        return canExecute == null ? true : canExecute.Invoke(parameter);
    }

    public void Execute(object parameter)
    {
        execute.Invoke(parameter);
    }
}
