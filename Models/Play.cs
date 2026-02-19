namespace PlayGame;

internal class Play
{
    /*
    private int _score;

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }
    */

    public DateTime Date { get; set; }

    public int Score { get; set; }

    public PlayType Type { get; set; }
}

internal enum PlayType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}