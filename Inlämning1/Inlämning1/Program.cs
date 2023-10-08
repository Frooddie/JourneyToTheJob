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
            allGuesses guessing = new allGuesses(); //Initiates the object
            while (GameOver == false)
            {
                try
                {
                    int guess = int.Parse(Console.ReadLine());
                    guessing.UpdateList(guess); //Calling and starting your guesslist

                    if (guessing.currentGuess < answer) //If your guess is lower than the answer
                    {
                        Console.WriteLine("Your guess was: " + guessing.currentGuess + " and that was lower than what I'm thinking of!");
                    }
                    else if (guessing.currentGuess > answer) //If your guess is higher than the answer
                    {
                        Console.WriteLine("Your guess was: " + guessing.currentGuess + " and that was higher than what I'm thinking about!");
                    }
                    else //If your guess equals answer
                    {
                        Console.WriteLine("Congratulations! You guessed " + guessing.currentGuess + " and that is correct!");
                        Console.WriteLine("Game shutting down!");
                        GameOver = true;
                        break;
                    }

                    bool choices = false;
                    while (choices == false) //In case the user enters a different input than "a", "b" or "c"
                    {
                        Console.WriteLine("Would you like to: [a]. Guess again, [b]. See all your previous guesses? or [c]. Give up?"); //If your guess is not correct there are choices to proceed
                        string choice = Console.ReadLine();

                        if (choice == "a")
                        {
                            Console.WriteLine("Alright, please try again!");
                            choices = true;
                        }
                        else if (choice == "b")
                        {
                            guessing.ShowList(); //Writes out your guesslist
                            Console.WriteLine("Now please try again!");
                            choices = true;
                        }
                        else if (choice == "c")
                        {
                            Console.WriteLine("Better luck next time!");
                            choices = true;
                            GameOver = true;
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Not a valid choice!");
                            continue;
                        }
                    }
                }

                catch (Exception e) 
                {
                    Console.WriteLine("Please enter a number as stated prior!");
                }
            }
        }
    }
}