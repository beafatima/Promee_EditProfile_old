namespace Promee_EditProfile
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnImage1Tapped(object sender, TappedEventArgs e)
        {

            var next = new NewPage();
            await Navigation.PushAsync(next);
        }
        private async void OnButtonClicked(object sender, EventArgs args)
        {
            var next1 = new NewPage();
            await Navigation.PushAsync(next1);
        }
    }
}