using System;

namespace classes
{
	class Program
	{
		static public void Main(string[]args)
		{
			Produto p1 = new Produto();
			Console.Write("Digite um nome: ");
			p1.Nome = Console.ReadLine();
			Console.WriteLine($"O nome do produto é {p1.Nome}.");
			Console.ReadKey();
		}
	}
}