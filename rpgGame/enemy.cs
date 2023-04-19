using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallsOfWestWood
{
    class Enemy
    {
        public string name;
        public int coins = rnd.Next(1,55);
        public int health = rnd.Next(1,6);
        public int damage = rnd.Next(1,3)
        Enemy(string name)
        {
            Enemy.name = name;
        };
    }


    Random rnd = new Random();
}