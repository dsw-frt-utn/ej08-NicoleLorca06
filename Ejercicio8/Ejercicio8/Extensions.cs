using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    public static class Extensions
    {
        public static string ToProductCode(this string value)
        {
            if (value == null) return "SIN-CODIGO";

            return value.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
