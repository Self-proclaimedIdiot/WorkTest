using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public class Rectangle : IFigure
	{
		double  a;
		double b;
		public Rectangle(double a, double b)
		{
			if (a > 0 && b > 0)
			{
				this.a = a;
				this.b = b;
			}
		}
		public double Perimeter()
		{
			return 2 * a + 2 * b;
		}
		public void Print()
		{
			Console.WriteLine($"прямоугольник ({a} x {b}) - {Perimeter()}");
		}
	}
}
