namespace f_basic_coding;

public class NamePrinter
{
    public void RunPrintName()
    {
        var inputName = RequestName();
        PrintName(inputName);
    }

    public void RunValidateAndPrintNames()
    {
        var inputName = RequestName();
        if (IsValidName(inputName))
        {
            PrintName(inputName);
        }
        else
        {
            Console.WriteLine("Incorrect name entered. \n");
        }
    }

    public string RequestName()
    {
        Console.WriteLine("Enter your name: ");
        var inputName = Console.ReadLine();
        return inputName;
    }

    public static bool IsValidName(string inputName)
    {
        var formattedInputName = inputName.Trim().ToLower();
        return formattedInputName is "alice" or "bob";
    }

    public void PrintName(string inputName)
    {
        Console.WriteLine($"Hello {inputName}");
    }
}