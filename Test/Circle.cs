using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	public class Circle : IFigure
	{
		double r;
		public Circle(double r)
		{
			if(r > 0)
			this.r = r;
		}
		public double Perimeter()
		{
			return 2 * Math.PI * r;
		}
		public void Print()
		{
			Console.WriteLine($"круг (r = {r}) - {Perimeter()}");
		}
	}
}
