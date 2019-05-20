using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class eleccion: Interface2
    {
        
        public int comparacion(Pistola revolver,Billetera cartera)
        {
            int selection = 0;
            int pis = 0;
            int cart = 0;
            for(int x=0;x<1;x++)
            {
                try
                {
                    


                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("\n Dame tu eleccion");
                        selection = int.Parse((Console.ReadLine()));
                        if (selection == 1)
                        {
                            return selection;
                        }
                        else if (selection == 2)
                        {
                            return selection;
                        }
                        else if(selection==3)
                        {
                           
                            pis=revolver.balas(0);
                            Console.WriteLine("Tu numero de balas es de "+pis);
                            
                            
                            cart = cartera.Dinero(0);
                            Console.WriteLine("Tu capítal es de " + cart);
                            
                            
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("intente el numero que le pusimos");
                            i--;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("\n Ese no es un numero ");
                    x--;
                }
            }
            
            return selection;
        }
    }
}
