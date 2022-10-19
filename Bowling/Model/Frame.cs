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
        if (Bowled.Equals("X") || Bowled.EndsWith("/")){
            return 10;
        }

        int firstBowl = Int32.Parse(Bowled[0].ToString());
        int secondBowl = Int32.Parse(Bowled[1].ToString());
        int score = firstBowl + secondBowl;

        return score;
    }
}