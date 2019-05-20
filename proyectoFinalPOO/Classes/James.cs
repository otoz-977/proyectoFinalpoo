using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class James: absJames
    {

        
        Bolsas bolsa; 
       
        sombrero somb;
        public James (sombrero somb, Bolsas bolsa)
        {
            this.somb = somb;
            this.bolsa = bolsa;
        }
           
        public override string soyJames { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
