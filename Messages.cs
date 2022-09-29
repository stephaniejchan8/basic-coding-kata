namespace f_basic_coding;

public class Messages
{
    public static void PrintInvalidDataMessage()
    {
        Console.WriteLine("User input is not in correct format. Please try again. \n");
    }

    public static void PrintMultiplication(int multiplier, int inputNumber)
    {
        Console.WriteLine($"{multiplier} x {inputNumber} = {multiplier * inputNumber}");
    }

    public static void PrintNext20LeapYears(int[] leapYears)
    {
        Console.WriteLine("The next 20 leap years:");
        foreach (int leapYear in leapYears)
        {
            Console.WriteLine(leapYear);
        }
    }

    // public static void PrintGuessResult(GuessResult result)
    // {
    //     if (result == GuessResult.Correct)
    //     {
    //         Console.WriteLine(
    //  $"You guessed correctly! The secret number was {secretNumber}. It took you {guessCounter} guesses to guess correctly.");
    //     }
}