using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Financial Forecasting Tool ===");

        Console.Write("Enter current value (e.g., 1000): ");
        double currentValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual growth rate (e.g., 0.05 for 5%): ");
        double growthRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number of years to predict: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double predictedValue = Forecast.PredictFutureValue(currentValue, growthRate, years);
        Console.WriteLine($"\nPredicted Value after {years} years: {predictedValue:F2}");
    }
}
