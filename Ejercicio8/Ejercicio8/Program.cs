using System.ComponentModel.DataAnnotations;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(101, "Teclado Logitech", 45000.00m);
            string etiqueta2 = helper.ObtenerEtiquetaProducto(102, "Mouse Logitech", 15000.00m);

            Console.WriteLine(etiqueta);
            Console.WriteLine(etiqueta2);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("--------MONTO TOTAL: PTO2--------");

            Problema2 p2 = new Problema2();

            string resultado = p2.CrearResumenVenta(101, "Teclado Logitech", 2, 45000.00m);
            Console.WriteLine(resultado);
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("--------COPIAS: PTO3--------");

            var p3 = new Problema3();

            Product miProducto = new Product();
            miProducto.SetDescripcion("Original");

            Console.WriteLine(p3.CompararCopias(104, miProducto));

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("---------- PRUEBAS PROBLEMA 04 ----------");

            var p4 = new Problema4();

            int? v1 = 8, v2 = 7, v3 = 9;

            double promedioValido = p4.CalcularPromedio(v1, v2, v3);

            Console.WriteLine($"Prueba valida (8, 7, 9): {promedioValido}");

            int? n1 = 10, n2 = null, n3 = -2;

            double promedioNull = p4.CalcularPromedio(n1, n2, n3);
            Console.WriteLine($"Prueba invalida (10, null, -2): {promedioNull}");

            double promedioTodoNull = p4.CalcularPromedio(null, null, null);
            Console.WriteLine($"Prueba Todo Null: {promedioTodoNull}");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("---------- PRUEBAS PROBLEMA 05 ----------");

            var p5 = new Problema5();

            Sale Mayorista = new WholesaleSale();
            Mayorista.Importe = 20000;
            Console.WriteLine($"Total Mayorista: {p5.ObtenerImporteFinal(Mayorista)}");

            Sale Minorista = new RetailSale();
            Minorista.Importe = 10000;
            Console.WriteLine($"Total Minorista: {p5.ObtenerImporteFinal(Minorista)}");

            
        }
    }
}
