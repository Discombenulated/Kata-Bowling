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
    public void AStrikeIsWorth10Points()
    {
        Frame f = new Frame("X");
        Assert.AreEqual(10, f.Score());
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
    public void ASpareIsWorth10Points(){
        Frame f = new Frame("4/");
        Assert.AreEqual(10, f.Score());
    }
}