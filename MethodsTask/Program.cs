using System.Xml;

namespace Methods
{
    class Program
    {
        static int IndexOf(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static int[] RandomNmbers(int arrSize, int minValue, int maxValue)
        {
            int[] myArray = new int[arrSize];
            Random random = new Random();
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter index value to find in Array >>>>>: ");
            int value = int.Parse(Console.ReadLine());
          

            int[] myArray = RandomNmbers(10, 0, 15 );

            int result = IndexOf(myArray, value);

            string consoleResult = result == -1
                ? $"Value {value} is not existing in Array!"
                : $"Index of value {value} is {result} !";

            Console.WriteLine(consoleResult);

       

        }
    }
}