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
            // Console.WriteLine("2 -> Compostos");
            string typeOfInterest = Console.ReadLine()!;

            Console.WriteLine("Digite o valor do capital aplicado:");
            Decimal amount = Decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o valor da taxa de Juros(somente o número):");
            Decimal interestRate = Decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("A taxa é anual ou mensal?");
            Console.WriteLine("1 -> Anual");
            Console.WriteLine("2 -> Mensal");
            string typeOfDeadline = Console.ReadLine()!;
            // transformar a taxa de quando for anual para mensal
            Decimal interestPerMonth = typeOfDeadline == "1" ? (interestRate / 12) / 100 : interestRate / 100; // de porcentagem para decimal

            Console.WriteLine("Em quantos meses:");
            // transformar de anos para meses
            int numberOfMonths = int.Parse(Console.ReadLine()!);

            GetInterest(typeOfInterest, amount, interestPerMonth, numberOfMonths);
        }

        static void GetInterest(string typeOfInterest, Decimal amount, Decimal interestPerMonth, int numberOfMonths)
        {
            switch (typeOfInterest)
            {
                case "1":
                    Decimal finalValue = amount * interestPerMonth * numberOfMonths;

                    Console.WriteLine("---------------------");
                    Console.WriteLine("O valor de juros: R$" + finalValue.ToString("C"));
                    Console.WriteLine("O valor total do montante: R$" + (amount + finalValue).ToString("C"));
                    break;
                case "2":
                    Console.WriteLine("Composto");
                    break;

                default:
                    Console.WriteLine("Selecione um valor válido!");
                    Menu();
                    break;
            }
        }
    }
}