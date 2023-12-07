using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Conversation
{
    public partial class Tree : ObservableObject
    {
        public Tree(Tree tree)
        {
            Branches = tree.Branches;
            CurrentDialogue = tree.CurrentDialogue;
            BranchOne = tree.BranchOne;
            BranchTwo = tree.BranchTwo;
        }
        public Tree()
        {
            Branches = new ObservableCollection<Branch>();
            BranchOne = new Branch("","");
            BranchOne = new Branch("","");
        }
        [ObservableProperty]
        ObservableCollection<Branch> branches;
        [ObservableProperty]
        string currentDialogue;

        [ObservableProperty]
        Branch branchOne;
        [ObservableProperty]
        Branch branchTwo;
    }
}
