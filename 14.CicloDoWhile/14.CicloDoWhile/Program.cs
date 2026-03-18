using System;
using System.Security.Policy;

namespace _14.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el número 100. */

            int numero = 1;
            int contador = 0;
            int cantidadNumerosPrimos = 0;
            int contadorNumeros = 0;

            do
            {
                contador = 0;
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine(numero);
                    cantidadNumerosPrimos++;
                }
                contadorNumeros++;
                numero++;
            } while (contadorNumeros < 100);
        }
    }
}
