using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1
{
    internal class allGuesses
    {
        public int currentGuess;
        public int guess;
        List<int> guesslist = new List<int>();
        
        public allGuesses() //Constructor
        {
            this.guess = guess;
        }
        public void makeGuessList(string guess) //Fills the guesslist but also catches if your currentGuess is not a int
        {
            while (true)
            {
                try //In case that user enters a string
                {
                    guesslist.Add(int.Parse(guess));
                    currentGuess = int.Parse(guess);
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a number as stated prior!");
                }
            }
        }
        public void seeGuessList() //Shows you the full list of your guesses to see what numbers you already guessed on
        {
            this.guesslist = guesslist;
            Console.WriteLine(string.Join(" ,", guesslist));
        }
    }

}
