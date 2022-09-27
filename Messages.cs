namespace f_basic_coding;

public class Messages
{
    public static void PrintInvalidDataMessage()
    {
        Console.WriteLine("User input is not in correct format. Please try again. \n");
    }

    public static void PrintSum(int inputNumber, int total)
    {
        Console.WriteLine($"Sum of numbers from 1 to {inputNumber}: {total}");
    }
    public static void PrintSumMultiplesOf3Or5(int inputNumber, int total)
    {
        Console.WriteLine($"Sum of numbers from 1 to {inputNumber} that are a multiple of 3 or 5: {total}");
    }

    public static void PrintProductOf1ToNumber(int inputNumber, int total)
    {
        Console.WriteLine($"Product of numbers from 1 to {inputNumber}: {total}");
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
}