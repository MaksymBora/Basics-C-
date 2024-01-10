namespace Task10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.Combine(currentDirectory, "phone_numbers.txt");

            List<string> convertedNumbers = ConvertFileToNumbers(filename);

            foreach (string number in convertedNumbers)
            {
                Console.WriteLine($"Converted number: {number}");
            }
            
            // Console.WriteLine($"Current directory: {Environment.CurrentDirectory}");
        }

        private static List<string> ConvertFileToNumbers(string filename)
        {
            var numbersList = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    try
                    {
                        string convertedNumber = PhoneNumberConverter.ConvertToNumbers(line);
                        numbersList.Add(convertedNumber);
                    }
                    catch (IllegalPhoneNumberException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return numbersList;
        }
    }
}