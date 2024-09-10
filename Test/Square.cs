using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public class Square :IFigure
	{
		double a;
		public Square(double a)
		{
			if(a >0)
			this.a = a;
		}
		public double Perimeter()
		{
			return 4 * a;
		}
		public void Print()
		{
			Console.WriteLine($"квадрат (a = {a}) - {Perimeter()}");
		}
	}
}
