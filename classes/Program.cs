using System;

namespace classesReview{

	class program{
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

		static void Main(string [] args){
			Pessoa pessoa1 = new Pessoa("Filipe");
			pessoa1.Idade = "29";
			pessoa1.Genero = 'M';

			pessoa1.juntarNome();
		}
	}
}