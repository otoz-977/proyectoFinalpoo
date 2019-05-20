using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoFinalPOO.Classes;

namespace proyectoFinalPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            masterControl nGame = new masterControl();
            nGame.reglas();
            Console.ReadKey();

        }
    }
}
