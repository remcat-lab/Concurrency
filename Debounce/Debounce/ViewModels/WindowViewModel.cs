using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using Debounce.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debounce.ViewModels
{
    public partial class WindowViewModel : ObservableObject
    {
        public readonly IConfiguration Configuration;

        [ObservableProperty]
        private string title = "Window";

        [ObservableProperty]
        private string titleSource = "Source";

        [ObservableProperty]
        private string statusBar = "Statusbar";

        public WindowViewModel()
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("de-DE");
            TitleSource = ResourceDesigner.Resource.CurrentUICultureSpecificString;
            Configuration = App.Services!.GetRequiredService<IConfiguration>();
            ChangeToken.OnChange(() => Configuration.GetReloadToken(), OnChange);
            OnChange();
        }

        private void OnChange()
        {
            StatusBar = Configuration.GetSection("Settings:Subkey1:Value1").Get<string>().EmptyIfNull();
        }
    }
}