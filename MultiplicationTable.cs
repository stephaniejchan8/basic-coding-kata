namespace f_basic_coding;

public class MultiplicationTable : UserInput
{
    public void RunMultiplicationTable()
    {
        ObtainValidatedNumber();
        for (var i = 1; i <= 12; i++)
        {
            Messages.PrintMultiplication(i, InputNumber);
        }
    }
}