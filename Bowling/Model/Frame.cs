namespace Bowling.Model;

public class Frame
{
    private const int MAX_SCORE = 10;
    private readonly string Bowled;
    public Frame(string bowled)
    {
        Bowled = bowled;
    }

    public int Score()
    {
        if (IsStrike() || IsSpare())
        {
            return MAX_SCORE;
        }

        return GetFirstBowl() + GetSecondBowl();
    }

    private bool IsStrike()
    {
        return Bowled.Equals("X");
    }

    private bool IsSpare()
    {
        return Bowled.EndsWith("/");
    }

    private int GetFirstBowl()
    {
        return Int32.Parse(Bowled[0].ToString());
    }

    private int GetSecondBowl()
    {
        return Int32.Parse(Bowled[1].ToString());
    }
}