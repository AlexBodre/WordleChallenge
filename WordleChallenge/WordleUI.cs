using System;
using System.Text;

namespace WordleChallenge
{
	public class WordleUI
	{


		public void GameScreen(GuessedWord[] guessedWords)
		{
			Console.Clear();
			Console.WriteLine("Welcome to Alex's Wordle");


			foreach(GuessedWord guessedWord in guessedWords)
			{
				if (string.IsNullOrEmpty(guessedWord.Word))
				{
					Console.WriteLine("-----");
				}
				else
				{
					var line = new StringBuilder();
					foreach (var guessedLetter in guessedWord.GuessedLetters)
					{
						if (guessedLetter.GuessCorrect)
						{
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(guessedLetter.Letter);
                            Console.ResetColor();
                        }
						else if (guessedLetter.IsWrongPlaceRightLetter)
						{
                            
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.DarkYellow;

                            Console.Write(guessedLetter.Letter);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(guessedLetter.Letter);
                            Console.ResetColor();
                        }
					}
                    Console.Write("\r\n");
				}
			}
		}

        public void DisplayInvalidInput()
        {
            Console.WriteLine("Not a valid word.");
        }

        public void DisplayWonGame()
        {
            Console.WriteLine("You won!");
        }

        public void DisplayLostGame()
        {
            Console.WriteLine("You lost!");
        }

        public void ContinueScreen()
        {
            Console.WriteLine("Push any key to play again. Hit 'q' to quit.");
        }
    }
}

