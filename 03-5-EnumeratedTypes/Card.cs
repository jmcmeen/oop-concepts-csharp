/// File: Card.cs
/// Name: John McMeen 
/// Email: jnmcmeen@northeaststate.edu
/// Project: CISP 1020 Examples
namespace _03_5_EnumeratedTypes
{
    /// <summary>
    /// Models a playing card
    /// </summary>
    internal class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="suit">The card's suit</param>
        /// <param name="rank">The card's rank</param>
        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return Rank + " of " + Suit;
        }
    }
}
