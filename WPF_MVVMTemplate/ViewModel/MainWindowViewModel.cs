using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPF_MVVMTemplate.View;

namespace WPF_MVVMTemplate.ViewModel;
public class MainWindowViewModel : ObservableObject
{
	private readonly PageService pageService;

	private Page currentPage;
	public Page CurrentPage
	{
		get { return currentPage; }
		set { currentPage = value; OnPropertyChanged(); }
	}

	public MainWindowViewModel(PageService pageService)
	{
		this.pageService = pageService;

		this.pageService.OnPageChanged += (page) => CurrentPage = page;
		this.pageService.ChangePage(new SomePage());
	}
}
