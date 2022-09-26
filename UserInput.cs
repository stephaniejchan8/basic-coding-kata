namespace f_basic_coding;

public class UserInput
{
    public int _inputNumber;
    private static string? RequestNumber()
    {
        Console.WriteLine("Enter a number:");
        return Console.ReadLine();
    }

    public void ObtainValidatedNumber()
    {
        var inputNumberString = RequestNumber();
        IsValidNumber(inputNumberString);
    }
    
    private bool IsValidNumber(string inputNumberString)
    {
        bool success = int.TryParse(inputNumberString, out var parsedNumber);
        if (success)
        {
            _inputNumber = parsedNumber;
            return success;
        }

        StandardMessages.PrintInvalidDataMessage();
        return false;
    }

    public static string? RequestSumOrProduct()
    {
        Console.WriteLine("Would you like to calculate the sum or product of the numbers from 1 to your input number?");
        return Console.ReadLine();
    }

    public void CheckIfSumOrProduct()
    {
        var numberCalculations = new NumberCalculations();
        var userInput = RequestSumOrProduct().Trim().ToLower();
        if (userInput == "sum")
        {
            numberCalculations.RunSumOf1ToNumber();   
        } else if (userInput == "product")
        {
            numberCalculations.RunProductOf1ToNumber();
        }
        else
        {
            StandardMessages.PrintInvalidDataMessage();
        }
    }
}