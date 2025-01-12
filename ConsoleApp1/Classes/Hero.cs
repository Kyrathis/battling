using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
        
    public class Hero : Actor
    {
        private string className;
        private int lVL;


        public Hero(string Name, int HP, int STR, int DEF, int LVL, string className)
            : base(Name, HP, STR, DEF) // Call the base class constructor
        {
            this.className = className;
            this.lVL = LVL;
        }

        public string ClassName
        {
            get { return className; }
        }

        ///Checks to see if the Player is alive.
        public bool IsAlive()
        {
            bool heroIsAlive = false;

            if (this.HP > 0 )
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
                playerDamage = this.STR + rnd.Next(-3, 3);

            //4: return the damage amount.
            return playerDamage;
            
        }
    }
}
