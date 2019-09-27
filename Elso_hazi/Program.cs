using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso_hazi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg 10 számot!");
            List<int> szamokLista = new List<int>();  
            for (int i = 0; i < 10; i++)
            {
                szamokLista.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int max = szamokLista.Max();
            Console.WriteLine("A legnagyobb szám: {0}", max);


            Console.ReadKey();
        }
    }
}
