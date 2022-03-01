using System;

namespace logaritma
{

	public class Program
	{
		static int Faktorial(int angka)
		{
			if (angka == 1)
			{
				Console.WriteLine("1 =");
				return 1;
			}
			Console.Write(angka+"*");
			return angka * Faktorial(angka - 1); 
		}

		public static void Main()
		{
			Console.WriteLine(Faktorial(7));
		}
	}
}