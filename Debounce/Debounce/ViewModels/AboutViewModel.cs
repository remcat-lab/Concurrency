using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debounce.ViewModels
{
    public partial class AboutViewModel : ObservableObject
    {
        public readonly WindowViewModel WindowViewModel;
        public readonly NavbarViewModel NavbarViewModel;

        public AboutViewModel()
        {
            WindowViewModel = App.Services!.GetRequiredService<WindowViewModel>();
            NavbarViewModel = App.Services!.GetRequiredService<NavbarViewModel>();
        }
    }
}