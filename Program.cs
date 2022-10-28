using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n,i;
            int[] tab = new int[] { 2, 3, 5, 6, 7};
            Console.Write("Enter un nombre : ");
            n = int.Parse(Console.ReadLine());
            for(i = 4; i > 0; i--)
            {
                if (tab[i-1] > n)
                {
                    tab[i] = tab[i - 1];
                    tab[i - 1] = n;
                }
            }
            for (i = 0; i < 5; i++)
            {
                Console.Write("\t" + tab[i]);
            }
            Console.ReadLine();
        }
    }
}
