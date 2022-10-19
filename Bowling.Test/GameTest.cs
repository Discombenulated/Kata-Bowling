using NUnit.Framework;
using Bowling.Model;

namespace Bowling.Test;

public class GameTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GameScoreIsAdditionOfFrameScores()
    {
        Game g = new Game();
        g.AddFrame(new Frame("45"));
        g.AddFrame(new Frame("32"));
        g.AddFrame(new Frame("10"));
        Assert.AreEqual(15, g.Score());
    }
}