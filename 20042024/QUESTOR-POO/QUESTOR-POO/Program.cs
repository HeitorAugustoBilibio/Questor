namespace QUESTOR_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuAno();
        }

        public void Variaveis()
        {
            var idade = 10;
            int idadeInt = 12;
            double meuDouble = 1500.00;
            float meuFloat = 1500.00f;
            decimal Decimal = 1500.00m;

            bool verdadeiroFalso = true;

            string nome = "C Sharp";
            string[] alfabeti = { "A", "B", "C", "D"};

            List<string> lista = new List<string>() { "A", "B"};
            Dictionary<int, string> chaveValor = new Dictionary<int, string>() { {1, "A"}, {2, "B"}};

            Pessoa pessoa = new Pessoa();

        }

        public class Pessoa
        {
            public string Nome { get; set;}

            public string Sobrenome { get; set;} 
        }

        public static void MeuAno()
        {
            var anos = new List<int>() { 2022, 2021, 2020, 2019, 2018,2017};

            Console.WriteLine(anos.FirstOrDefault(c => c == 2018));
        }
    }
}
