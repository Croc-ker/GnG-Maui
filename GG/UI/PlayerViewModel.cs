using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GG.Logic;
using GG.UI;

namespace GG.UI
{
    public partial class PlayerViewModel : ObservableObject
    {

        public PlayerViewModel()
        {
            setStats();
        }

        public PlayerViewModel(Player player)
        {
            NameP = player.name;
            ClassNameP = player.Class.Name;
            StrP = player.entStr;
            DexP = player.entDex;
            ConP = player.entCon;
            IntP = player.entInt;
            WisP = player.entWis;
            ChaP = player.entCha;
            HealthP = player.health;
            DamageP = player.damage;
        }

        [ObservableProperty]
        string _nameP = "Default";
        [ObservableProperty]
        Class playerClass = new Class("Barbarian");
        [ObservableProperty]
        int _strP;
        [ObservableProperty]
        int _dexP;
        [ObservableProperty]
        int _conP;
        [ObservableProperty]
        int _intP;
        [ObservableProperty]
        int _wisP;
        [ObservableProperty]
        int _chaP;
        [ObservableProperty]
        int _healthP;
        [ObservableProperty]
        int _damageP;
        [ObservableProperty]

        string[] classes = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        [ObservableProperty]
        string _classNameP = "Barbarian";

        public string SetClassName
        {
            get => ClassNameP;
            set {
                SetProperty(ref _classNameP, value);
                setStats();    
                }
        }

        [RelayCommand]
        public void setStats()
        {
            Class NewPlayerClass = new Class(ClassNameP);
            StrP = NewPlayerClass.Str;
            DexP = NewPlayerClass.Dex;
            ConP = NewPlayerClass.Con;
            IntP = NewPlayerClass.Inte;
            WisP = NewPlayerClass.Wis;
            ChaP = NewPlayerClass.Cha;
        }
    }
}
