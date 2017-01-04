using Xamarin.Forms;
using Xamarin.Forms.Platform;

namespace TOD2017MobileApp.Views
{
    public partial class ECGsDemoPage : ContentPage
    {
        public ECGsDemoPage()
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
