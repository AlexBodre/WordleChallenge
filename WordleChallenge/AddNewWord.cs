using System;
namespace WordleChallenge
{
	public class AddNewWord
	{

		public static string[] CaptureWord()
		{
            Console.WriteLine("Add a new word of 5 letters");

            var list = WordleChallenge.ListOfWords.list;
            var newElement = Console.ReadLine();
            List<string> elements = new List<string>(list.ToList());
			if(!string.IsNullOrEmpty(newElement))
            elements.Add(newElement);


            list = elements.ToArray();
			return list;
        }

		public AddNewWord()
		{
		}
	}
}

