using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    public class Sale
    {
        private decimal _importe;

        public decimal Importe
        {
            get { return _importe; }

            set
            {
                if (value >= 0)
                {
                    _importe = value;
                }
            }
        }

        public virtual decimal CalculateTotal()
        {
            return _importe;
        }  
    }


    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe;
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe * 0.9m;
        }
    }
}
