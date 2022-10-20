namespace Bowling.Model;

public class Frame
{
    private const int MAX_SCORE = 10;
    private readonly string Bowled;
    public Frame NextFrame{
        private get;
        set;
    }

    public Frame(string bowled)
    {
        Bowled = bowled;
    }

    public int Score()
    {
        if (IsStrike())
        {
            return MAX_SCORE + NextFrame.GetFirstBowl() + NextFrame.GetSecondBowl();
        }

        if (IsSpare()){
            return MAX_SCORE + NextFrame.GetFirstBowl();
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
        if (IsStrike()){
            return MAX_SCORE;
        }
        
        return Int32.Parse(Bowled[0].ToString());
    }

    private int GetSecondBowl()
    {
        return Int32.Parse(Bowled[1].ToString());
    }
}