internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Arreglos");

        Mirreglo oMiArreglo = new MiArreglo(10);

        oMiArreglo.Llenar(5, 20);

        Console,WriteLine("/nMiArreglo desordenado");
        Console,WriteLine(oMiArreglo);


        Console.ReadKey(),}
}