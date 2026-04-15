using System;

namespace _18.VectoresArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18. Escribir un algoritmo que permita llenar un vector[15] con numeros enteros y
             luego encuentre y muestre el valor maximo y minimo de los numeros ingresados

            int[] numeros = new int[15];
            int maximo = int.MinValue;
            int minimo = int.MaxValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero en la posicion {i+1}:");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
                else if(numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }

            }
            Console.WriteLine($"El numero maximo es: {maximo}");
            Console.WriteLine($"El numero minimo es: {minimo}"); */


            /*Escribir un algoritmo que permita:
                a. Crear dos vectores del mismo tamaño.
                b. Llenarlos con números.
                c. Comparar posición por posición.
                d. Indicar cuántos elementos son iguales

            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int numerosIguales = 0;

            for (int i = 0;i < vector1.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para el vector 1 en la posicion {i+1}:");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para el vector 2 en la posicion {i+1}:");
                vector2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0;i < vector1.Length; i++)
            {
                if (vector1[i] == vector2[i])
                {
                    numerosIguales++;
                }
            }
            Console.WriteLine("La cantidad de numeros iguales en la misma posicion es: " + numerosIguales);*/

            /*Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
            orden de los elementos del vector. Se deben mostrar lo dos vectores.*/

            char[] vector = new char[5];
            char[] vectorInvertido = new char[5];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posicion {i+1}:");
                vector[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vectorInvertido.Length; i++)
            {
                vectorInvertido[i] = vector[vector.Length - 1 - i];
            }

            Console.WriteLine($"Vector original: {new string(vector)}");
            Console.WriteLine($"Vector invertido: {new string(vectorInvertido)}");

        }
    }
}
