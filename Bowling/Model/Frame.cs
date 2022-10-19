namespace Bowling.Model;

public class Frame
{
    private readonly string Bowled;
    public Frame(string bowled)
    {
        Bowled = bowled;
    }

    public int Score()
    {
        if (IsStrike() || IsSpare())
        {
            return 10;
        }

        int score = GetFirstBowl() + GetSecondBowl();

        return score;
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