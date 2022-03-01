using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace linier
{
    public class Program
    {
        static void Main(string[]args)
        {
            int[] Bilangan = { 2, 2, 3, 8, 5, 13, };
            foreach (int i in Bilangan)
                Console.Write("{0} ",i);
            Console.WriteLine();
          
            for (int j = 0; j<Bilangan.Length;j++)
            {
               
                if (Bilangan[j] > Bilangan[0])
                {
                   Bilangan[0] =Bilangan[j];
                }
             
            }
            Console.WriteLine("{0}", Bilangan[0]);
        }
    }
}