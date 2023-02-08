// See https://aka.ms/new-console-template for more information

using WordleChallenge;


var list = AddNewWord.CaptureWord();


var gameFlowProcess = new GameFlowProcess(list);
gameFlowProcess.Menu();