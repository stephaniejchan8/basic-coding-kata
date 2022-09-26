namespace f_basic_coding;

public static class Startup
{
    public static void Run()
    {
        Console.WriteLine(@"Please select the program you would like to run:
1. Print Hello World
2. Greet the user
3. Greet the user if user's name matches the chosen names
4. Calculate the sum of numbers
5. Calculate the sum of numbers that are multiples of 3 or 5
6. Calculate the sum or product of numbers
");
        
        var chosenProgram = Console.ReadLine();
        switch (chosenProgram)
        {
            case "1":
                HelloWorld.PrintHelloWorld();
                break;
            case "2":
                var namePrinter = new NamePrinter();
                namePrinter.RunPrintName();
                break;
            case "3":
                namePrinter = new NamePrinter();
                namePrinter.RunValidateAndPrintNames();
                break;
            case "4":
                var numberCalculations = new NumberCalculations();
                numberCalculations.RunSumOf1ToNumber();
                break;
            case "5":
                numberCalculations = new NumberCalculations();
                numberCalculations.RunSumMultiplesOf3Or5();
                break;
            case "6":
                var userInput = new UserInput();
                userInput.CheckIfSumOrProduct();
                break;
            default:
                StandardMessages.PrintInvalidDataMessage();
                break;
        }
    }
    
    
}