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
        int score = 0;
        for (int i = 0; i < Frames.Count; i++){
            Frame current = Frames[i];
            if (i < Frames.Count-1){
                current.NextFrame = Frames[i+1];
            }
            score += current.Score();
        }
        return score;
    }
}