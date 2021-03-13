using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ejercicio 2
            Nombre: Luis Perez */

            /*2.	Evalué si un número es PAR o IMPAR y muestre en consola el mensaje.*/
            int num;


            Console.Write("-Digite un numero: ");
            num = int.Parse(Console.ReadLine());

            if ((num % 2) == 0)
            {
                Console.Write("El numero introducido es un numero par");
            }
            else 
            {
                Console.Write("El numero introducido es un numero impar");
            }
            Console.ReadKey();

        }
    }
}
