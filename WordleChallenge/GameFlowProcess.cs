using System;
namespace WordleChallenge
{
    public class GameFlowProcess
    {
        private string[] wordsArray;
        private WordleUI wordleUI;

        public GameFlowProcess(string[] wordList)
        {
            wordsArray = wordList;
            wordleUI = new WordleUI();
        }

        public void Menu()
        {
            while (true)
            {
                GameProcess();
                wordleUI.ContinueScreen();

                var shouldContinue = Console.ReadKey();

                if (shouldContinue.KeyChar == 'q')
                    return;
            }
        }



        private void GameProcess()
        {
            var sort = new Random();
            var wordIndex = sort.Next(wordsArray.Length);
            var wordSelected = wordsArray[wordIndex];

            var game = new NewGame(wordSelected);

            while (true)
            {
                wordleUI.GameScreen(game.GuessedWords);

                var guessedWord = Console.ReadLine()?.ToLower();

                if (!IsValidGuess(guessedWord))
                {
                    continue;
                }

                var result = game.Guess(guessedWord);

                if (result == State.Playing)
                {
                    continue;
                }
                else if (result == State.Win)
                {
                    wordleUI.GameScreen(game.GuessedWords);
                    wordleUI.DisplayWonGame();
                    break;
                }
                else if (result == State.Loss)
                {
                    wordleUI.GameScreen(game.GuessedWords);
                    wordleUI.DisplayLostGame();
                    break;
                }

            }



        }
        private bool IsValidGuess(string? guess)
        {
            if (guess == null)
            {
                return false;
            }
            else if (guess.Length != 5)
            {
                return false;
            }

            return true;
        }

    }
}
