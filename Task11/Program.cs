namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = ChangeCalculator.GetInstance();
            var coins = calculator.GetChange(3, 50);

            foreach (var (coin, count) in coins)
                Console.WriteLine($"{coin}: {count}");
        }
    }
}