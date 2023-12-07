using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GG.Logic;

namespace GG.UI
{
    public partial class EntityViewModel : ObservableObject
    {
        Dice dice = new Dice();
        public EntityViewModel()
        {
            Name = "Default";
            ClassName = "Default";
            Str = 0;
            Dex = 0;
            Con = 0;
            Int = 0;
            Wis = 0;
            Cha = 0;
        }
        public EntityViewModel(Entity entity)
        {
            Name = entity.name;
            ClassName = entity.classType.Name;
            Str = entity.entStr;
            Dex = entity.entDex;
            Con = entity.entCon;
            Int = entity.entInt;
            Wis = entity.entWis;
            Cha = entity.entCha;
            Health = entity.health;
            Damage = entity.damage;
        }

        [ObservableProperty]
        private int _health;
        [ObservableProperty]
        private int _damage;
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _className;
        [ObservableProperty]
        private int _str;
        [ObservableProperty]
        private int _dex;
        [ObservableProperty]
        private int _con;
        [ObservableProperty]
        private int _int;
        [ObservableProperty]
        private int _wis;
        [ObservableProperty]
        private int _cha;

    }
}
