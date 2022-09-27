// Add data validation

using f_basic_coding;

Startup.Run();

// 
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
