using System;

namespace VerzioKezelesHF_BertalanGergo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kérem adjon meg hogy hány számot kíván megadni.");
            int darab = int.Parse(Console.ReadLine());
			Console.WriteLine("És most adja meg a számokat:");
			int[] tomb = new int[darab];
			int osszeg = 0;
			for (int i = 0; i < darab; i++)
			{
				tomb[i] = int.Parse(Console.ReadLine());
				osszeg = osszeg + tomb[i];
			}
			Console.WriteLine("A számok átlaga: {0}",osszeg/darab);
		}
	}
}
