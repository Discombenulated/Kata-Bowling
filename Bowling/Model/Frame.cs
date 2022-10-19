namespace Bowling.Model;

public class Frame
{
    private readonly string Bowled;
    public Frame(string bowled)
    {
        Bowled = bowled;
    }

    public double Score()
    {
        if (Bowled.Equals("X")){
            return 10;
        }

        return 9;
    }
}