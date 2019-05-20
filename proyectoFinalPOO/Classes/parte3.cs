using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class parte3
    {
        public void seguimos(Pistola revolver, Billetera cartera, eleccion ele)
        {
            int selection = 0;
            leerArchivos read = new leerArchivos();
            Billetera backpack = new Billetera();
            endGame final = new endGame(); 
            read.Leer("texto11.txt");
            selection=ele.comparacion(revolver, cartera);
            enviarRuta ruta = new enviarRuta(); 
            if (selection==1)
            {
                ruta.write("1) irme ",1);
                Console.WriteLine("la alcantarilla exploto");
                final.moriste();
            }
            else
            {
                ruta.write("2) enfrentar el destino como hombre", 1);
                 
            }
            read.Leer("texto12.txt");
            final.moriste(); 
        }
    }
}
