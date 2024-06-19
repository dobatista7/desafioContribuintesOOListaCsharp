
using System.Globalization;

namespace desafioContribuintesOOListaCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Quantos contribuintes você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Digite os dados do {i + 1} o contribuinte: ");

                Console.Write("Renda anual com salário:  ");
                double  salaryIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Renda anual com prestação de serviço: ");
                double serviceIncome = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

                Console.Write("Renda anual com ganho de capital:  ");
                double capitalIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Gastos médicos: ");
                double heathSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Gastos educacionais:  ");
                double educationSpending = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

                TaxPayer taxPayer = new TaxPayer(salaryIncome, serviceIncome, capitalIncome, heathSpending, educationSpending);
                taxPayers.Add(taxPayer);

            }

        }
    }
}
