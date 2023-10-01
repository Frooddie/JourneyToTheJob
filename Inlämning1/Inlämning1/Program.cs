namespace Inlämning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a guessing game, I'm thinking of a number between 1-100, which number am I thinking of?");
            int answer = 48;
            int guess = int.Parse(Console.ReadLine());
            bool GameOver = false;
            List<int> guesslist = new List<int>();
            while (GameOver == false)
            {
                guesslist.Add(guess);
                if (guess < answer)
                {
                    Console.WriteLine("Your guess was: " + guess + " and that was lower than what I'm thinking of!");
                    Console.WriteLine("Would you like to: a. Guess again, b. Give up? or c. See all your previous guesses?");
                    string choice = Console.ReadLine();
                    if (choice == "a")
                    {
                        Console.WriteLine("Alright, please try again!");
                        guess = int.Parse(Console.ReadLine());
                        continue;
                    }
                    else if (choice == "c")
                    {
                        Console.WriteLine(string.Join(", ", guesslist));
                        Console.WriteLine("Going back to the latest guess!");
                        continue;
                    }
                    else 
                    {
                        Console.WriteLine("Better luck next time!");
                        GameOver = true;
                        break;
                    }
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Your guess was: " + guess + " and that was higher than what I'm thinking about!");
                    Console.WriteLine("Would you like to: a. Guess again, b. Give up? or c. See all your previous guesses?");
                    string choice = Console.ReadLine();
                    if (choice == "a")
                    {
                        Console.WriteLine("Alright, please try again!");
                        guess = int.Parse(Console.ReadLine());
                        continue;
                    }
                    else if (choice == "c")
                    {
                        Console.WriteLine(string.Join(", ", guesslist));
                        Console.WriteLine("Going back to the latest guess!");
                        continue;
                    }
                    else 
                    {
                        Console.WriteLine("Better luck next time!");
                        GameOver = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed " + guess + " and that is correct!");
                    Console.WriteLine("Game shutting down!");
                    GameOver = true;
                    break;
                }
            }
        }
    }
}