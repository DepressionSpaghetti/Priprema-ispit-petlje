using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_pet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = ' ';
            int x, max = 0;
            Console.WriteLine("Unesite riječ:");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                x = 0;
                for (int j = 0; j < s.Length; j++)
                    if (s[i] == s[j])
                        x++;
                if (x > max)
                {
                    c = s[i];
                    max = x;
                }
            }
            Console.WriteLine("Znak {0} {1} puta", c, max);

            Console.ReadKey();
        }
    }
}
