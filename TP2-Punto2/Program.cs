using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Gonzalo Cainzo",30, 34546344,'H', 80,167);
            Persona persona2 = new Persona("Fernando", 67, 1243235, 'H', 60, 160);
            Persona persona3 = new Persona("Ian Lucas ", 5, 572323451, 'H', 20, 120);

            persona2.ToString();
            persona1.MayordeEdad();
            string probando =persona2.ToString();
            Console.WriteLine(probando);

            int pesito = persona3.IMC();

            if (pesito > 0) 
            {
                Console.WriteLine("La persona tiene sobrepeso ");
            }
            else if (pesito < 0)
            {
                Console.WriteLine("La persona tiene bajo peso ");
            }
            else 
            {
                Console.WriteLine("La persona esta en su peso ideal ");
            }




            Console.ReadKey();
            
        }
    }
}
