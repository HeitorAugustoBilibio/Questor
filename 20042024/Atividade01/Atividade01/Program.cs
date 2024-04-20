namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();
            int soma = calc.soma(1, 10);
            int subtracao = calc.subtrair(1, 10);
            int multiplicar = calc.multiplica(1, 10);
            int dividir = calc.dividir(1, 10);
            Console.WriteLine($"a soma dos numeros é {soma} e a subtração é {subtracao}, a multiplicação é {multiplicar} e a divisão é {dividir}");
        }
    }
}

