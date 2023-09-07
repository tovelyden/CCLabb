namespace CC_labb;

public class MooGameLogic
{
    public string GetRandomNumbers()
    {
        Random randomGenerator = new Random();
        string randomNumbers = "";
        for (int i = 0; i < 4; i++)
        {
            int randomNumber = randomGenerator.Next(10);
            string randomDigit = randomNumber.ToString();
            while (randomNumbers.Contains(randomDigit))
            {
                randomNumber = randomGenerator.Next(10);
                randomDigit = randomNumber.ToString();
            }
            randomNumbers += randomDigit;
        }
        return randomNumbers;
    }
    public string CheckMatchingNumbers(string numbers, string guessingNumbers)
    {
        int cows = 0, bulls = 0;
        guessingNumbers += "    ";
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (numbers[i] == guessingNumbers[j])
                {
                    if (i == j)
                    {
                        bulls++;
                    }
                    else
                    {
                        cows++;
                    }
                }
            }
        }
        return "BBBB".Substring(0, bulls) + "CCCC".Substring(0, cows);
    }
}
