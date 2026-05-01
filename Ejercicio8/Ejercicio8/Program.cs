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



        }
    }
}
