using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiarValor = originalValue;

            copiarValor++;


            Product copiaReferencia = product;

            copiaReferencia.SetDescripcion("Descripcion Modificada");

            return $"{originalValue}-{copiarValor}-{product.GetDescripcion()}";
        }

      
    }
}
