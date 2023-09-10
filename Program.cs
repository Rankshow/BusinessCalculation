namespace BusinessCalculation;

class Program
{
    static void Main(string[] args)
    {
        // ! This will render the netIncome, NB: we are using the long process in this case.
        Console.WriteLine("***Let's start by calculating the NetIncome of the company**!!!");
        Console.WriteLine("What is the Revenue?");
        string? Revenue = Console.ReadLine();
        double revenue = Convert.ToDouble(Revenue);

        Console.WriteLine("What is the expenses?");
        string? Expenses = Console.ReadLine();
        double expense = Convert.ToDouble(Expenses);

        double netIncome = NetIncome(revenue, expense);

        Console.WriteLine($"The NetIncome of the company is {netIncome}");


    }

    // * This will the inherit at the top-level code.
       private static double NetIncome(double revenue, double expenses)
       {
         double total = revenue - expenses;
         return total;
       }

       private static double TotalAsset(double liability, double equity)
       {
         double result = liability + equity;
         return result;
       }
}
