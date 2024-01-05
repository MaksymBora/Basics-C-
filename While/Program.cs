namespace While;

internal class Program
{
    private static void Main(string[] args)
    {
        // ------------- While ----------
        // int count = 0;
        // int limit = int.Parse(Console.ReadLine());
        // while (count < limit)
        // {
        //     count++;
        //     Console.WriteLine(count);
        // }

        // ------------- do  While ----------

        // do
        // {
        //     Console.WriteLine("At least one time executing");
        // } while (true);

        // int count = 0;
        //
        // do
        // {
        //     count++;
        //     
        //     Console.WriteLine(count);
        // } while (count < 5);

        // ----------- Count even & odd numbers ---------- //

        uint oddNumbersCount = 0;
        uint evenNumbersCount = 0;

        var oddNumbersSum = 0;
        var evenNumbersSum = 0;

        Console.WriteLine("Enter first value");
        var currentValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter last value");
        var limit = int.Parse(Console.ReadLine());

        while (currentValue <= limit)
        {
            if (currentValue % 2 == 0)
            {
                evenNumbersCount++;
                evenNumbersSum += currentValue;
            }
            else
            {
                oddNumbersCount++;
                oddNumbersSum += currentValue;
            }

            currentValue++;
        }

        Console.WriteLine("Quantity of odd numbers: " + oddNumbersCount);
        Console.WriteLine("Quantity of even numbers: " + evenNumbersCount);

        Console.WriteLine("Sum of odd numbers: " + oddNumbersSum);
        Console.WriteLine("Sum of even numbers: " + evenNumbersSum);
    }
}