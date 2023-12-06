using GG.Logic;
using GG.UI;

namespace Window;

public partial class World : ContentPage
{
	public World()
	{
		InitializeComponent();
        initDialogue();
	}

    public void initDialogue()
    {
        Globals.merchant = new NonPlayer();
        Globals.merchant.Name = "Merchant";
    }
    private void OnGoBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void OpenDialogue(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dialogue(Globals.merchant));
    }
    private void talkMerchant(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dialogue(Globals.merchant));
    }
}