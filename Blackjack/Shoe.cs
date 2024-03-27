namespace Blackjack;

public class Shoe
{
    private Deck[] Decks { set; get; } = new Deck[4];
    private List<Card> Cards { set; get; } = new();

    public Shoe()
    {
        for (int i = 0; i < Decks.Length; i++)
        {
            Decks[i] = new();
            Cards.AddRange(Decks[i].GetAllCards());
        }
    }

    public void Shuffle()
    {
        if (Cards.Count == 0)
        {
            throw new InvalidOperationException("Shoe is empty");
        }

        Random random = new Random();
        Cards = Cards.OrderBy(card => random.Next()).ToList();
    }

    public Card DrawCard()
    {
        if (Cards.Count == 0)
        {
            throw new InvalidOperationException("Shoe is empty");
        }

        Card card = Cards[0];
        Cards.RemoveAt(0);
        return card;
    }
}