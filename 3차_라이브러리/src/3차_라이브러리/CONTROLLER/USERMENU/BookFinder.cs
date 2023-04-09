using System;

public class BookFinder
{
	string title;
	string Author;
	string publisher;
	public void FindBook(Data data, Ui ui, MagicNumber magicNumber)
	{
		ui.PrintBookListMenu();
		ui.PrintBookList(data);
		Console.SetCursorPosition(17, 1);
		title = Console.ReadLine();
        Console.SetCursorPosition(19, 2);
        title = Console.ReadLine();
        Console.SetCursorPosition(17, 3);
        title = Console.ReadLine();

		//정규 표현식
    }
}
