namespace SampleClasses.Cards
{
    /// <summary>
    /// Models a deck of playing cards
    /// </summary>
    internal class Deck
    {
        //public fields
        private List<Card> _cards;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Deck()
        {
            //initialize memory for the card list
            _cards = new List<Card>();

            //Create all 52 combinations of Suit and Rank
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    _cards.Add(new Card(s, r));
                }
            }
        }

    }
}
