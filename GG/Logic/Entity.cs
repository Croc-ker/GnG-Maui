using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Logic
{
    public class Entity
    {
        public Entity(string inputName, int inputHealth, int inputDamage, Class? inputClassType)
        {
            name = inputName;
            health = inputHealth;
            damage = inputDamage;
            if(inputClassType != null)
            {
                classType = inputClassType;
                entStr = classType.Str;
                entDex = classType.Dex;
                entCon = classType.Con;
                entInt = classType.Inte;
                entWis = classType.Wis;
                entCha = classType.Cha;
            }
            else
            {
                classType = new Class("Being");
                randStats();
            }
        }
        public Entity(NonPlayer np)
        {
            name = np.name;
            health = np.health;
            damage = np.damage;
            classType = np.classType;
            entStr = np.entStr;
            entDex = np.entDex;
            entCon = np.entCon;
            entInt = np.entInt;
            entWis = np.entWis;
            entCha = np.entCha;
        }
        public Entity()
        {
            name = enemyNameList[new Random().Next(enemyNameList.Length)];
            randStats();
            health = (int)Math.Floor(entCon * 1.5) + 8;
            damage = (int)Math.Floor(entStr * 1.5) + 4;
        }
        private string[] enemyNameList = { "Goblin", "Orc", "Kobold", "Gnoll", "Bugbear", "Hobgoblin", "Ogre", "Troll", "Giant", "Dragon" };
        public string name = "";
        public int health = 10;
        public int damage = 5;
        public Class? classType;

        public int entStr = 10;
        public int entDex = 10;
        public int entCon = 10;
        public int entInt = 10;
        public int entWis = 10;
        public int entCha = 10;

        public void randStats()
        {
            Dice dice = new Dice();
            entStr = dice.Roll(8, 2);
            entDex = dice.Roll(8, 2);
            entCon = dice.Roll(8, 2);
            entInt = dice.Roll(8, 2);
            entWis = dice.Roll(8, 2);
            entCha = dice.Roll(8, 2);
        }
    }
}
