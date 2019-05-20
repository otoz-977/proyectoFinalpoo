using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPOO.Classes
{
    class Bolsas:absBolsa
    {

        private Pistola revolver = null;
        private Billetera cartera = null;

        
        public Bolsas()
        {
            revolver = new Pistola();
            cartera = new Billetera();
            
        }
        public override int queTengo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int cantidad(int bullets)
        {
            return revolver.balas(bullets);
        }
        public int capital(int money)
        {
            return cartera.Dinero(money);
        }
    }
}
