using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjoitustyöApp
{
    class Weapon
    {
        string Type;
        int Staminacost;
        int Damage;

        private static readonly Random staticRand = new Random();
        public static int Attack()
        {
            return staticRand.Next(6)+1;
        }
    }
}
