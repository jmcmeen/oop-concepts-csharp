/// File: Program.cs
/// Name: John McMeen 
/// Email: jnmcmeen@northeaststate.edu
/// Project: CISP 1020 Examples
namespace _03_Enumeration
{
    /// <summary>
    /// Demonstrates the use of the Deck class
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Create a deck object
            Deck deck = new Deck();

            //Show all cards
            Console.WriteLine("Display the whole deck");
            foreach(Card c in deck.cards)
            {
                Console.WriteLine(c);
            }

            //Show top 5 cards
            Console.WriteLine("\n\nDisplay top five cards of the deck");
            foreach (Card c in deck.DealHand(5))
            {
                Console.WriteLine(c);
            }
        }
    }
}
