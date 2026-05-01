using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    internal class Product
    {
        private string _descripcion;

        public void SetDescripcion(string valor)
        {
                _descripcion = valor;
        }

        public string GetDescripcion()
        {
            return _descripcion;
        }
    }
}
