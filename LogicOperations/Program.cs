namespace LogicOperations;

class Program
{
    static void Main(string[] arg)
    {
        bool isHightTemperature = true;
        bool hasNoCooling = true;

        if (isHightTemperature && hasNoCooling)
        {
            Console.WriteLine("Warning, the processor is overheating");
        }
        
    }
}