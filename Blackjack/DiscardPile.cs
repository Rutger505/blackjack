namespace Blackjack;

public class DiscardPile
{
    private List<Card> Cards { get; } = new();

    // + DiscardCard() : void
    // + EmptyPile() : List<Card>

    public void Discard(Card card)
    {
        Cards.Add(card);
    }

    public List<Card> EmptyPile()
    {
        var cards = Cards.ToList();
        Cards.Clear();
        return cards;
    }
}