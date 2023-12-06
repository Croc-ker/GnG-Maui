using GG.Conversation;
using GG.Logic;
using GG.UI;

namespace Window;

public partial class Dialogue : ContentPage
{
	NonPlayer npc;
	public Dialogue(NonPlayer npc)
	{
		InitializeComponent();
		this.npc = npc;
	}
}