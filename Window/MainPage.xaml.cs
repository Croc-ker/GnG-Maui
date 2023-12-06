namespace Window
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCreateCharacterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CharacterCreator());
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void OnOpenWorldClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new World());
        }
    }

}
