using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Logic
{
    internal class Dice
    {
        public int RollD20()
        {
            return new Random().Next(1, 21);
        }
        public bool RollSave(int save, int modifier = 0)
        {
            return RollD20() + modifier >= save;
        }
    }
}
