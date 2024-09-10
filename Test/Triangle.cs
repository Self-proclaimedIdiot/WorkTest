using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public class Triangle : IFigure
	{
		double a;
		double b;
		double c;
		public Triangle(double a, double b, double c)
		{
			if (a >= b + c || b >= a + c || c >= a + b)
			{
				Console.WriteLine("Не существует треугольника с такими параметрами!");
			}
			else if(a > 0 && b > 0 && c > 0)
			{
				this.a = a;
				this.b = b;
				this.c = c;
			}
		}
		public double Perimeter()
		{
			return a + b + c;
		}
		public void Print()
		{
			Console.WriteLine($"треугольник ({a} x {b} x {c}) - {Perimeter()}");
		}
	}
}
