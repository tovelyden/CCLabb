namespace CC_labb;

public interface IUI
{
    void WriteLine(string s);
    string Read();
    void ClearConsole();
    void ExitProgram();
    string ShowResultForRound(int score);
}
