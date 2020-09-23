using System;

namespace VerzioKezelesHF_BertalanGergo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kérem adjon meg tíz számot.");

			int darab = 10;
			int[] tomb = new int[darab];
			int osszeg = 0;
			for (int i = 0; i < darab; i++)
			{
				tomb[i] = int.Parse(Console.ReadLine());
				osszeg = osszeg + tomb[i];
			}
			Console.WriteLine("A tíz számnak az átlaga: {0}",osszeg/darab);
		}
	}
}
