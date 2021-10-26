using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace RoutingExample
{
    public class SecondView : ReactiveUserControl<FirstViewModel>
    {
        public SecondView()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}