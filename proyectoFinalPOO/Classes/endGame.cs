using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class endGame
    {
        public void moriste()
        {
            Console.WriteLine("HAZ MUERTO");
            Environment.Exit(0);
        }
        public void ganaste()
        {
            Console.WriteLine("FELICIDADES DETECTIVE");
            Environment.Exit(0);
        }
    }
}
