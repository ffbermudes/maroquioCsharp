using System;
namespace classes
{
	class Produto
	{
		private string _nome; // Atributo privado.
		public string Nome // Propriedade pública.
		{
			get
			{
				return _nome;
			}
			set
			{
				if (value.Length > 1)
					_nome = value;
				else
				{
					throw new Exception("O produto precisa ter pelo menos 1 letra.");
				}
			}
		}
		public float Preco { get; set; } // Propriedade automática.
		private int _estoque; // Atributo privado.
		public int Estoque // Propriedade pública
		{
			get
			{
				return this._estoque;
			}
			set
			{
				if(value >= 0)
					this._estoque = value;
				else
					throw new Exception("Não é permitido que o estoque seja negativo.");
			}
		}
		public int ViewEstoque() => _estoque;

		public int Vender(int quantidade) => this.Estoque -= quantidade;
		public int Comprar(int quantidade) => this.Estoque += quantidade;

		public Produto() => this._estoque = 0;

		public Produto(string NomeProduto, float PrecoProduto)
		{
			this.Nome = NomeProduto;
			this.Preco = PrecoProduto;
		}
	}
}