using DeckOfCards.Utilities;

namespace SampleClasses.Cards
{
    /// <summary>
    /// Models a deck of playing cards
    /// </summary>
    internal class Deck
    {
        //public fields
        private Stack<Card> _cards;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Deck(bool shuffle = false)
        {
            //initialize memory for the card list
            _cards = new Stack<Card>();

            //Create all 52 combinations of Suit and Rank
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    _cards.Push(new Card(s, r));
                }
            }

            if (shuffle) { _cards.Shuffle(); }
        }

        /// <summary>
        /// Creates a list of cards taken from the deck
        /// </summary>
        /// <param name="numCards">The number of cards to take from the top of the card list</param>
        /// <returns>A new list of cards of size numCards</returns>
        public Hand? DealHand(uint numCards)
        {
            Hand? h = null;

            if (_cards.Count >= numCards)
            {
                h = new Hand();

                for (int i = 0; i < numCards; i++)
                {
                    h.AddCard(_cards.Pop());
                }
            }
            return h;
        }

        public Card? DealCard()
        {
            Card? c;
            _cards.TryPop(out c);
            return c;
        }

        /// <summary>
        /// Shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            _cards.Shuffle();
        }
    }
}
