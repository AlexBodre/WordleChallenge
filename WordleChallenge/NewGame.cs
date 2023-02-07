using System;
namespace WordleChallenge
{
	public class NewGame
	{
		int attemps;
		string _word;
		public GuessedWord[] GuessedWords { get; private set; }

		public NewGame(string word)
		{
			_word = word;
			attemps = 0;
			GuessedWords = new GuessedWord[6];
		}

		public State Guess(string guessedWord)
		{
			attemps++;

			GuessedWords[attemps - 1] = new GuessedWord
			{
				Word = guessedWord,
				GuessedLetters = new GuessedLetter[5]
				{
					new GuessedLetter { Letter = guessedWord[0], IsWrongPlaceRightLetter = _word.Contains(guessedWord[0]), GuessCorrect = guessedWord[0] == _word[0] },
					new GuessedLetter { Letter = guessedWord[1], IsWrongPlaceRightLetter = _word.Contains(guessedWord[1]), GuessCorrect = guessedWord[1] == _word[1] },
					new GuessedLetter { Letter = guessedWord[2], IsWrongPlaceRightLetter = _word.Contains(guessedWord[2]), GuessCorrect = guessedWord[2] == _word[2] },
					new GuessedLetter { Letter = guessedWord[3], IsWrongPlaceRightLetter = _word.Contains(guessedWord[3]), GuessCorrect = guessedWord[3] == _word[3] },
					new GuessedLetter { Letter = guessedWord[4], IsWrongPlaceRightLetter = _word.Contains(guessedWord[4]), GuessCorrect = guessedWord[4] == _word[4] }
				}
			};

			if (guessedWord.ToLower() == _word)
				return State.Win;
			if (attemps >= 6)
				return State.Loss;


			return State.Playing;
			
			
		}



      
    }
}

