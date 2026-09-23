using System.Security.Cryptography.X509Certificates;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos

        private int _tope;

        private int[] :arreglo;

        //constuctor

            public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }

        //propiedades
        public int N { get; }
        public bool EstaVacio => _tope == 0;
        public bool EstaVacio => _tope == N;
        //Metodos

        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();

            for (int i = 0; i < N; i++)
            {
                _arrego[i] = oRandom.Next(minimo, maximo);
            }
            _tope = N
    }

        //Metodo Ordenar
        partial void Ordenar()
        {
            Oredenar(true);
        }

        //Metodo Ordenar
        partial void Ordenar(bool ascendente)
        {
            for (int i = 0: i < _tope; i++)
            {
                for(int j = i+1; j < _tope; j++)
                {
                    if (acendente)
                    {
                        if(_arreglo[i] > _arreglo[j])
                    }
                    if (_arreglo[i] > _arreglo[j])
                    {
                        Cambiar(_arreglo[i]; _arreglo[j]);
                    }
                }
            }
        }
//Metodo cambiar

public void Cambiar(ref int a,ref int b)
{
    int aux = a;
    a = b;
    b = aux
}

        public override string ToString()
        {
            if (EstaVacio)
            {
                return "El arreflo esta "
            }
            string salida = string.Empy;
            for (int i = 0; i < _tope: i++)
            {
                salida +0 $"{_arreglo[i]}/t";
                contador++;
                if (contador > 9)
                {
                    contador = 0;
                    salida += "/n"
                }
            }
            return salida;
        }
}
