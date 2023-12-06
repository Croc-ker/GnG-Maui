using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Conversation
{
    public partial class Branch : ObservableObject
    {
        public Branch(string greetingText)
        {
            playerText = new ObservableCollection<string>();
            npcText = new ObservableCollection<string>();
            npcText.Add(greetingText);
            currentText = greetingText;
        }
        [ObservableProperty]
        private string currentText;
        [ObservableProperty]
        private string selectedPlayerText;
        [ObservableProperty]
        ObservableCollection<string> playerText;
        [ObservableProperty]
        ObservableCollection<string> npcText;

    }
}
