// Add data validation

var invalidDataMessage = "Input data is not in correct format. \n";

// 1. Hello, World!

Console.WriteLine("Hello, World! \n");


// 2., 3. asks the user for their name and only greets you if you are Alice or Bob.

Console.WriteLine("Enter your name: ");
var name = Console.ReadLine();
name = name.Trim();

if (name == "Alice" || name == "Bob")
{
    Console.WriteLine($"Hello {name} \n");
}
else
{
    Console.WriteLine("Incorrect name entered. \n");
}


// 4. asks the user for a number n and prints the sum of the numbers 1 to n

Console.WriteLine("Enter a number:");
var numberString = Console.ReadLine();

try
{
    var number = Int32.Parse(numberString);

    var sum = SumToN(number);
    Console.WriteLine($"Sum of numbers from 1 to {number}: {sum} \n");
}
catch (FormatException)
{
    Console.WriteLine(invalidDataMessage);
}


int SumToN(int number)
{
    var sum = 0;
    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}


// 5. asks the user for a number n and prints the sum of the numbers 1 to n if the number is a multiple of three or five

Console.WriteLine("Enter a number:");
var numberMultipleString = Console.ReadLine();

try
{
    var numberMultiple = Int32.Parse(numberMultipleString);

    var sumMultipleOf3or5 = 0;

    for (int i = 0; i <= numberMultiple; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            sumMultipleOf3or5 += i;
        }
    }

    Console.WriteLine(
        $"Sum of numbers from 1 to {numberMultiple} that are a multiple of 3 or 5: {sumMultipleOf3or5} \n");
}
catch (FormatException)
{
    Console.WriteLine(invalidDataMessage);
}


// 6. asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n
Console.WriteLine("Enter a number:");
var numberOptionString = Console.ReadLine();

try
{
    var numberOption = Int32.Parse(numberOptionString);

    Console.WriteLine("Would you like to calculate the sum or product of the numbers from 1 to your input number?");
    var sumOrProduct = Console.ReadLine();
    sumOrProduct = sumOrProduct.ToLower();

    var optionTotal = 0;
    var optionConsole = $"{sumOrProduct} of numbers from 1 to {numberOption}: ";


    if (numberOption == 0 && (sumOrProduct == "sum" || sumOrProduct == "product"))
    {
        Console.WriteLine(optionConsole + optionTotal);
    }

    else if (sumOrProduct == "sum")
    {
        optionTotal = SumToN(numberOption);
        Console.WriteLine(optionConsole + optionTotal);
    }

    else if (sumOrProduct == "product")
    {
        optionTotal = 1;
        for (int i = 1; i <= numberOption; i++)
        {
            optionTotal *= i;
        }

        Console.WriteLine(optionConsole + optionTotal);
    }

    Console.WriteLine("\n");
}
catch (FormatException)
{
    Console.WriteLine(invalidDataMessage);
}

// 7. Write a program that prints a multiplication table for numbers up to 12.

Console.WriteLine("Multiplication table: enter a number from 1 to 12 (inclusive):");
var multiplicationNumberString = Console.ReadLine();

try
{
    var multiplicationNumber = Int32.Parse(multiplicationNumberString);

    if (1 <= multiplicationNumber && multiplicationNumber <= 12)
    {
        for (var i = 1; i <= multiplicationNumber; i++)
        {
            var multiple = i * multiplicationNumber;
            Console.WriteLine($"{i} x {multiplicationNumber} = {multiple} \n");
        }
    }
}
catch
{
    Console.WriteLine(invalidDataMessage);
}

// 8. Write a guessing game where the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed should be printed. It counts only as one try if they input the same number multiple times consecutively.

// int numberGuess = 2;
// int secretNumber = 10;
// int counter = 0;
// if (numberGuess < secretNumber)
// {
//     Console.WriteLine($"{numberGuess} is less than the secret number.");
// }

// 9. Write a program that prints the next 20 leap years.

int currentYr = DateTime.Today.Year;
int counterLeap = 0;

Console.WriteLine("The next 20 leap years:");
for (int i = currentYr; counterLeap < 20; i++)
{
    if (i % 4 == 0)
    {
        Console.Write($"{i} ");
        counterLeap++;
    }
}