using System;

namespace classes
{
	class Program
	{
		static public void Main(string[]args)
		{
			Produto p1 = new Produto("Bolacha Maria", 2.50f);
			// Console.WriteLine($"O nome do produto: {p1.Nome} o preço do produto R$ {p1.Preco} reais.\nNo momento esse produto está com o estoque de {p1.ViewEstoque()} produtos.\n");

			p1.Comprar(23);
			// p1.Vender(3);
			// p1.Vender(21);
			// Console.WriteLine(p1.ViewEstoque());
			// Console.ReadKey();

			Console.WriteLine(p1.Estoque);

		}
	}
}