// See https://aka.ms/new-console-template for more information
// 1.

Console.WriteLine("Hello, World!");

// 2., 3. asks the user for their name and only greets you if you are Alice or Bob.
string name = "Alice";
if (name == "Alice" || name == "Bob")
{
    Console.WriteLine($"Hello {name}");
}

// 4. asks the user for a number n and prints the sum of the numbers 1 to n
int number = 2;
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i;
}

Console.WriteLine($"Sum of numbers from 1 to {number}: {sum}");

// 5. asks the user for a number n and prints the sum of the numbers 1 to n if the number is a multiple of three or five

int numberMultiple = 17;
int sumMultiple = 0;

for (int i = 0; i <= numberMultiple; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sumMultiple += i;
    }
}

Console.WriteLine($"Sum of numbers from 1 to {numberMultiple} that are a multiple of 3 or 5: {sumMultiple}");

// 6. asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n
int numberOption = 4;
string sumOrProduct = "product";
string formatSumOrProduct = char.ToUpper(sumOrProduct[0]) + sumOrProduct.Substring(1).ToLower();
Console.WriteLine(formatSumOrProduct);
int optionTotal = 0;
//string optionConsole = $"{formatSumOrProduct} of numbers from 1 to {numberOption}: {optionTotal}";

if (formatSumOrProduct == "Sum")
{
    for (int i = 1; i <= numberOption; i++)
    {
        optionTotal += i;
    }

    Console.WriteLine($"{formatSumOrProduct} of numbers from 1 to {numberOption}: {optionTotal}");
}
else if (formatSumOrProduct == "Product")
{
    optionTotal = 1;
    for (int i = 1; i <= numberOption; i++)
    {
        optionTotal *= i;
    }

    Console.WriteLine($"{formatSumOrProduct} of numbers from 1 to {numberOption}: {optionTotal}");
}

// 7. Write a program that prints a multiplication table for numbers up to 12.

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
for (int i = currentYr; counterLeap < 20; i++)
{
    if (i % 4 == 0)
    {
        Console.WriteLine(i);
        counterLeap++;
    }
}