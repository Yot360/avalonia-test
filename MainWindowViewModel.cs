using System.Reactive;
using ReactiveUI;

namespace RoutingExample
{
    public class MainWindowViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; } = new RoutingState();
        
        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }

        public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

        public MainWindowViewModel()
        {
            GoNext = ReactiveCommand.CreateFromObservable(
                () => Router.Navigate.Execute(new SecondViewModel(this))
                );
        }
    }
}