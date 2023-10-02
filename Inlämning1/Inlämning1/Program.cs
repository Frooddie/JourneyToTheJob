namespace Inlämning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a guessing game, I'm thinking of a number between 1-100, which number am I thinking of?");
            Random random = new Random(); //Creation of which random number the program is thinking of
            int answer = random.Next(1, 101);
            bool GameOver = false; //For not making game repeat itself indefinetly
            List<int> guesslist = new List<int>(); //To create a list of all the guesses you've made
            while (GameOver == false)
            {
                int guess = new int();
                while (true)
                {
                    try //In case that user enters a string
                    {
                        guess = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch 
                    {
                        Console.WriteLine("Please enter a number as stated prior!");
                    }
                }
                guesslist.Add(guess);
                if (guess < answer) //If your guess is lower than the answer
                {
                    Console.WriteLine("Your guess was: " + guess + " and that was lower than what I'm thinking of!");
                    Console.WriteLine("Would you like to: a. Guess again, b. Give up? or c. See all your previous guesses?");
                    string choice = Console.ReadLine();
                    if (choice == "a")
                    {
                        Console.WriteLine("Alright, please try again!");
                        continue;
                    }
                    else if (choice == "b")
                    {
                        Console.WriteLine(string.Join(", ", guesslist));
                        Console.WriteLine("Going back to the latest guess!");
                        continue;
                    }
                    else //Option "c"
                    {
                        Console.WriteLine("Better luck next time!");
                        GameOver = true;
                        break;
                    }
                }
                else if (guess > answer) //If your guess is higher than the answer
                {
                    Console.WriteLine("Your guess was: " + guess + " and that was higher than what I'm thinking about!");
                    Console.WriteLine("Would you like to: a. Guess again, b. Give up? or c. See all your previous guesses?");
                    string choice = Console.ReadLine();
                    if (choice == "a")
                    {
                        Console.WriteLine("Alright, please try again!");
                        continue;
                    }
                    else if (choice == "b")
                    {
                        Console.WriteLine(string.Join(", ", guesslist));
                        Console.WriteLine("Going back to the latest guess!");
                        continue;
                    }
                    else //Option "c"
                    {
                        Console.WriteLine("Better luck next time!");
                        GameOver = true;
                        break;
                    }
                }
                else //If your guess equals answer
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