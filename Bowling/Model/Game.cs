namespace Bowling.Model;

public class Game
{
    private List<Frame> Frames = new List<Frame>();
    public void AddFrame(Frame frame)
    {
        Frames.Add(frame);
    }

    public int Score()
    {
        return (from frame in Frames select frame.Score()).Sum();
    }
}