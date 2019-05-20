using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class parte4
    {
        public void final(Pistola revolver, Billetera cartera, eleccion ele)
        {
            int selection = 0;
            leerArchivos read = new leerArchivos();
            Billetera backpack = new Billetera();
            read.Leer("texto13.txt");
            
            selection = ele.comparacion(revolver, cartera);
            enviarRuta ruta = new enviarRuta();
            endGame final = new endGame();
            if (selection==1)
            {
                ruta.write("1) taclear a la prostituta y caer al vacio", 1);
                read.Leer("texto14.txt");
                final.ganaste();
            }
            else
            {
                ruta.write("1)2) pelear con los guardias", 1);
                Console.WriteLine("Son mas grandes que tu, te noquean y te torturan a morir");
                final.moriste(); 
            }
        }
    }
}
