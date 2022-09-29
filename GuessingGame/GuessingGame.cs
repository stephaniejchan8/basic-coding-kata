namespace f_basic_coding.GuessingGame;

public class GuessingGame
{
    // 8. Write a guessing game where the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed should be printed. It counts only as one try if they input the same number multiple times consecutively.
    // private int _secretNumber;
    private UserInput _userInput = new UserInput();
    
    public void RunGuessingGame()
    {
        var secretNumber = ObtainSecretNumber();
        var inputNumber = _userInput.ObtainValidatedNumber();
        CheckGuess(inputNumber, secretNumber);
    }
    
    private int ObtainSecretNumber()
    {
        Random rnd = new Random();
        return rnd.Next(1000);
    }
    
    public GuessResult CheckGuess(int inputNumber, int secretNumber)
    {
        if (inputNumber == secretNumber)
        {
            return GuessResult.Correct;
        }
        else if (inputNumber < secretNumber)
        {
            return GuessResult.UnderGuess;
        }
        else
        {
            return GuessResult.OverGuess;
        }
    }
}