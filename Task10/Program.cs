namespace Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string[] phoneNumbers =
            {
                "FAKULTAETFIW",
                "PIZZARUS",
                "GL00M",
                "FR?ST",
                "STADTVERWALTUNG"
            };

            foreach (string phoneNumber in phoneNumbers)
            {
                try
                {
                    string convertedNumber = PhoneNumberConverter.ConvertToNumbers(phoneNumber);
                    Console.WriteLine($"The converted number for '{phoneNumber}' is '{convertedNumber}'");
                }
                catch (IllegalPhoneNumberException e)
                {
                    Console.WriteLine(e.Message);
                    // Console.WriteLine($"Invalid character in phone number: '{phoneNumber}'");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}