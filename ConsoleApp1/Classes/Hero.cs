using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
        
    public class Hero
    {
        private string name;
        private string className;
        private int hP;
        private int sTR;
        private int dEF;
        private int lVL;
        

        public Hero(string name, string className, int HP, int STR, int DEF, int LVL)
        {
            this.name = name;
            this.className = className;
            this.hP = HP;
            this.sTR = STR;
            this.dEF = DEF;
            this.lVL = LVL;
        }

        public int DEF
        {
            get { return this.dEF; }
        }

        public int HP
        {
            get { return hP; }
            set { hP = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ClassName
        {
            get { return className; }
        }

        ///Checks to see if the Player is alive.
        public bool IsAlive()
        {
            bool heroIsAlive = false;

            if (this.hP > 0 )
            {
                heroIsAlive = true;
            }

            return heroIsAlive;
        }

        //returns the amount of damage the player deals to the enemy.
        public int PlayerAttack()
        {
            int playerDamage = 0;

            Random rnd = new Random();

                //3: generate a damage amount based on STR. 
                playerDamage = this.sTR + rnd.Next(-3, 3);

            //4: return the damage amount.
            return playerDamage;
            
        }
    }
}
