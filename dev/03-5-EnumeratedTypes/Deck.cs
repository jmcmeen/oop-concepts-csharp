namespace _03_5_EnumeratedTypes
{
    /// <summary>
    /// Models a deck of playing cards
    /// </summary>
    internal class Deck
    {
        //public fields
        public List<Card> cards;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Deck()
        {
            //initialize memory for the card list
            cards = new List<Card>();

            //Create all 52 combinations of Suit and Rank
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(s, r));
                }
            }
        }

        /// <summary>
        /// Creates a list of cards taken from the deck
        /// </summary>
        /// <param name="numCards">The number of cards to take from the top of the card list</param>
        /// <returns>A new list of cards of size numCards</returns>
        public List<Card> DealHand(uint numCards)
        {
            if (numCards > 0 && numCards <= cards.Count)
            {
                List<Card> hand = new List<Card>();

                for (int i = 0; i < numCards; i++)
                {
                    hand.Add(cards[i]);
                }

                return hand;
            }

            return null;
        }

        /// <summary>
        /// Shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
