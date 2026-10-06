internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Arreglos");

        Mirreglo oMiArreglo = new MiArreglo(10);
        try
        {
            for (int i = 1; i < oMiArreglo.N; i++)
            {
                oMiArreglo.agregar(i * 3);
            }
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