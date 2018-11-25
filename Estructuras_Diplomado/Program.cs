using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Diplomado
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetProblema1();
        }

        /// <summary>
        /// este metodo se encarga de mostrar numeros multiplos del 1 al 200
        /// </summary>
        private void GetProblema1()
        {
            Console.WriteLine("===> NUMEROS MULTIPLOS DE 3 DEL 1 AL 200 <===");

            int numero = 1;

            while (numero <= 200)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            Console.WriteLine("-----------------------------");
            Console.Write("Presione una tecla...");
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de 
        /// </summary>
        private void GetProblema2()
        {

        }
    }
}
