namespace LogicOperations;

internal class Program
{
    public static bool GetTemperature()
    {
        return true;
    }

    public static bool GetCoolingStatus()
    {
        return true;
    }


    private static void Main(string[] arg)
    {
        // int fanSpeed = 0;
        //
        // bool isHightTemperature = false;
        //
        // bool hasNoCooling = fanSpeed <= 0;

        if (GetTemperature() || GetCoolingStatus()) Console.WriteLine("Warning, the processor is overheating");
    }
}