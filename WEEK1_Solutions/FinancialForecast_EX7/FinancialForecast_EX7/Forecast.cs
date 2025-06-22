public static class Forecast
{
    // Recursive method to calculate future value
    public static double PredictFutureValue(double initialValue, double growthRate, int years)
    {
        if (years == 0)
            return initialValue;
        return PredictFutureValue(initialValue * (1 + growthRate), growthRate, years - 1);
    }
}
