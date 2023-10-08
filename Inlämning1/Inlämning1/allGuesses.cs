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
        List<int> guesslist = new List<int>();
        
        public allGuesses() //Constructor
        {

        }
        public void UpdateList(int guess) //Fills the guesslist and stores your currentGuess
        {
            guesslist.Add(guess);
            currentGuess = guess;
        }
        public void ShowList() //Shows you the full list of your guesses to see what numbers you already guessed on
        {
            this.guesslist = guesslist;
            Console.WriteLine(string.Join(" ,", guesslist));
        }
    }

}
