using NUnit.Framework;
using Bowling.Model;

namespace Bowling.Test;

public class FrameTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AStrikeIsWorth10PointsPlusTheNextTwoBowls()
    {
        Frame f = new Frame("X");
        f.NextFrame = new Frame("34");
        Assert.AreEqual(17, f.Score());

        f = new Frame("X");
        f.NextFrame = new Frame("2/");
        Assert.AreEqual(20, f.Score());

        f = new Frame("X");
        Frame nextFrame = new Frame("X");
        nextFrame.NextFrame = new Frame("X");
        f.NextFrame = nextFrame;
        Assert.AreEqual(30, f.Score());
    }

    [Test]
    public void ScoreIsTotalOfPinsBowledIn2Attempts(){
        Frame f = new Frame("45");
        Assert.AreEqual(9, f.Score());

        f = new Frame("61");
        Assert.AreEqual(7, f.Score());

        f = new Frame("40");
        Assert.AreEqual(4, f.Score());

        f = new Frame("03");
        Assert.AreEqual(3, f.Score());
    }

    [Test]
    public void ASpareIsWorth10PointsPlusNextBowl(){
        Frame f = new Frame("4/");
        f.NextFrame = new Frame("43");
        Assert.AreEqual(14, f.Score());

        f = new Frame("0/");
        f.NextFrame = new Frame("34");
        Assert.AreEqual(13, f.Score());

        f = new Frame("1/");
        f.NextFrame = new Frame("5/");
        Assert.AreEqual(15, f.Score());

        f = new Frame("2/");
        f.NextFrame = new Frame("X");
        Assert.AreEqual(20, f.Score());
    }
}