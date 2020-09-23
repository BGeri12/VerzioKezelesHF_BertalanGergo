using System;
using System.ComponentModel.DataAnnotations;

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
			Console.WriteLine();
			Console.WriteLine("A számok átlaga: {0}",osszeg/darab);

			int max = tomb[0];
			for (int i = 0; i < darab; i++)
			{
				if (max < tomb[i])
				{
					max = tomb[i];
				}
			}
			Console.WriteLine("Legnagyobb elem: {0}", max);

			int min = tomb[0];
			for (int i = 1; i < darab; i++)
			{
				if (min > tomb[i])
				{
					min = tomb[i];
				}
			}
			Console.WriteLine("Legkisebb elem: {0}", min);


			Console.ReadKey();
		}
	}
}
