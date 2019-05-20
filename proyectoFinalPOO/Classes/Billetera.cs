using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class Billetera:absBilletera, Interface3 
    {
        int cantidad = 500;
        public int Dinero(int money)
        {
            cantidad = cantidad + money;
            return cantidad;
        }
        public override string bicheterra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
