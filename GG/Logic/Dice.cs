using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Logic
{
    public class Dice
    {
        public int RollD20()
        {
            return new Random().Next(1, 21);
        }

        public int Roll(int sides)
        {
            return new Random().Next(1, sides + 1);
        }

        public int Roll(int sides, int amount)
        {
            int total = 0;
            for (int i = 0; i < amount; i++)
            {
                total += Roll(sides);
            }
            return total;
        }
        public bool RollSave(int save, int modifier = 0)
        {
            return RollD20() + modifier >= save;
        }
    }
}
