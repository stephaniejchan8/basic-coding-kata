namespace f_basic_coding.Numbers;

public class NumberCalculations
{
    private UserInput _userInput = new UserInput();

    public void RunSumOf1ToNumber()
    {
        var inputNumber = _userInput.ObtainValidatedNumber();
        var total = SumOf1ToNumber(inputNumber);
        Console.WriteLine($"Sum of numbers from 1 to {inputNumber}: {total}");
    }

    public void RunSumMultiplesOf3Or5()
    {
        var inputNumber = _userInput.ObtainValidatedNumber();
        var total = SumMultiplesOf3Or5(inputNumber);
        Console.WriteLine($"Sum of numbers from 1 to {inputNumber} that are a multiple of 3 or 5: {total}");
    }

    public void RunSumOrProduct()
    {
        var userInput = _userInput.CheckIfSumOrProduct();
        if (userInput == "sum")
        {
            RunSumOf1ToNumber();
        }
        else
        {
            RunProductOf1ToNumber();
        }
    }

    public void RunProductOf1ToNumber()
    {
        var inputNumber = _userInput.ObtainValidatedNumber();
        var total = ProductOf1ToNumber(inputNumber);
        Console.WriteLine($"Product of numbers from 1 to {inputNumber}: {total}");
    }

    public int SumOf1ToNumber(int inputNumber)
    {
        var total = 0;
        for (var i = 1; i <= inputNumber; i++)
        {
            total += i;
        }

        return total;
    }

    public int SumMultiplesOf3Or5(int inputNumber)
    {
        var total = 0;
        for (var i = 1; i <= inputNumber; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                total += i;
            }
        }

        return total;
    }

    public int ProductOf1ToNumber(int inputNumber)
    {
        if (inputNumber == 0)
        {
            return 0;
        }

        var total = 0;
        for (var i = 1; i <= inputNumber; i++)
        {
            total *= i;
        }

        return total;
    }
}