using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Test;

class Program {
	public static List<int> FibonacciList = new List<int>();
	//задание 4
	public static void check_password(string password)
	{
		int num_count = 0;
		bool contains_upper = false;
		bool contains_special = false;
		foreach (char c in password)
		{
			if (Char.IsDigit(c))
			{
				num_count++;
			}
			if (Char.IsUpper(c))
				contains_upper = true;
			if (c == '!' || c == '@'|| c == '#' || c == '$' || c == '%' || c == '*')
				contains_special = true;
		}
		if (num_count >= 3 && contains_special && contains_upper && password.Length > 10)
		{
			Console.WriteLine("Хорош!!!");
		}
		else Console.WriteLine("Ненадежный пароль");
	}
	public static int fibonacci(int i)
	{
		if (i >= 0)
		{
			int n = 0;
			if (i < 2)
				n = 1;
			else n = fibonacci(i - 2) + fibonacci(i - 1);
			if (!FibonacciList.Contains(n))
				FibonacciList.Add(n);
			return n;
		}
		else 
		{
			Console.WriteLine("Число не может быть отрицательным"); 
			return 0;
		}

	}
	//задание 6
	public static void table_of_squares()
	{
		Console.Write("+---+");
		for (int i = 0; i <= 9; i++)
			Console.Write("------+");
		Console.WriteLine();
		Console.Write("|   |");
		for (int i =0; i <= 9; i++)
			Console.Write($"  {i}   |");
	    Console.WriteLine();
		Console.Write("+---+");
		for (int i = 0; i <= 9; i++)
			Console.Write("------+");
		Console.WriteLine();
		for(int i = 1; i <= 9; i++)
		{
			Console.Write($"| {i} |");
			for(int j = 0;  j <= 9; j++)
			{
				double n = Math.Pow(i * 10 + j, 2);
				Console.Write($" {n}");
				if (n < 1000)
					Console.Write("  |");
				else Console.Write(" |");
			}
			Console.WriteLine();
		}
		Console.Write("+---+");
		for (int i = 0; i <= 9; i++)
			Console.Write("------+");
	}
	//задание 7
	public static void print_figures(List<IFigure> figures)
	{
		foreach(IFigure f in figures)
		{
			f.Print();
		}
	}
	public static int diagonale_count(int n)
	{
		if (n <= 2)
		{
			Console.WriteLine("Фигуры с таким количеством углов не существует!");
			return -1;
		}
		else return n * (n - 3) / 2;
	}
	public static void Main(string[] args)
	{
		//задание 1
		/*
			Console.WriteLine("Количество программистов в комнате:");
			int count = 0;
			Int32.TryParse(Console.ReadLine(), out count);
			string end = "";
			if (count % 10 >= 2 && count % 10 <= 4 && count % 100 - count % 10 != 10)
				end = "а";
			else if (count % 10 != 1 || count % 100 == 11)
				end = "ов";
			Console.WriteLine($"В комнате {count} программист{end}");
		*/
		//задание 2
		/*
		string s = Console.ReadLine();
		List<int> numbers = new List<int>();
		string elem = "";
		foreach(char c in s)
		{
			if (c == ' ')
			{
				numbers.Add(Convert.ToInt32(elem));
				elem = "";
			}
			else if(Char.IsDigit(c)) 
				elem += c;
		}
		numbers.Add(Convert.ToInt32(elem));
		if (numbers.Count == 1)
		{
			Console.WriteLine(numbers[0]);
		}
		else if (numbers.Count > 0)
		{
			int[] res = new int[numbers.Count];
			res[0] = numbers[numbers.Count - 1] + numbers[1];
			for (int i = 1; i < numbers.Count - 1; i++)
			{
				res[i] = numbers[i - 1] + numbers[i+1];
			}
			res[numbers.Count - 1] = numbers[numbers.Count - 2] + numbers[0];
			Console.WriteLine(String.Join(" ", res));
		}
	    */
		//задание 3
		/*
		int n = 0;
		Int32.TryParse(Console.ReadLine(), out n);
		int[,] numbers = new int[n, n];
		int x = 0;
		int y = 0;
		int x_step = 1;
		int y_step = 0;
		for (int i = 1; i <= n * n; i++)
		{
			numbers[x, y] = i;
			if (x + x_step >= n || y + y_step >= n || x+x_step < 0  || y + y_step < 0)
			{
				if (x_step == 0)
				{
					x_step = -y_step;
					y_step = 0;
				}
				else if (y_step == 0)
				{
					y_step = x_step;
					x_step = 0;
				}
			}
			else if (numbers[x + x_step, y + y_step] != 0)
			{
				if (x_step == 0)
				{
					x_step = -y_step;
					y_step = 0;
				}
				else if (y_step == 0)
				{
					y_step = x_step;
					x_step = 0;
				}
			}
			x = x + x_step;
			y = y + y_step;	
		}
		for(int i = 0; i < n; i++)
		{
			for(int j = 0; j < n; j++)
			{
				Console.Write(numbers[j, i] + " ");
			}
			Console.WriteLine();
		}
		*/
		//задание 4
		/*
		Console.Write("Введите пароль:");
		check_password(Console.ReadLine());
		*/
		//задание 5
		/*
		int n = 0;
		bool goback = true;
		while (goback)
		{
			Console.Write("Введите число:");
			if (!Int32.TryParse(Console.ReadLine(), out n))
				Console.WriteLine("Ошибка! Пожалуйста, введите число!");
			else goback = false;
		}
		fibonacci(n);
		for (int i = 0; i < n; i++)
			Console.WriteLine($"Fibonacci Numbers №{i + 1}: {FibonacciList[i]}");
		*/
		//задание 6
		//table_of_squares();
		//задание 8
		/*
		int n = 0;
		bool goback = true;
		int count = 0;
		while (goback)
		{
			Console.Write("Введите число:");
			if (!Int32.TryParse(Console.ReadLine(), out n))
				Console.WriteLine($"Ошибка! Пожалуйста, введите число! (не больше {Int32.MaxValue})") ;
			else if((count = diagonale_count(n)) >= 0) goback = false;
		}
		Console.WriteLine(count);
		*/
	}
}

