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
						if (true)
						{

						}
					}
				}
			}
		}
	}
}

