using System;
namespace AppJuros
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("-------Calculadora de Juros-------");
            Console.WriteLine("Qual o tipo de Juros?");
            Console.WriteLine("1 -> Simples");
            Console.WriteLine("2 -> Compostos");
            string typeOfInterest = Console.ReadLine()!;

            Console.WriteLine("Digite o valor do capital aplicado:");
            double amount = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o valor da taxa de Juros(somente o número):");
            double interestRate = double.Parse(Console.ReadLine()!);

            Console.WriteLine("A taxa é anual ou mensal?");
            Console.WriteLine("1 -> Anual");
            Console.WriteLine("2 -> Mensal");
            string typeOfDeadline = Console.ReadLine()!;
            double interestPerMonth = typeOfDeadline == "1" ? (interestRate / 12) / 100 : interestRate / 100;

            Console.WriteLine("Em quantos meses:");
            // transformar de anos para meses, depois
            int numberOfMonths = int.Parse(Console.ReadLine()!);

            GetInterest(typeOfInterest, amount, interestPerMonth, numberOfMonths);
        }

        static void GetInterest(string typeOfInterest, double amount, double interestPerMonth, int numberOfMonths)
        {
            if (typeOfInterest == "1")
            {
                double finalValue = amount * interestPerMonth * numberOfMonths;

                Console.WriteLine("---------------------");
                Console.WriteLine("O valor de juros: R$" + finalValue.ToString("C"));
                Console.WriteLine("O valor total do montante: R$" + (amount + finalValue).ToString("C"));
            }
            else if (typeOfInterest == "2")
            {

                double finalValue = amount * Math.Pow(1 + interestPerMonth, numberOfMonths);

                Console.WriteLine("---------------------");
                Console.WriteLine("O valor de juros: R$" + (finalValue - amount).ToString("C"));
                Console.WriteLine("O valor total do montante: R$" + (finalValue.ToString("C")));
            }
        }
    }
}