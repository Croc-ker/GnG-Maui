using GG.Conversation;
using GG.Logic;
using GG.UI;

namespace Window;

public partial class Dialogue : ContentPage
{
	private NonPlayerViewModel npc;
	private NonPlayer resetNPC;
	private int stage = 1;
	public Dialogue(NonPlayer givenNpc)
	{
		InitializeComponent();
		this.npc = new NonPlayerViewModel(givenNpc);
		this.resetNPC = givenNpc;
		BindingContext = npc;
	}
	// 0 - nice start							op1
	// 1 - mean start							op2

	// 2 - npc chooses option 1 after branch 0	op1
	// 3 - npc chooses option 2 after branch 0	op2

	// 4 - npc chooses option 1 after branch 1	op1
	// 5 - npc chooses option 2 after branch 1	op2

	//6 - end of dialogue branch

	public void Option1(object sender, EventArgs e)
	{
		npc.Dialogue.CurrentDialogue = npc.Dialogue.BranchOne.Response;
		switch (stage)
		{
			case 1:
				mood.Source = "scrimblohappy.png";
				npc.Dialogue.BranchOne = npc.Dialogue.Branches[2];
				npc.Dialogue.BranchTwo = npc.Dialogue.Branches[3];
				stage++;
				break;
			case 2:
				mood.Source = "scrimblohappy.png";
				npc.Dialogue.BranchOne = npc.Dialogue.Branches[6];
				npc.Dialogue.BranchTwo = npc.Dialogue.Branches[6];
				stage++;
				break;
			case 3:
				npc = new NonPlayerViewModel(resetNPC);
				Navigation.PopAsync();
				break;
		}
	}

    public void Option2(object sender, EventArgs e)
	{
		npc.Dialogue.CurrentDialogue = npc.Dialogue.BranchTwo.Response;
		switch (stage)
		{
            case 1:
                mood.Source = "scrimbloanger.png";
                npc.Dialogue.BranchOne = npc.Dialogue.Branches[4];
                npc.Dialogue.BranchTwo = npc.Dialogue.Branches[5];
				stage++;
                break;
            case 2:
				mood.Source = "scrimbloanger.png";
                npc.Dialogue.BranchOne = npc.Dialogue.Branches[6];
                npc.Dialogue.BranchTwo = npc.Dialogue.Branches[6];
				stage++;
                break;
            case 3:
				npc = new NonPlayerViewModel(resetNPC);
                Navigation.PopAsync();
                break;
        }
	}
}