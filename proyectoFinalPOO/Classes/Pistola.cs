using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class Pistola:Interface4
    {
        int Cantidad = 3;
        public int balas(int bullets)
        {
            Cantidad = Cantidad + bullets;
            if (Cantidad <= 0)
            {
                Console.WriteLine("ya no tienes balas");
                return 0;
            }
            else
            {
                return Cantidad;
            }
        }
    }
}
