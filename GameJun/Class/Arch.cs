using GameJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameJun.Class
{
    class Arch : AbstractCharacter
    {
        public Arch()
        {
            Random random = new Random();
            this.health = random.Next(7, 13);
            this.defense = random.Next(-2, 50);
            this.damage = random.Next(1, 5);
        }

        public override void Attack(AbstractCharacter other)
        {
            other.Damage(damage);
        }

        public override void Damage(int amount)
        {
            if (amount >= defense)
            {
                health -= amount - defense;
            }

        }

        public override bool IsAlive()
        {
            if (health <= 0)
            {
                health = 0;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
