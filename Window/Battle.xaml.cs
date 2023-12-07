using GG.Logic;
using GG.UI;

namespace Window;

public partial class Battle : ContentPage
{
	private EntityViewModel enemy;

	public Battle(Entity inputEnemy)
	{
		InitializeComponent();
		enemy = new EntityViewModel(inputEnemy);
	}
}