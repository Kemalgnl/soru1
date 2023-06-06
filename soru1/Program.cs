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
				int ikiliBasamak = a % 10;
				basamaklar.Add(ikiliBasamak);
				a = a / 10;

			}
			return basamaklar;
		}
		static bool BasamaklarFarklımı(List<int> b)
		{
			int değer = b.Count;
			bool bayrak = true;
			for (int i = 0; i < değer - 1; i++)
			{
				if (b[i] == b[i + 1] || b[0] == b[2] || b[0] == b[3] || b[1] == b[3])
				{
					bayrak = false;
				}
				
			}
			return bayrak;

		}
		static void Main(string[] args)
		{
			//bir sayının ortadan ayrılıp toplamlarının karesi o sayıya eşit kaç adet 4 basamaklı sayı vardır
			//sayı=4862 
			int adet = 0;
			int değer = 0;
			string ab, cd;
			bool bayrak=true;
			List<int> değerler = new List<int>();
			string[] sayılar = new string[100];

			for (int i = 1000; i < 9999; i++)
			{
				değerler = basamakAyır(i);
				bayrak = BasamaklarFarklımı(değerler);

				if (bayrak == true)//basamaklar farklı
				{
					ab = Convert.ToString(değerler[3]) + Convert.ToString(değerler[2]);
					cd = Convert.ToString(değerler[1]) + Convert.ToString(değerler[0]);
					if (i == (Convert.ToInt32(ab) + Convert.ToInt32(cd)) * (Convert.ToInt32(ab) + Convert.ToInt32(cd)))
					{
						adet++;
						//sayılar[adet] = ab+cd;
						Console.WriteLine(ab + cd);
					}
				}
			}
			Console.WriteLine("adet:{0}", adet);
			Console.ReadLine();

		}
	}
}
