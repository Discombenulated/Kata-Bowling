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

    [Test]
    public void GameScoreIsAdditionOfFrameScoresIncludingSpares()
    {
        Game g = new Game();
        g.AddFrame(new Frame("45"));
        g.AddFrame(new Frame("2/"));
        g.AddFrame(new Frame("10"));
        Assert.AreEqual(21, g.Score());
    }

    [Test]
    public void GameScoreIsAdditionOfFrameScoresIncludingStrikes()
    {
        Game g = new Game();
        g.AddFrame(new Frame("45"));
        g.AddFrame(new Frame("X"));
        g.AddFrame(new Frame("12"));
        Assert.AreEqual(25, g.Score());
    }

    [Test]
    public void CanConstructGameFromString(){
        Game g = new Game("12 34 56");
        Assert.AreEqual(21, g.Score());
    }

    [Test]
    public void OriginalExampleTest(){
        Game g = new Game("X 45 4/ 32");
        Assert.AreEqual(46, g.Score());
    }
}