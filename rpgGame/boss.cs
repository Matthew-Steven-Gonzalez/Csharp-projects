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
        public int coins = rnd.Next(5,100);
        public int health = rnd.Next(10,25);
        public int damage = rnd.Next(2,4)
        Enemy(string name)
        {
            Enemy.name = name;
        };
    }


    Random rnd = new Random();
}