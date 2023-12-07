using GG.Conversation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Logic
{
    public class NonPlayer : Entity
    {
        public Tree dialogue;
        public NonPlayer()
        {
            name = NameList[new Random().Next(NameList.Length)];
            randStats();
            health = (int)Math.Floor(entCon * 1.5) + 8;
            damage = (int)Math.Floor(entStr * 1.5) + 4;
            dialogue = new Tree();
            classType = new Class("Merchant");
        }
        private string[] NameList = { "Bob", "Joe", "Steve", "Bill", "John", "Mike", "Dave", "Tom", "Tim", "Jim" };
    }
}
