namespace Blackjack;

internal class Program
{
    private static void Main(string[] args)
    {
        var shoe = new Shoe();

        for (int i = 0; i < 52 * 4; i++)
        {
            Console.WriteLine(shoe.DrawCard());
        }
    }
}