using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class parte2:leerArchivos  
    {
         
        public void seguimos(Pistola revolver, Billetera cartera , eleccion ele)
        {
            int selection = 0;
            leerArchivos read = new leerArchivos();
            
            read.Leer("texto5.txt");
            selection = ele.comparacion(revolver,cartera);
            enviarRuta ruta = new enviarRuta();
            if (selection==1)
            {
                ruta.write("1) No tengo tiempo para esto", 1);
                Console.WriteLine("\n \n -Con que eres un tipo duro he... Esta bien hablare gratis solo por ti");
            }
            else
            {
                ruta.write("2) Toma.... y habla rapido",1);
                cartera.Dinero(-200);
                Console.WriteLine("\n -Estos son los detalles-");
            }
            read.Leer("texto6.txt");
            selection = ele.comparacion(revolver, cartera);
            if (selection==1)
            {
                ruta.write("1) ir a la casa del inspector", 1);
                Console.WriteLine(" el inspector vive cerca del distrito Lambeth");
            }
            else
            {
                ruta.write("2) tirar la toalla",0);
                Console.WriteLine("Esa nunca fue una opcion, ire a distrito Lambeth");
            }
            read.Leer("texto7.txt");
            selection = ele.comparacion(revolver, cartera);
            if ( selection ==1)
            {
                ruta.write("1) Disparar a lo desconocido", 1);
                Console.WriteLine("Felicidades haz roto un espejo");
                revolver.balas(-1);
            }
            else
            {
                ruta.write("2) Esperar a que se aclare un poco ya que el sonido puede alertar a los vecinos",1);
                Console.WriteLine("Al parecer solo es un espejo");
            }
            read.Leer("texto8.txt");
            selection = ele.comparacion(revolver, cartera);
            parte3 par3 = new parte3();
            parte4 par4 = new parte4();
            if (selection == 1)
            {
                ruta.write("1) Matar al policia", 1);
                read.Leer("texto9.txt");
                revolver.balas(-1);
                par3.seguimos(revolver, cartera, ele);
                 
            }
            else
            {
                ruta.write("2) Apuntale con el arma hasta saber que va hacer",1);
                read.Leer("texto10.txt");
                revolver.balas(5);
                par4.final(revolver, cartera, ele); 
            }
            

        }
    }
}
