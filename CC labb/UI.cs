namespace CC_labb;

public class UI : IUI
{
    public void WriteLine(string s)
    {
        Console.WriteLine(s);
    }
    public string Read()
    {
        return Console.ReadLine();
    }
    public void ClearConsole()
    {
        Console.Clear();
    }
    public void ExitProgram()
    {
        System.Environment.Exit(0);
    }
    public virtual string ShowResultForRound(int score)
    {
        return ("Correct, it took " + score + " guesses\n");
    }
}
