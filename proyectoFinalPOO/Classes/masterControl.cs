using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proyectoFinalPOO.Classes
{
    class masterControl
    {

        public static Pistola revolver;
        public static Billetera cartera;
        public static eleccion ele;
        public static List<James> jugadores;  
        
        public masterControl ()
        {
            sombrero somb = new sombrero();
            Bolsas bolsa = new Bolsas(); 
            jugadores = new List<James>();
            jugadores.Add(new James(somb, bolsa));
            revolver = new Pistola();
            cartera = new Billetera();
            ele = new eleccion();
        }
        public void reglas()
        {
            parte1 par1 = new parte1();
            par1.inicio(revolver, cartera,ele);

        }
        
        
    }
}
