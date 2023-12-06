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

        [ObservableProperty]
        string _name = "Default";
        [ObservableProperty]
        Class playerClass;
        [ObservableProperty]
        int _str;
        [ObservableProperty]
        int _dex;
        [ObservableProperty]
        int _con;
        [ObservableProperty]
        int _int;
        [ObservableProperty]
        int _wis;
        [ObservableProperty]
        int _cha;
        [ObservableProperty]
        string[] classes = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        [ObservableProperty]
        string _className = "Barbarian";

        public string SetClassName
        {
            get => ClassName;
            set {
                SetProperty(ref _className, value);
                setStats();    
                }
        }

        [RelayCommand]
        public void setStats()
        {
            Class NewPlayerClass = new Class(ClassName);
            Str = NewPlayerClass.Str;
            Dex = NewPlayerClass.Dex;
            Con = NewPlayerClass.Con;
            Int = NewPlayerClass.Inte;
            Wis = NewPlayerClass.Wis;
            Cha = NewPlayerClass.Cha;
        }
    }
}
