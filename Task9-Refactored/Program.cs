namespace Task9-Refactored
{
    class Program
    {
        private static readonly StringParser StringParser = new();
        private static readonly Calculator Calculator = new();
        
        static void Main(string[] args)
        {
            while (true)
            {
                //Parse strings
                var value1 = GetNew("Please, input value1.", StringParser.GetValue);
                var action1 = GetNew("Please input first action", StringParser.GetAction);
                var value2 = GetNew("Please, input value2.", StringParser.GetValue);
                var action2 = GetNew("Please input second action", StringParser.GetAction);
                var value3 = GetNew("Please, input value3.", StringParser.GetValue);
                
                //Calc
                var calcResult = Calculator.ThreeValuesCalc(value1, value2, value3, action1, action2);
                Console.WriteLine($"Granulate! Your result is {calcResult}");
                
                //Continue
                Console.WriteLine("Please enter any key to continue");
                Console.ReadKey();
            }
        }

        private static T GetNew<T>(string requestMessage, Func<string?, T> func)
        {
            try
            {
                Console.WriteLine(requestMessage);
                var str = Console.ReadLine();
                
                return func(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetNew(requestMessage, func);
            }
        }
    }
}