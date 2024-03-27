namespace Blackjack;

public class Deck
{
    private List<Card> Cards { set; get; } = new();

    public Deck()
    {
        // Fill deck with 52 cards
        foreach (Suit suit in Enum.GetValues<Suit>())
        {
            foreach (Face face in Enum.GetValues<Face>())
            {
                Cards.Add(new Card(face, suit));
            }
        }
    }

    public List<Card> GetAllCards()
    {
        if (Cards.Count == 0)
        {
            throw new InvalidOperationException("Deck is empty");
        }

        List<Card> cards = Cards;
        Cards = new();
        return cards;
    }
}