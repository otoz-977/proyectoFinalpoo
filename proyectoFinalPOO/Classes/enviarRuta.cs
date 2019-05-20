using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proyectoFinalPOO.Classes
{
    class enviarRuta
    {
        


        public void write<t>(t txt, int x)
        {
            StreamWriter sw = new StreamWriter(@"c: \Users\reyes\source\repos\proyectoFinalPOO\test.txt", true);
            try
            {

               
                if (x == 1)
                {
                    sw.WriteLine(txt);
                }
                else
                {
                    sw.WriteLine(txt);
                    sw.Close();
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
