using System.Security.Cryptography;
using System.Threading.Channels;

namespace Task11
{
    public interface IChangeCalculator
    {
        Dictionary<Coin, int> GetChange(int euros, int cent);
    }
    
    public class ChangeCalculator : IChangeCalculator
    {
        private const int CountOfCentInEuro = 100;
        
        public static IChangeCalculator GetInstance() => new ChangeCalculator();

        private ChangeCalculator() { }
        
        public Dictionary<Coin, int> GetChange(int euros, int cent)
        {
            ValidateMoney(euros, cent);

            var coins = new Dictionary<Coin, int>();

            var totalAmount = euros * CountOfCentInEuro + cent;

            var enumValues = Enum.GetValues(typeof(Coin));
            Array.Reverse(enumValues);
            
            foreach (Coin coin in enumValues)
            {
                
                if (totalAmount < (int)coin) continue;
                coins[coin] = totalAmount / (int)coin;
                totalAmount  %= (int)coin;
            }

            return coins;
        }
    
        private void ValidateMoney(int euros, int cent)
        {
            if (euros < 0)
                throw new ArgumentException($"Invalid parameter {nameof(euros)}, it should be more or equal 0.");

            if (cent < 0)
                throw new ArgumentException($"Invalid parameter {nameof(cent)}, it should be more or equal 0.");
        }
    }
    
    
}