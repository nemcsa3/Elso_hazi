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
            Console.WriteLine("Adja meg, hány számot szeretne beírni!");
            int db = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Adja meg a számokat!");
            List<int> szamokLista = new List<int>();  
            for (int i = 0; i < db; i++)
            {
                szamokLista.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int max = szamokLista.Max();
            Console.WriteLine("A legnagyobb szám: {0}", max);


            Console.ReadKey();
        }
    }
}
