// See https://aka.ms/new-console-template for more information

using WordleChallenge;

Console.WriteLine("Hello, World!");

var gameFlowProcess = new GameFlowProcess(WordleChallenge.ListOfWords.list);
gameFlowProcess.Menu();