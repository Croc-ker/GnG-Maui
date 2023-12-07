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
        public Branch(string inputPlayerText, string inputResponse, Branch inputNextBranch)
        {
            PlayerText = inputPlayerText;
            Response = inputResponse;
            NextBranch = inputNextBranch;
        }
        public Branch(string inputPlayerText, string inputResponse)
        {
            PlayerText = inputPlayerText;
            Response = inputResponse;
        }
        [ObservableProperty]
        private string? playerText;
        [ObservableProperty]
        private string? response;
        [ObservableProperty]
        private Branch? nextBranch;

        
    }
}
