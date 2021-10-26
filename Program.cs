using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Splat;

namespace RoutingExample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(
                () => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
        {
            Locator.CurrentMutable.Register(() => new FirstView(), typeof(IViewFor<FirstViewModel>));
            Locator.CurrentMutable.Register(() => new SecondView(), typeof(IViewFor<SecondViewModel>));

            return AppBuilder
                .Configure<App>()
                .UseReactiveUI()
                .UsePlatformDetect()
                .LogToDebug();
        }
    }
}
