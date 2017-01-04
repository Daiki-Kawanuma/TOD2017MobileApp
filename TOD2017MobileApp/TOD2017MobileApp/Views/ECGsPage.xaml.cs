using Xamarin.Forms;

namespace TOD2017MobileApp.Views
{
    public partial class ECGsPage : ContentPage
    {
        public ECGsPage()
        {
            InitializeComponent();
            FadeToTransparent();
        }

        private void FadeToRed()
        {
            AtentionTextLabel.FadeTo(1.0, 1000).ContinueWith((s) => FadeToTransparent());
        }

        private void FadeToTransparent()
        {
            AtentionTextLabel.FadeTo(0.0, 1000).ContinueWith((s) => FadeToRed());
        }
    }
}
