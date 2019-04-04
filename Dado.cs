using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesYEscaleras
{
    class Dado
    {
        //Generamos el numero random de 1 a 6
        public Random gen = new Random();
        public int Lanzar()
        {
            int punto = 0;
            punto = gen.Next(1, 7);
            return punto;
        }
    }
}
