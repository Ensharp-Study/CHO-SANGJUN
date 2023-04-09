using System;
using System.Text.RegularExpressions;

public class BookFinder
{
	string title;
	string Author;
	string publisher;
	public void FindBook(Data data, Ui ui, MagicNumber magicNumber)
	{
		ui.PrintBookListMenu();
		for (int i = 0; i < data.bookList.Count; i++)
		{
			ui.PrintBookList(data, i);
		}
		Console.SetCursorPosition(17, 1);
		title = Console.ReadLine();
        Console.SetCursorPosition(19, 2);
        Author = Console.ReadLine();
        Console.SetCursorPosition(17, 3);
        publisher = Console.ReadLine();

		Console.WriteLine("\n\n\n");
        for (int i = 0; i < data.bookList.Count; i++)
		{
			if((data.bookList[i].bookName.Contains(title)) || (data.bookList[i].bookAuthor.Contains(Author)) || (data.bookList[i].bookPublisher.Contains(publisher)))
			{ 
                ui.PrintBookList(data, i);
			}
		}
    }
}
