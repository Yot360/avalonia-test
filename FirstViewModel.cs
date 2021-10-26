using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;

namespace RoutingExample
{
    public class FirstViewModel : ReactiveObject, IRoutableViewModel
    {
        public IScreen HostScreen { get; }

        public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

        public FirstViewModel(IScreen screen) => HostScreen = screen;
    }
}