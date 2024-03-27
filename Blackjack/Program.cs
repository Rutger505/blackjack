namespace Blackjack;

internal class Program
{
    private static void Main(string[] args)
    {
        var shoe = new Shoe();
        var discardPile = new DiscardPile();

        Console.WriteLine("Drawing cards...");
        while (true)
        {
            try
            {
                var drawnCard = shoe.DrawCard();
                discardPile.Discard(drawnCard);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Shoe is empty");
                break;
            }
        }

        var discardedCards = discardPile.EmptyPile();
        Console.WriteLine($"Cards drawn and put in discard pile: {discardedCards.Count}");
    }
}