namespace Programlogiktest;

public class MooTest
{
    [Fact]
    public void TestAmountOfReturningNumbers()
    {
        var mooGameLogic = new MooGameLogic();
        string fourNumbers = "1234";

        if (mooGameLogic.GetRandomNumbers().Length != fourNumbers.Length)
            throw new Exception();
    }

    [Fact]
    public void TestMatchingNumbersResult()
    {
        var mooGameLogic = new MooGameLogic();

        if (mooGameLogic.CheckMatchingNumbers("1234", "1234") != "BBBC")
            throw new Exception();
    }
}