using System;
namespace classes
{
	class Produto{
		private string nome; //Essa é uma forma de exibir que o dado inserido seja da forma desejada. Caso contrário, irá gerar um erro.
		public string Nome
		{
			get
			{
				return nome;
			}
			set
			{
				if (value == "FILIPE")
					nome = "Digitou o nome corretamente";
				else
				{
					throw new Exception("Você tem que digitar FILIPE");
				}
			}
		}
		public float Preco { get; set; }
		public int Estoque { get; private set; }
	}
}