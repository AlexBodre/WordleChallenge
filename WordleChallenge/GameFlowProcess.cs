using System;
namespace WordleChallenge
{
	public class GameFlowProcess
	{
		private string[] wordsArray = WordleChallenge.ListOfWords.list;
		public GameFlowProcess()
		{
		}


		

		private void GameProcess()
		{
			var sort = new Random();
			var wordIndex = sort.Next(wordsArray.Length);
			var wordSelected = wordsArray[wordIndex];


		}

	}
}

