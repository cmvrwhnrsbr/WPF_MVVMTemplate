using Microsoft.Extensions.DependencyInjection;
using WPF_MVVMTemplate.ViewModel;

namespace WPF_MVVMTemplate;

public class ViewModelLocator
{
    private static ServiceProvider provider;

    public static void Init()
    {
        var services = new ServiceCollection();

        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<MainPageViewModel>();
        services.AddTransient<SomePageViewModel>();

        services.AddSingleton<PageService>();

        provider = services.BuildServiceProvider();

        foreach (var item in services)
        {
            provider.GetRequiredService(item.ServiceType);
        }
    }

    public MainWindowViewModel MainWindowViewModel => provider.GetRequiredService<MainWindowViewModel>();
    public MainPageViewModel MainPageViewModel => provider.GetRequiredService<MainPageViewModel>();
    public SomePageViewModel SomePageViewModel => provider.GetRequiredService<SomePageViewModel>();
}