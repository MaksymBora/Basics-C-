using Task10;
using Xunit;

namespace TestTask10
{
    public class ConverterTests
    {
        [Fact]
        public void ConvertToNumbers_ValidInput_ReturnsConvertedNumbers()
        {
            // Arrange
            string input = "CALLME";
            string expected = "225563";

            // Act
            string result = PhoneNumberConverter.ConvertToNumbers(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToNumbers_InvalidCharacter_ThrowsIllegalPhoneNumberException()
        {
            // Arrange
            string input = "123-456";
            
            // Act & Assert
            Assert.Throws<Task10.IllegalPhoneNumberException>(() =>
            {
                PhoneNumberConverter.ConvertToNumbers(input);
            });
        }

        [Fact]
        public void ConvertToNumbers_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = PhoneNumberConverter.ConvertToNumbers(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}