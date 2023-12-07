using CommunityToolkit.Mvvm.Input;
using GG.Logic;
using GG.UI;

namespace Window;

public partial class Battle : ContentPage
{
	public EntityViewModel enemy;
    public PlayerViewModel player;
    Dice dice = new Dice();
    public string description;

	public Battle(Entity inputEnemy)
	{
		InitializeComponent();
		enemy = new EntityViewModel(inputEnemy);
        player = new PlayerViewModel(Globals.globalPlayer);
        description = "You have encountered a " + enemy.Name.ToString() + "!";
        BindingContext = enemy;
        pl.BindingContext = player;
        desc.Text = description;
	}
    private async void Flee(object sender, EventArgs e)
    {
        Describe("You have fled from the " + enemy.Name.ToString() + "!");
        await Task.Delay(2000);
		await Navigation.PopAsync();
    }

    private void Attack(object sender, EventArgs e)
    {
        int dmg = (enemy.Damage / (player.DexP));
        enemy.Health =  enemy.Health - player.DamageP;
        player.HealthP -= dmg;
        Describe("You have attacked the enemy for " + player.DamageP + " damage!" +
               "\nThe enemy retaliated and attacked you for " + dmg + " damage!");
        battleEnd();
    }

    private void Defend(object sender, EventArgs e)
    {
        if (dice.Roll(2) == 1)
        {
            int dmg = (int)Math.Floor(enemy.Damage / (player.DexP * 2.0));
            player.HealthP -= dmg;
            enemy.Health -= dmg/2;
            Describe("You have successfully defended yourself from the enemy's attack!\n" +
                     "You only took " + dmg + " damage!\n" +
                     "The enemy accidentally hurt itself for " + (dmg/2) + " damage!");
        }
        else
        {
            int dmg = (enemy.Damage * 2 / (player.DexP));
            player.HealthP -= dmg;
            Describe("You have failed to defend yourself from the enemy's attack!\n" +
                     "The enemy took the advantage and critically hit you for " + dmg + " damage!");
        }
        battleEnd();
    }

    private void Magic(object sender, EventArgs e)
    {
        int dmg;
        int spell = dice.Roll(5);
        switch (spell)
        {
            case 1:
                dmg = (int)Math.Floor(player.DamageP / (enemy.Dex / 2.0));
                enemy.Health -= dmg;
                Describe("You have cast a spell of fire! the enemy took " + dmg + " damage!");
                break;
            case 2:
                dmg = (int)Math.Floor(enemy.Health / 4.0);
                enemy.Health -= dmg;
                Describe("You have cast a spell of poison!");
                break;
            case 3:
                dmg = (int)Math.Floor(Globals.globalPlayer.damage / 3.0);
                enemy.Health += dmg;
                Describe("Your spell backfired and healed the enemy for " + dmg + " hitpoints!");
                break;
            case 4:
                enemy.Health = Globals.globalPlayer.health;
                Describe("You have cast a spell of equalize health!");
                break;
            case 5:
                dmg = enemy.Damage;
                enemy.Health -= dmg;
                Describe("You have cast a spell of confusion! the enemy hit themselves for " + dmg + " damage!");
                break;
            default:
                break;
        }
        player.HealthP -= (enemy.Damage / (player.DexP));
        battleEnd();
    }
    public bool playerIsAlive()
    {
        if (player.HealthP > 0)
        {
            return true;
        }
        else
        {
            Describe("You have fallen to the " + enemy.Name.ToString() + "!");
            return false;
        }
    }
    public bool enemyIsAlive()
    {
        if (enemy.Health > 0)
        {
            return true;
        }
        else
        {
            Describe("You have defeated the " + enemy.Name.ToString() + "!");
            return false;
        }
    }
    public async void battleEnd()
    {
        if (!enemyIsAlive()) {
            Describe(desc.Text + "\nThe enemy has died! You monster, they had a family I think");
            await Task.Delay(2000);
            await Navigation.PopAsync();
        }
        else if (!playerIsAlive())
        {
            Describe(desc.Text + "\nYou have died! Good riddance.");
            await Task.Delay(2000);
            await Navigation.PopAsync();
        }
    }

    public void Describe(string description)
    {
        desc.Text = description;
    }
}