using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1
{
	internal class Program
	{
		static List<int> basamakAyır(int a)
		{
			List<int> basamaklar = new List<int>();//48,56
			while (a > 0)//4856
			{
				int ikiliBasamak = a % 100;
				basamaklar.Add(ikiliBasamak);
				a = a / 100;

			}
			return basamaklar;
		}
		static bool BasamaklarFarklımı(List<int> b)
		{
			int değer = b.Count;
			bool bayrak = true;

			if (b[0] == b[1])
			{
				bayrak = false;
			}

			return bayrak;
		}
		static void Main(string[] args)
		{
			//bir sayının ortadan ayrılıp toplamlarının karesi o sayıya eşit kaç adet 4 basamaklı sayı vardır
			//sayı=4862 
			int adet = 0;
			int değer = 0;
			List<int> değerler = new List<int>();
			string[] sayılar=new string[100];
			for (int i = 1000; i < 9999; i++)
			{
				değerler = basamakAyır(i);

				bool sonuç = BasamaklarFarklımı(basamakAyır(i));
				if (sonuç = true)//basamaklar farklı
				{
					değer = değerler[0] + değerler[1];
					if (i == (değer*değer))
					{
						adet++;
						sayılar[adet] = Convert.ToString( değerler[1]) + Convert.ToString(değerler[0]);
					}
				}
				else
				{
					Console.WriteLine("sayılarımız eşit");
				}
				
				//int ab = i / 100;
				//int cd = i % 100;
				//if (i==((ab+cd)* (ab + cd)))
				//{
				//	adet++;
				//}
			}
			for (int i = 0; i < 25; i++)
			{
				Console.WriteLine(sayılar[i]);//9801 sayısını mod ile aldığımız için 0 sayısını silip 1 yazıyo sonucu 981 gösteriyo
			}
			Console.WriteLine("adet:{0}",adet);
			Console.ReadLine();

		}
	}
}
