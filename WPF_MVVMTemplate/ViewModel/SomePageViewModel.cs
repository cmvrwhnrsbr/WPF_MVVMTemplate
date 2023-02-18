using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVMTemplate.View;

namespace WPF_MVVMTemplate.ViewModel;
public class SomePageViewModel : ObservableObject
{
    private readonly PageService pageService;

    public SomePageViewModel(PageService pageService)
    {
        this.pageService = pageService;
    }

    public RelayCommand ChangePage
    {
        get
        {
            return new RelayCommand((obj) =>
            {
                pageService.ChangePage(new MainPage());
            });
        }
    }
}