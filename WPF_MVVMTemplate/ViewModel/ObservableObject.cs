using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_MVVMTemplate.ViewModel;
public abstract class ObservableObject : INotifyPropertyChanged, IDisposable
{
    public event PropertyChangedEventHandler PropertyChanged;

    public virtual void OnPropertyChanged([CallerMemberName] string property = "")
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null)
            handler.Invoke(this, new PropertyChangedEventArgs(property));
    }

    public void Dispose()
    {
        Dispose();
    }

    protected virtual void OnDispose()
    {
    }
}
