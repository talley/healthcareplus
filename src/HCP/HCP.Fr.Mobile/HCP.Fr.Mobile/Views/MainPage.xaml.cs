using HCP.Fr.Mobile.ViewModels;
using System.Runtime.CompilerServices;

namespace HCP.Fr.Mobile.Views
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}