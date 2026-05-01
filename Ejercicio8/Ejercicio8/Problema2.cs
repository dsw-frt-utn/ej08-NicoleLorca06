using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal untilPrice)
        {
            decimal TotalCalculado = quantity > 0 ? quantity * untilPrice : 0;

            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = TotalCalculado,
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
    
}
