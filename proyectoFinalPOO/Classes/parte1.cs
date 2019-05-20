using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class parte1
    {
        public void inicio(Pistola revolver,Billetera cartera, eleccion ele)
        {
            int selection = 0;
            leerArchivos read = new leerArchivos();
            read.Leer("texto1.txt");
            selection=ele.comparacion(revolver, cartera);
            enviarRuta ruta = new enviarRuta();

            if (selection == 1)
            {
                ruta.write("1) irme de la habitacion", 1);
                Console.WriteLine("\n el policia te detiene para platicarte los detalles");
            }
            else if (selection == 2)
            {
                ruta.write("2) quedarme a platicar con el don",1);
                Console.WriteLine("Platiqueme los detalles sr");
            }
            Console.WriteLine("\n");
            read.Leer("texto2.txt");
            ele.comparacion(revolver, cartera);
            if (selection == 1)
            {
                ruta.write("1) Muchos....", 1);
            }
            else if (selection == 2)
            {
                ruta.write("2) Ninguno que conozca ", 1);
            }
            read.Leer("texto3.txt");
            selection=ele.comparacion(revolver,cartera);
            if (selection == 1)
            {
                ruta.write("1) retira", 1);
                Console.WriteLine("\n -Creo que me dijire a la calle a investigar-");
            }
            else if (selection == 2)
            {
                ruta.write("2) seguir investigando", 1);
                Console.WriteLine("\n -Le dije que no puede seguir en la habitacion vayase a la calle o lo arresto-");
            }
            read.Leer("texto4.txt");
            selection=ele.comparacion(revolver, cartera);
            parte2 par2 = new parte2();
            parte5 par5 = new parte5();
            if (selection == 1)
            {
                ruta.write("1) Seguir a la mujer", 1);
                par2.seguimos(revolver, cartera, ele);
            }
            else
            {
                ruta.write("2) Ignorarla, algo de ti no te da confizansa en ella", 1);
                par5.seguimos(revolver, cartera, ele);
            }
        }
    }
}
