using System;
using System.Windows.Controls;

namespace WPF_MVVMTemplate;
public class PageService
{
    public event Action<Page> OnPageChanged;
    public void ChangePage(Page page) => OnPageChanged?.Invoke(page);
}
