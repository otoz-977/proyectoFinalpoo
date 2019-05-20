using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace proyectoFinalPOO.Classes
{
    class leerArchivos:Interface1
    {
        public void Leer(string i)
        {
            
            StreamReader objReader = new StreamReader(@"c: \Users\reyes\source\repos\proyectoFinalPOO\"+i);
            string sLine = "";
            ArrayList arrText = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();
            foreach (string sOutput in arrText) Console.WriteLine(sOutput);
            
            
        }


    }
}
