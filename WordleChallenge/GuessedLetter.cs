namespace WordleChallenge
{
	public readonly record struct GuessedLetter(char Letter, bool IsWrongPlaceRightLetter, bool GuessCorrect);
}

