using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, escribe tu nombre: ");
            string name = Convert.ToString(Console.ReadLine());
            Apellido();

            Console.WriteLine("Presiona enter para continuar...");
            Console.ReadKey();
        }


        public static void Apellido()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Ahora, escribe tu apellido: ");
                string Apellido = Convert.ToString(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("Formato de apelldo incorrecto, por favor escriba un nombre con mas de dos letras.");
                Apellido();
            }
        }
    }
}

