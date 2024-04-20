namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = Calculadora.soma(1, 10);
            int subtracao = Calculadora.subtrair(1, 10);
            int multiplicar = Calculadora.multiplica(1, 10);
            int dividir = Calculadora.dividir(1, 10);
            Console.WriteLine($"a soma dos numeros é {soma} e a subtração é {subtracao}, a multiplicação é {multiplicar} e a divisão é {dividir}");


        }
    }
}

