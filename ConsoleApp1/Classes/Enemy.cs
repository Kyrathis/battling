using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Enemy : Actor
    {


        public Enemy(string Name, int HP, int STR, int DEF)
                        : base(Name, HP, STR, DEF)
        {
        }

        //Returns how much damage the enemy deals to the player.
        public int EnemyAttack()
        {
            int EnemyDamage = 0;

            Random rnd = new Random();
            EnemyDamage = this.STR + rnd.Next(-3, 3);

            return EnemyDamage;
        }
        
        //checks to see if the enemy is alive.
        public bool isAlive()
        {
            bool enemyIsAlive = false;

            if (this.HP > 0)
            {
                enemyIsAlive = true;
            }

            return enemyIsAlive;
        }
    }
}
