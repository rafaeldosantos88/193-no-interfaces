using System;
using System.Collections.Generic;
using System.Text;

namespace Corsenointerfaces.Servicos
{
    class BrasilTaxaServico
    {
        public double Taxa(double quantia)
        {
            if (quantia <= 100.0)   //Se a quantia for menos que 100
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
