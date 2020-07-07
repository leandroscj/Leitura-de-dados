using System;

namespace Leitura_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string  nome = Console.ReadLine();

            Console.WriteLine("Quantos Quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Coloque o preço de um produto:");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ultimo nome, idade e altura (na mesma linha)");
            string[] vet2 = Console.ReadLine().Split(' ');
            string unome = vet2[0];
            int idade = int.Parse(vet2[1]);
            double altura = double.Parse(vet2[2]);

            Console.Clear();

            Console.WriteLine("Seus dados são:");
            Console.WriteLine("Seu nome é "+nome);
            Console.WriteLine("Sua casa tem " +quartos+ " quarto(s)");
            Console.WriteLine("O valor do produto é: R$"+ produto);
            Console.WriteLine("Seu ultimo nome é: "+unome);
            Console.WriteLine("Sua idade é: "+idade);
            Console.WriteLine("Sua altura é: "+altura);

        }
    }
}
