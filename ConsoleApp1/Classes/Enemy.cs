using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Enemy
    {
        private string name;

        private int hp;

        private int str;

        private int def;

        public Enemy(string name, int hp, int str, int def)
        {
            this.name = name;
            this.hp = hp;
            this.str = str;
            this.def = def;
        }
        public string Name { get { return name; } }
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Def
        {
            get { return def; }
        }

        //Returns how much damage the enemy deals to the player.
        public int EnemyAttack()
        {
            int EnemyDamage = 0;

            Random rnd = new Random();
            EnemyDamage = this.str + rnd.Next(-3, 3);

            return EnemyDamage;
        }
        
        //checks to see if the enemy is alive.
        public bool isAlive()
        {
            bool enemyIsAlive = false;

            if (this.hp > 0)
            {
                enemyIsAlive = true;
            }

            return enemyIsAlive;
        }
    }
}
