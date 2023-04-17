using CommunityToolkit.Mvvm.Input;
using Net8TestApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net8TestApp.ViewModels
{
    public partial class MainPageVm: BaseViewModel
    {
        [RelayCommand]
        private void KeyboardIssuePressed()
        {
            NavigationUtil.Navigate<KeyboardIssue>();
        }

    }
}
