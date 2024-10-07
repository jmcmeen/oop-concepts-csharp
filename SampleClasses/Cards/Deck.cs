namespace SampleClasses.Cards
{
    /// <summary>
    /// Models a deck of playing cards
    /// </summary>
    /// <summary>
    /// Models a deck of playing cards
    /// </summary>
    internal class Deck
    {
        //public fields
        private List<Card> _drawPile;
        private List<Card> _discardPile;
        private static Random _rng = new Random();

        /// <summary>
        /// Default constructor
        /// </summary>
        public Deck()
        {
            //initialize memory for the piles
            _drawPile = new List<Card>();
            _discardPile = new List<Card>();

            //Create all 52 combinations of Suit and Rank
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    _drawPile.Add(new Card(s, r));
                }
            }
        }

        public Card DrawCard()
        {
            var c = _drawPile[0];
            _drawPile.RemoveAt(0);
            return c;
        }

        public void Discard(Card card)
        {
            _discardPile.Add(card);
        }

        public void ShuffleDrawPile()
        {
            _drawPile = _drawPile.OrderBy(_ => _rng.Next()).ToList();
        }
    }
}
