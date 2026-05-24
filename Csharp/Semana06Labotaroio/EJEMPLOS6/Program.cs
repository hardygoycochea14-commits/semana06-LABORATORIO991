using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO01();
            EJERCICIO02();
        }

        //Ejemplo1
        static void EJERCICIO01()
        {
            //Encontrar la suma de n números ingresados por el teclado.
            int n;
            int numero;
            int suma = 0;

            Console.Write("¿Cantidad de números que desea sumar?");
            n = int.Parse(Console.ReadLine());

            int contador = 1; //inicializar el contador del bucle

            while (contador <= n)
            {
                Console.Write($"Ingrese el número {contador} : ");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero; //suma += numero;
                contador++; //incrementar el contador

            }
            Console.WriteLine($"La suma de los {n} números es: {suma}");
   
        }
         
        //Ejemplo2
        static void EJERCICIO02()
        {
            //Encontrar la suma de n números aleatorios.
            int n, suma = 0;
            Random random = new Random();
            
            Console.Write("¿cuantos números aleatorios desea sumar: ? ");
            n= int.Parse(Console.ReadLine());

            int contador = 1;
            
            while (contador <= n)
            {
                int numero = random.Next(1, 101);
                Console.WriteLine($"Número aleatorio {contador}: {numero}");
                suma += numero; //acumular
                contador++; //avanza
               
            }
            Console.WriteLine($"La suma de los {n} números aleatorios es: {suma}");
        }
    }
}