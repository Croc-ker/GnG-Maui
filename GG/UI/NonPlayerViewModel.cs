using CommunityToolkit.Mvvm.ComponentModel;
using GG.Conversation;
using GG.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.UI
{
    public partial class NonPlayerViewModel : ObservableObject
    {
        public NonPlayerViewModel() {
            Name = "Default";
            Dialogue = new Tree();
        }
        public NonPlayerViewModel(NonPlayer npc)
        {
            Name = npc.name;
            Dialogue = npc.dialogue;
        }
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private Tree dialogue;


    }
}
