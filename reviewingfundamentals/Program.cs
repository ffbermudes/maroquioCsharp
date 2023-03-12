namespace revisaoFundamentosMaroquio{

	class Program{

		public static void Main(string [] args){
			int n1 = 5;
			double n2 = 2.34;
			string s1 = "Filipe Freitas";
			char c1 = '@';
			Console.WriteLine($"Exibindo todas as variáveis com interpolação de strings: {n1}, {n2}, {s1}, {c1}"); //transfora o número em string para exibir no console.
			int [] array = new int [2] {2, 3}; //Criação de Array.

			MostrarDados();
			int resultadoContarLetras = contarLetras("Filipe");
			Console.WriteLine(resultadoContarLetras);

		}
		 static public void MostrarDados(){
			System.Console.WriteLine("Estes são os dados:");
			System.Console.WriteLine("Rua Estrela do Norte 19");
			System.Console.WriteLine("Cachoeiro de Itapemirim/Es");
			System.Console.WriteLine("CEP 293304-405");
		}

		static public int contarLetras(string palavra){
			return palavra.Length;
		}

	}

}