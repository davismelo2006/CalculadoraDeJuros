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

            Console.WriteLine("Digite o valor da taxa de Juros:");
            Decimal interestRate = Decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("A taxa é anual ou mensal?");
            Console.WriteLine("1 -> Anual");
            Console.WriteLine("2 -> Mensal");
            string typeOfDeadline = Console.ReadLine()!;
            Decimal interestTime = 0;
            // transformar tudo em MESES
            if (typeOfDeadline == "1")
            {
                interestTime = Decimal.Round(interestRate / 12, 2);
            }

            Console.WriteLine("Qual o periodo em meses?");
            // criar opção em anos
            int numberOfMonths = int.Parse(Console.ReadLine()!);

            GetInterest(typeOfInterest, amount, interestRate, interestTime, numberOfMonths);
        }

        static void GetInterest(string typeOfInterest, Decimal amount, Decimal interestRate, Decimal interestTime, int numberOfMonths)
        {
            switch (typeOfInterest)
            {
                case "1":

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