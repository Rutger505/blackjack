namespace Blackjack;

public enum Face
{
    Two = 2,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
}

public enum Suit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public class Card(Face face, Suit suit)
{
    public Face Face { get; } = face;

    public Suit Suit { get; } = suit;

    public override string ToString() => $"{Face} of {Suit}";
}