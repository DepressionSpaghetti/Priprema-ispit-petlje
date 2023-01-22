using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_pet3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, max = 1;
            Console.WriteLine("Upišite prvi broj:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite drugi broj:");
            y = Convert.ToInt32(Console.ReadLine());
            z = x < y ? x : y;
            for (int i = z; i >= 1; i--)
                if (x % i == 0 && y % i == 0)
                {
                    max = i;
                    break;
                }
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
