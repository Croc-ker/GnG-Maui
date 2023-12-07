using GG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Logic
{
    public class Player : Entity
    {
        public Class Class;
        public Player(PlayerViewModel pvm)
        {
            this.name = pvm.NameP;
            Class = new Class(pvm.ClassNameP);
            this.health = 10 + Class.Con;
            this.damage = 1 + Class.Str;
        }
    }
}
