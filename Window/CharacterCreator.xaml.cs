using GG.Logic;
using GG.UI;
namespace Window;
public partial class CharacterCreator : ContentPage
{
    PlayerViewModel pvm = new PlayerViewModel();
	public CharacterCreator()
	{
		InitializeComponent();
        BindingContext = pvm;
        
	}

    private void OnOpenWorldClicked(object sender, EventArgs e)
    {
        Globals.globalPlayer = new Player(pvm);
        Navigation.PushAsync(new World());
    }

    private void OnGoBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void OnClassChanged(object sender, EventArgs e)
    {

    }
}