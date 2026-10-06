internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Arreglos");

        Mirreglo oMiArreglo = new MiArreglo(10);
        try
        {
            oMiArreglo.Agregar(10)
            oMiArreglo.Agregar(5)
            oMiArreglo.Agregar(-4)

            oMiArreglo.WriteLine(oMiArreglo);
            Console.ReadKey();

            oMiArreglo.insertar(200, 500)
        }
        catch (Exeption ex)
        {
            Console.WriteLine(ex.menssage);
        }

        Console,WriteLine(oMiArreglo);

        oMiArreglo.Llenar(5, 20);

        Console,WriteLine("/nMiArreglo desordenado");
        Console,WriteLine(oMiArreglo);


        Console.ReadKey(),}
}