namespace Programlogiktest;

public class MooTests
{
    MooGameLogic mooGameLogic = new MooGameLogic();

    [Fact]
    public void TestAmountOfReturningRandomNumbers()
    {
        string fourNumbers = "1234";

        if (mooGameLogic.GetRandomNumbers().Length != fourNumbers.Length)
            throw new Exception();
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