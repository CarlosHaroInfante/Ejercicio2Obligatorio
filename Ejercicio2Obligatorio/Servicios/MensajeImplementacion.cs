using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Obligatorio.Servicios
{
    /// <summary>
    /// Implementación donde se encuentra el método donde se preguntan los números y los bucles for.
    /// <author>CHI - 31/01/24</author>
    /// </summary>
    internal class MensajeImplementacion : MensajeInterfaz
    {
        public float resultado() {

            Console.WriteLine("Dame un número");
            float num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el número por el que se multiplicará");
            float num2 = Convert.ToInt32(Console.ReadLine());

            float sum = num1 * num2;
            Console.WriteLine(sum);

            Console.WriteLine("Dame le número por el que se dividirá");
            float num3 = Convert.ToInt32(Console.ReadLine());

            float divi = sum / num3;
            Console.WriteLine(divi);

            Console.WriteLine("-------------------------");

            for(float i = divi; i >= 1; i--)
            {
                for (float j = 1; j <= i; j++)
                {
                    Console.WriteLine("" + j);
                    
                }
                Console.WriteLine("");
                
            Console.WriteLine("------------");
            }
           

            return divi;
        }

        
    }
}
