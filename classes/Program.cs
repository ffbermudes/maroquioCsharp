using System;

namespace classesReview{
	class Pessoa{
		public string Nome;
		public string Idade;
		public char Genero;

		public Pessoa(string firstName){
			Nome = firstName;
		}

		public void juntarNome(){
			Console.WriteLine($"{Nome} possui {Idade} anos.");
		}
	}
}