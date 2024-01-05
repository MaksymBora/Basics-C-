

namespace Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        var isCorrectPassword = false;
        
        while (!isCorrectPassword)
        {
            Console.WriteLine("Please enter your password!");
            var password = Console.ReadLine();

            if (password == "123")
            {
                isCorrectPassword = true;
                Console.WriteLine("Cash Box is opened");
            }
            else
                Console.WriteLine("Password is incorrect!");
        }
    }
}