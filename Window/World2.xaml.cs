using GG.Conversation;
using GG.Logic;
using GG.UI;

namespace Window;

public partial class World2 : ContentPage
{
	public World2()
	{
		InitializeComponent();
        initDialogue();
	}

    public void initDialogue()
    {
        Globals.merchant = new NonPlayer();
        Globals.merchant.name = "Merchant";
        Globals.merchant.dialogue = new Tree();
        // 6
        Branch dialogueEnd = new Branch("Bye.", "Bye.");
        // 5
        Branch meanContinued = new Branch("Whatever. You smell bad.", "Nuh uh!",dialogueEnd);

        // 4
        Branch apology = new Branch("Sorry.", "It's okay.", dialogueEnd);

        // 3
        Branch psych = new Branch("Psych! You're a loser.", "I have been royally disrespected", dialogueEnd);

        // 2
        Branch niceContinued = new Branch("And you aren't a bad person.","Is this an 'on god' or 'for real' type of moment?",dialogueEnd);

        // 1
        Branch mean = new Branch("What's up, loser.", "Not a loser.", meanContinued);

        // 0
        Branch nice = new Branch("You're a cool person.","Wow thanks.", niceContinued);

        Globals.merchant.dialogue.Branches.Add(mean);
        Globals.merchant.dialogue.Branches.Add(nice);
        Globals.merchant.dialogue.Branches.Add(niceContinued);
        Globals.merchant.dialogue.Branches.Add(psych);
        Globals.merchant.dialogue.Branches.Add(apology);
        Globals.merchant.dialogue.Branches.Add(meanContinued);
        Globals.merchant.dialogue.Branches.Add(dialogueEnd);
        Globals.merchant.dialogue.BranchOne = nice;
        Globals.merchant.dialogue.BranchTwo = mean;
        Globals.merchant.dialogue.CurrentDialogue = "Howdy stranger.";
    }
    private void OnGoBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void talkMerchant(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dialogue(Globals.merchant));
    }

    private void fightMerchant(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Battle(new Entity(Globals.merchant)));
    }

    private void goInside(object sender, EventArgs e)
    {
        Navigation.PushAsync(new World3());
    }
}