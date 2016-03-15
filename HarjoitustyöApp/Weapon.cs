using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjoitustyöApp
{
    class Weapon
    {
        private static Random staticRand = new Random();
        string Type;
        int Staminacost=staticRand.Next(20)+1;
        public static int x=staticRand.Next(2)+1;
        public static int y=staticRand.Next(12)+1;
        int Damage=x*y;
    }
}
