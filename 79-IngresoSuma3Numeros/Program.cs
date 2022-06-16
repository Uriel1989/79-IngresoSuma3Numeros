using System;

/*Crear 3 variables numéricas con el valor que tu quieras
 * en otra variable numérica guardar el valor de la suma de las 3 anteriores. 
 * Mostrar por consola.
 */

namespace _79_IngresoSuma3Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 3 numeros para sumar:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = (a + b + c);

            Console.WriteLine("Resultado:" + d);
        }
    }
}
