using System;
using ReactiveUI;

namespace RoutingExample
{
    public class SecondViewModel : ReactiveObject, IRoutableViewModel
    {
        public IScreen HostScreen { get; }

        public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

        public SecondViewModel(IScreen screen) => HostScreen = screen;
    }
}