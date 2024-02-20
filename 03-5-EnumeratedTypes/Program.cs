namespace _03_5_EnumeratedTypes
{
    /// <summary>
    /// Demonstrates the use of the Deck class
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        public static void Main()
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
