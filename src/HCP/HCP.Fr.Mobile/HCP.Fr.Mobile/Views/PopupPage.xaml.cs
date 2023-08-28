using HCP.Fr.Mobile.ViewModels;

namespace HCP.Fr.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPage : ContentPage
    {
        public PopupPage()
        {
            InitializeComponent();
            BindingContext = new PopupViewModel();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            Popup.IsOpen = true;
        }
    }
}