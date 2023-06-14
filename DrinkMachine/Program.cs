using DrinkMachine.Interface;

namespace DrinkMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine();
            while (true)
            {
                IWarmDrink drink = machine.MakeDrink();
                if (drink == null)
                {
                    break; // Avslutar loopen om användaren har valt att avsluta
                }

                drink.Consume();
            }
        }
    }
}