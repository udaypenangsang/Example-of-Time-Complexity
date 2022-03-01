using System;
using System.Threading.Tasks;
namespace konstan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Angka = { 1, 2, 3, 4, 8, 21, };
            for(int i = 0; i < Angka.Length; i++)
            {
                Console.WriteLine(Angka[i]+" ");
            }
            Console.WriteLine("");
            tambah(Angka);
            Console.ReadLine();
        }

        static int tambah(int[] arr)
        {
            int hasil = arr[0] + arr[1];
            Console.WriteLine("Hasil penjumlahan = {0}",hasil);
            return hasil;

        }
    }
}
