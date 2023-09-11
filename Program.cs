namespace BusinessCalculation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        Console.WriteLine($"Good Afternoon! {name}, you are welcome to our company.");
        Console.WriteLine($"Please, {name} kindly choose your favourite country you would like to visit.");
        Console.WriteLine("1. Africa \n2. Europe");
        string? country = Console.ReadLine();

        if (country == "1")  
        {
          ProcessNetIncome();
        }
        else
        {
          ProcessTotalAsset();
        }

    }

      // ! processNetIncome
      private static void ProcessNetIncome()
      {
        Console.WriteLine("Please provide your revenue data");
        double revenue = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Please Provide your expenses data");
        double expenses = Convert.ToDouble(Console.ReadLine()); 

        double result = NetIncome(revenue, expenses);

        if (result < 500)
        {
        Console.WriteLine($"Please, the company total Net income is {result} which is very poor, we need to find a lasting solution.");
        }  
        else
        {
        Console.WriteLine($"The company net income is {result} is good very fine.");
        }      

      }
      // ! ProcessTotalAsset
      private static void ProcessTotalAsset()
      {
        Console.WriteLine("Please provide your liability data");
        double liability = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Please Provide your equity data");
        double equity = Convert.ToDouble(Console.ReadLine()); 

        double answer = NetIncome(liability, equity);
        Console.WriteLine($"Your total Net income is {answer}.");

      }

    // ***NetIncome****.
       private static double NetIncome(double revenue, double expenses)
       {
         double total = revenue - expenses;
         return total;
       }

    // ***TotalAsset****.
       private static double TotalAsset(double liability, double equity)
       {
         double result = liability + equity;
         return result;
       }
}

