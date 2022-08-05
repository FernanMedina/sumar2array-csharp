using System;
/*- Crear 2 arreglos de dimensiones idénticas a su elección. Crear un 3er arreglo con la suma de 
los elementos de los 2 arreglos anteriores.
Ej:
Array A= [2,4,1,6]
Array B= [3,8,12,0]
Entonces el 3er Array debería contener las sumas de los elementos 0+0, 1+1,2+2,3+3 y el 
resultado quedaria:
Array C= [5,12,13,6]
*/
namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];

            //llenar el primer arreglo
            Console.WriteLine("Vamos a llenar el primer array");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero para la posicion: " + (x+1));
                numero = int.Parse(Console.ReadLine());
                vector1[x] = numero;
            }

            //llenar el segundo arreglo
            Console.WriteLine("Vamos a llenar el segundo array");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero para la posicion: " + (x+1));
                numero = int.Parse(Console.ReadLine());
                vector2[x] = numero;
            }

            //sumamos e imprimimos el 3er arreglo
            Console.WriteLine("sumamos e imprimimos el 3er arreglo");
            for (int x = 0; x < 5; x++)
            {
                vector3[x] = vector1[x] + vector2[x];
                Console.WriteLine("La suma en la posicion: " + (x+1) + " da de resultado: " + vector3[x]);
            }

        }
    }
}
