namespace f_basic_coding.Guessing;

public class GuessingGame
{
    // 8. Write a guessing game where the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed should be printed. It counts only as one try if they input the same number multiple times consecutively.
    private UserInput _userInput = new UserInput();
    public int GuessCounter = 0;

    public void RunGuessingGame()
    {
        var secretNumber = ObtainSecretNumber();
        var userGuess = _userInput.ObtainValidatedNumber();
        GuessCounter++;
        
        while (CheckGuess(userGuess, secretNumber) != GuessResult.Correct)
        {
            var userNextGuess = _userInput.ObtainValidatedNumber();
            UpdateGuessCounter(userGuess, userNextGuess);
            userGuess = userNextGuess;
        }

        Console.WriteLine(
            $"Congratulations! You guessed correctly the {secretNumber} correctly with {GuessCounter} guesses!");
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
        if (inputNumber < secretNumber)
        {
            Console.WriteLine("Incorrect - your guess is too low!");
            return GuessResult.UnderGuess;
        }
        
        Console.WriteLine("Incorrect - your guess is too high!");
            return GuessResult.OverGuess;
    }

    public void UpdateGuessCounter(int lastGuess, int currentGuess)
    {
        if (lastGuess != currentGuess)
        {
            GuessCounter++;
        }
    }
    
    // public bool IsSameGuess(int lastGuess, int currentGuess)
    // {
    //     return lastGuess == currentGuess;
    // }

}