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
}