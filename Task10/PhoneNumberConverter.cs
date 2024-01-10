namespace Task10;

public class IllegalPhoneNumberException : Exception
{
    public IllegalPhoneNumberException(string message) : base(message)
    {
    }
}

public class PhoneNumberConverter
{
    private static readonly char[] ValidChars =
    {
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
        'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
        'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
    };

    private static readonly char[] MappedDigits =
    {
        '2', '2', '2', '3', '3', '3', '4', '4', '4',
        '5', '5', '5', '6', '6', '6', '7', '7', '7',
        '7', '8', '8', '8', '8', '9', '9', '9', '9'
    };

    public static string ConvertToNumbers(string phoneNumber)
    {
        string result = "";

        foreach (char c in phoneNumber)
        {
            char upperC = char.ToUpper(c);
            if (Array.IndexOf(ValidChars, upperC) != -1)
            {
                int index = Array.IndexOf(ValidChars, upperC);
                result += MappedDigits[index];
            }
            else
            {
                throw new IllegalPhoneNumberException("Invalid character in the phone number sequence");
            }
        }

        return result;
    }
}