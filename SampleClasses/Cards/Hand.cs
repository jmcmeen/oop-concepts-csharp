namespace LabUtils.Cards
{
    internal class Hand
    {
        public List<Card> Cards { get; set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

        public void RemoveAllCards()
        {
            Cards.Clear();
        }
    }
}
