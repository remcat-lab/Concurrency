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
    public partial class NavbarViewModel : ObservableObject
    {
        public readonly WindowViewModel WindowViewModel;

        [ObservableProperty]
        private bool isOpen = false;

        public NavbarViewModel()
        {
            WindowViewModel = App.Services!.GetRequiredService<WindowViewModel>();
            this.PropertyChanged += (s, e) => { if (e.PropertyName == nameof(IsOpen)){ WindowViewModel.StatusBar = @$"Pane is {IsOpen}"; }  };
        }
    }
}