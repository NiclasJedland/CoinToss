using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
	class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			Console.WriteLine("This might take a while!");
			int heads = 0; // Current head count 
			int max_heads = 0; // Max head count 
			ulong count = 0;

			while(max_heads < 30)
			{
				count++;
				if(rnd.Next(0, 2) == 0)
					heads++;
				else
				{
					if(max_heads < heads)
						max_heads = heads;
					heads = 0;
				}
			}
			Console.WriteLine("Longest streak: {0}\nCount: ~{1}m : {2}k : {3}", max_heads, count/1000000, count/1000, count);
			Console.ReadLine();
		}
	}
}
