using CommunityToolkit.Mvvm.ComponentModel;
using GG.Logic;

namespace GG.UI
{
    public partial class EntityViewModel : ObservableObject
    {
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
        }

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
