using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class parte5
    {
        public void seguimos (Pistola revolver, Billetera cartera, eleccion ele)
        {
            int selection = 0;
            leerArchivos read = new leerArchivos();
            Billetera backpack = new Billetera();
            read.Leer("texto15.txt");
            selection = ele.comparacion(revolver, cartera);
            enviarRuta ruta = new enviarRuta();
            endGame final = new endGame(); 
            if (selection==1)
            {
                ruta.write("1)sr. Guilded", 1);
                Console.WriteLine(" te dice que es un sueño que estas drogado ");
                final.moriste(); 
            }
            else
            {
                ruta.write("2)Los unicornios", 1);
                Console.WriteLine("los unicornios te matan");
                final.moriste();
            }
        }
    }
}
