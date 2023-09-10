namespace BusinessCalculation;

class Program
{
    static void Main(string[] args)
    {
        // * This will render the netIncome, NB: we are using the short process in this case.
        Console.WriteLine("***Let's start by calculating the Total Asset of the company**!!!");

        Console.WriteLine("What is the liability?");
        double liability = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the equity");
        double equity = Convert.ToDouble(Console.ReadLine());

        double totalAsset = TotalAsset(liability,equity);

        // ! condition for total assets...
       if (totalAsset <= 500)
       {
        Console.WriteLine($"The total asset result is {totalAsset} very poor asset capital");   
       }
        else
        {
        Console.WriteLine($"The total asset is Very good with {totalAsset}");
        }

    }

    // * This will rhe inherit at the top-level code.
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
