using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPracticeSummer17
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop?
            //Why would you use a loop?
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue

            //For Loop
            //Can be used for both counting and...
            //ITERATING through an array (or other collection type)
            //Looks like this:
            //for(initializer; condition; updater)
            //{
            //      Do something
            //}

            //int i;
            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After the loop has run, i now has the value of " + i);

            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is Little Bill.";
            ////The .Split() method takes a string and turns it into an array of smaller
            ////strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print the words
            //for(int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //string[] weekDays = { "Monday", "Tuesday", "Wednesday" };
            //for(int i = 0; i < weekDays.Length; i++)
            //{
            //    Console.WriteLine(weekDays[i]);
            //}

            //string tale = "Once upon a time.";
            //string[] fairyTale = tale.Split();
            //Array.Reverse(fairyTale);
            //for(int i = 0; i < fairyTale.Length; i++)
            //{
            //    Console.WriteLine(fairyTale[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //int product = 1;
            //for(int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

            //Foreach loop - used to interate over a collection (ex. list or array)
            //You can think of a structure of a foreach loop as the statement:
            //For each item in the collection, do something

            //foreach(datatype variable in collection)
            //{
            //      do something
            //}

            //string[] calendar = { "Jan", "Dog", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword foreach
            //foreach(string month in calendar)
            //{
            //    Console.WriteLine(month);
            //}
            //foreach loops allow the temporary variable to "know" to assign
            //itself to each element in the collection (like an array), one at a time

            //Foreach loop will always go from beginning to end, no matter what
            //It counts the number of elements in the collection, and runs that many times

            //Create an array of 6 musicians (bands or solo artists)
            //Using a foreach loop, print each musician's name

            //string[] musicians = { "Rascal Flatts", "Jason Aldean", "Foreigner", "Whitesnake", "Matchbox 20", "Goo Goo Dolls" };
            //foreach(string artist in musicians)
            //{
            //    Console.WriteLine(artist);
            //}

            //While loop is used when you want a chunk of code to run only if a 
            //condition is met first.
            //While something is TRUE, do this thing.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while(firstName.ToUpper() == "JOE")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //a Do-While loop is similar to a while loop, however
            //The Do-While loop is used when you want a chunk of code to run
            //AT LEAST ONCE, but repeat only if the While condition is met

            //The structure of a Do-While loop looks like this:
            //do
            //{
            //      Do something
            //}
            //while(condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //let's pretend the code for the game is here
            //    Console.WriteLine("Great game!!");
            //    Console.WriteLine("Do you want to play again? YES/NO.");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            //Ask the user for the class (in school) that they would like to add to their
            //GPA calculation.
            //Ask the user for the letter grade for the class (no + or -)
            //Ask the user if they have another class they would like to add to their
            //GPA calculation.
            //Using a Do-While Loop, repeat the code if the user says "YES"







            //NESTED LOOPS
            //Loop inside of another loop
            //the inner loop is executed more times than the outer loop
            //REAL LIFE EXAMPLE - Clock

            //Create a nested loop structure that prints:
            // 1234
            // 1234

            //for(int rows = 1; rows <= 2; rows++)
            //{
            //    for(int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a triangle 
            //Outer loop will go line by line
            //The inner loop will go over different elements in the line.
            //Result:
            //1
            //1 2
            //1 2 3
            //1 2 3 4 ...



            //Console.WriteLine("How many rows do you want in your triangle?");

            //int n = int.Parse(Console.ReadLine());

            //for (int row = 1; row <= n; row++)

            //{

            //    for (int col = 1; col <= row; col++)

            //    {

            //        Console.Write(col + " ");

            //    }

            //    Console.WriteLine();  

            //}

            //int multNum = 1;
            //Console.WriteLine("Enter in your first number.");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter in your second number.");
            //int secondNumber = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= firstNumber; i++)
            //{
            //    for(int j = 1; j <= secondNumber; j++)
            //    {
            //        Console.Write(multNum * j + " ");
            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}


            //string[] faveMovies = { "Star Wars", "Anchorman", "Avatar", "Serenity", "Super Troopers" };
            //foreach(string movie in faveMovies)
            //{
            //    if (movie.StartsWith("A"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("E"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("I"))
            //    {
            //        continue;
            //    }
            //    if (movie.StartsWith("O"))
            //    {
            //        continue;
            //    }
            //    if (movie.StartsWith("U"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }
            //}









        }
    }
}
