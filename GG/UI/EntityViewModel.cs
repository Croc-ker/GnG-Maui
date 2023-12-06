using CommunityToolkit.Mvvm.ComponentModel;

namespace GG.UI
{
    public partial class EntityViewModel : ObservableObject
    {
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
