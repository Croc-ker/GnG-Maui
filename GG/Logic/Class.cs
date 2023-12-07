using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Logic
{
    public partial class Class : ObservableObject
    {
        public Class(string inputName)
        {
            CreateClass(inputName);
        }

        [ObservableProperty]
        public string[] classNames = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        [ObservableProperty]
        public string? name;
        [ObservableProperty]
        public int str;
        [ObservableProperty]
        public int dex;
        [ObservableProperty]
        public int con;
        [ObservableProperty]
        public int inte;
        [ObservableProperty]
        public int wis;
        [ObservableProperty]
        public int cha;

        public void CreateClass(string inputName)
        {
            Name = inputName;
            switch (Name)
            {
                case "Barbarian":
                    str  = 15;
                    dex  = 14;
                    con  = 13;
                    inte = 12;
                    wis  = 10;
                    cha  = 8;
                    break;
                case "Bard":
                    str  = 8;
                    dex  = 14;
                    con  = 12;
                    inte = 13;
                    wis  = 10;
                    cha  = 15;
                    break;
                case "Cleric":
                    str = 12;
                    dex = 10;
                    con = 14;
                    inte = 8;
                    wis = 15;
                    cha = 13;
                    break;
                case "Druid":
                    str = 10;
                    dex = 12;
                    con = 14;
                    inte = 8;
                    wis = 15;
                    cha = 13;
                    break;
                case "Fighter":
                    str = 15;
                    dex = 14;
                    con = 13;
                    inte = 12;
                    wis = 10;
                    cha = 8;
                    break;
                case "Monk":
                    str = 8;
                    dex = 15;
                    con = 14;
                    inte = 12;
                    wis = 10;
                    cha = 13;
                    break;
                case "Paladin":
                    str = 15;
                    dex = 14;
                    con = 13;
                    inte = 12;
                    wis = 10;
                    cha = 8;
                    break;
                case "Ranger":
                    str = 12;
                    dex = 15;
                    con = 14;
                    inte = 10;
                    wis = 13;
                    cha = 8;
                    break;
                case "Rogue":
                    str = 8;
                    dex = 15;
                    con = 14;
                    inte = 12;
                    wis = 10;
                    cha = 13;
                    break;
                case "Sorcerer":
                    str = 8;
                    dex = 14;
                    con = 13;
                    inte = 12;
                    wis = 10;
                    cha = 15;
                    break;
                case "Warlock":
                    str = 8;
                    dex = 14;
                    con = 13;
                    inte = 12;
                    wis = 10;
                    cha = 15;
                    break;
                case "Wizard":
                    str = 8;
                    dex = 14;
                    con = 10;
                    inte = 15;
                    wis = 13;
                    cha = 12;
                    break;
                default:
                    str = 10;
                    dex = 10;
                    con = 10;
                    inte = 10;
                    wis = 10;
                    cha = 10;
                    break;
            }
        }
    }
}
