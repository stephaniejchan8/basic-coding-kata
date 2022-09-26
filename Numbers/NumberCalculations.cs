namespace f_basic_coding;

public class NumberCalculations : UserInput
{
    // private int _inputNumber;
    private int _total;

    // private void RequestNumber()
    // {
    //     Console.WriteLine("Enter a number:");
    //     var inputNumberString = Console.ReadLine();
    //
    //     IsValidNumber(inputNumberString);
    // }

    public void RunSumOf1ToNumber()
    {
        ObtainValidatedNumber();
        SumOf1ToNumber();
        StandardMessages.PrintSum(_inputNumber, _total);
    }

    public void RunSumMultiplesOf3Or5()
    {
        ObtainValidatedNumber();
        SumMultiplesOf3Or5();
        StandardMessages.PrintSumMultiplesOf3Or5(_inputNumber, _total);
        // }
    }

    public void RunProductOf1ToNumber()
    {
        ObtainValidatedNumber();
        ProductOf1ToNumber();
        StandardMessages.PrintProductOf1ToNumber(_inputNumber, _total);
    }

    private void SumOf1ToNumber()
    {
        for (var i = 1; i <= _inputNumber; i++)
        {
            _total += i;
        }
    }

    private void SumMultiplesOf3Or5()
    {
        for (var i = 1; i <= _inputNumber; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                _total += i;
            }
        }
    }

    private void ProductOf1ToNumber()
    {
        if (_inputNumber == 0)
        {
            _total = 0;
        }
        else
        {
            _total = 1;
            for (var i = 1; i <= _inputNumber; i++)
            {
                _total *= i;
            }
        }
    }
}


// public void RunSumMultiplesOf3Or5()
// {
//     // var inputNumberString = RequestNumber();
//     // if (IsValidNumber(inputNumberString))
//     // {
//     SumMultiplesOf3Or5();
//     StandardMessages.PrintSumMultiplesOf3Or5(_inputNumber, _total);
//     // }
// }