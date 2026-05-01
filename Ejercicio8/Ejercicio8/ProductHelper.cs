using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Ejercicio8
{
    internal partial class ProductHelper
    {
        public String ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return $"[{code}] {description} - {price:C}";
        }
    }

}
