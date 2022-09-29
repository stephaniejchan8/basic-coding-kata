namespace f_basic_coding;

public class MultiplicationTable
{
    private UserInput _userInput = new UserInput();
    public void RunMultiplicationTable()
    {
        var inputNumber = _userInput.ObtainValidatedNumber();
        for (var i = 1; i <= 12; i++)
        {
            Messages.PrintMultiplication(i, inputNumber);
        }
    }
}