using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

public class BookFinder
{
	string title;
	string author;
	string publisher;
    int PrintPossiblity = 0;

    public void FindBook(Data data, Ui ui, MagicNumber magicNumber)
	{
       
		
			ui.PrintBookFinderMenu();
			for (int i = 0; i < data.bookList.Count; i++)
			{
				ui.PrintBookList(data, i);
			}
			Console.SetCursorPosition(17, 1);
			title = Console.ReadLine();
			Console.SetCursorPosition(19, 2);
			author = Console.ReadLine();
			Console.SetCursorPosition(17, 3);
			publisher = Console.ReadLine();
			Console.WriteLine("\n\n\n");

			Console.Clear();
			ui.PrintBookFinderMenu();
        for (int i = 0; i < data.bookList.Count; i++)
        {

            if (string.IsNullOrEmpty(title) == false)
            {
                if ((data.bookList[i].bookName).Contains(title))
                {
                    PrintPossiblity++;
                }
            }

            if (string.IsNullOrEmpty(author) == false)
            {
                if ((data.bookList[i].bookAuthor).Contains(author))
                {
                    PrintPossiblity++;
                }
            }

            if (string.IsNullOrEmpty(publisher) == false)
            {
                if ((data.bookList[i].bookPublisher).Contains(publisher))
                {
                    PrintPossiblity++;
                }
            }
            if (PrintPossiblity > 0)
            {
                {
                    ui.PrintBookList(data, i);
                }
                PrintPossiblity = 0;
            }
        }

    }
}
