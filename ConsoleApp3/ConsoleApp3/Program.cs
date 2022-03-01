using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuadrat
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Angka = { 1, 4, 6, 8, 13, 3 };
            duaAngka(Angka);
            Console.ReadLine();
        }

        static void duaAngka(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i + j == 4)
                        Console.WriteLine("{0} + {1}", i, j);

                }
            }
        }
    }
}