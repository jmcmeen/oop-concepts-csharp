namespace LabUtils.Cards
{
    /// <summary>
    /// Models a playing card
    /// </summary>
    internal class Card
    {
        // public auto-implemented properties
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

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            var that = (Card)obj;

            return Suit.Equals(that.Suit) && Rank == that.Rank;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Rank, Suit);
        }
    }
}
