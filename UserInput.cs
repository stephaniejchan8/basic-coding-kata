namespace f_basic_coding;

public class UserInput
{
    public int ObtainValidatedNumber()
    {
        var inputNumberString = RequestNumber();
        int inputNumber;
        while (!int.TryParse(inputNumberString, out inputNumber))
        {
            Messages.PrintInvalidDataMessage();
            inputNumberString = RequestNumber();
        }

        return inputNumber;
    }
    private static string? RequestNumber()
    {
        Console.WriteLine("Enter a number:");
        return Console.ReadLine();
    }

    private static string RequestSumOrProduct()
    {
        Console.WriteLine("Would you like to calculate the sum or product of the numbers from 1 to your input number?");
        return Console.ReadLine();
    }

    public string CheckIfSumOrProduct()
    {
        var userInput = RequestSumOrProduct().Trim().ToLower();
        while (userInput != "sum" && userInput != "product")
        {
            Messages.PrintInvalidDataMessage();
            userInput = RequestSumOrProduct().Trim().ToLower();
        }
        return userInput;
    }
}