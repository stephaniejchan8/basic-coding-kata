// Add data validation

using f_basic_coding;

Startup.Run();

// // 7. Write a program that prints a multiplication table for numbers up to 12.
//
// Console.WriteLine("Multiplication table: enter a number from 1 to 12 (inclusive):");
// var multiplicationNumberString = Console.ReadLine();
//
// // tryparse
// // shorthand null check C#
// try
// {
//     if (multiplicationNumberString != null)
//     {
//         var multiplicationNumber = Int32.Parse(multiplicationNumberString);
//
//         if (1 <= multiplicationNumber && multiplicationNumber <= 12)
//         {
//             for (var i = 1; i <= multiplicationNumber; i++)
//             {
//                 var multiple = i * multiplicationNumber;
//                 Console.WriteLine($"{i} x {multiplicationNumber} = {multiple} \n");
//             }
//         }
//     }
// }
// catch
// {
//     Console.WriteLine(invalidDataMessage);
// }
//
// // 8. Write a guessing game where the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed should be printed. It counts only as one try if they input the same number multiple times consecutively.
// Random rnd = new Random();
// var secretNumber = rnd.Next(1000);
//
// var guess = 0;
// var guessCounter = 0;
//
// do
// {
//     Console.WriteLine("Guess the secret number - it is from 1 to 1000:");
//     var guessString = Console.ReadLine();
//
//     try
//     {
//         guess = Int32.Parse(guessString);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine(invalidDataMessage);
//         break;
//     }
//
//     guessCounter++;
//
//     if (guess < secretNumber)
//     {
//         Console.WriteLine("Your guessed number is too small. Try again. \n");
//     }
//     else
//     {
//         Console.WriteLine("Your guessed number is too big. Try again. \n");
//     }
// } while (guess != secretNumber);
//
// Console.WriteLine(
//     $"You guessed correctly! The secret number was {secretNumber}. It took you {guessCounter} guesses to guess correctly. \n");
//
//
// // 9. Write a program that prints the next 20 leap years.
// int currentYr = DateTime.Today.Year;
// int counterLeap = 0;
// Console.WriteLine("The next 20 leap years:");
// for (int i = currentYr; counterLeap < 20; i++)
// {
//     if (i % 4 == 0)
//     {
//         Console.Write($"{i} ");
//         counterLeap++;
//     }
// }