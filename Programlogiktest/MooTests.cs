using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
using System.Diagnostics;
using Xunit.Abstractions;

namespace Programlogiktest;

public class MooTests
{
    MooGameLogic mooGameLogic = new MooGameLogic();

    private readonly ITestOutputHelper output;

    public MooTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    [Fact]
    public void TestAmountOfReturningRandomNumbers()
    {
        string fourNumbers = "1234";

        if (mooGameLogic.GetRandomNumbers().Length != fourNumbers.Length)
            throw new Exception();
    }

    [Fact]
    public void TestIfAllReturningNumbersAreDifferent()
    {
       
    }

    [Fact]
    public void TestMatchingNumbersRightPlace()
    {
        if (mooGameLogic.CheckMatchingNumbers("1234", "1234") != "BBBB")
            throw new Exception();
    }

    [Fact]
    public void TestMatchingNumbersWrongPlace()
    {
        if (mooGameLogic.CheckMatchingNumbers("1234", "4321") != "CCCC")
            throw new Exception();
    }

    [Fact]
    public void TestMatchingNumbersWrongNumbers()
    {
        if (mooGameLogic.CheckMatchingNumbers("1234", "5678") != "")
            throw new Exception();
    }
}