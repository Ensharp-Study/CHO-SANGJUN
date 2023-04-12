using System;

public class AddingBook
{
	public void AddNewBook(Data data, Ui ui, MagicNumber magicNumber)
	{
		
		ui.PrintAddingBookMenu();
        BookInf bookInf = new BookInf();

        Console.SetCursorPosition(29, 10);
		bookInf.bookName = Console.ReadLine();
        Console.SetCursorPosition(29, 11);
        bookInf.bookAuthor = Console.ReadLine();
        Console.SetCursorPosition(29, 12);
        bookInf.bookPublisher = Console.ReadLine();
        Console.SetCursorPosition(29, 13);
        bookInf.bookQuantity = int.Parse(Console.ReadLine());
        Console.SetCursorPosition(29, 14);
        bookInf.bookPrice = int.Parse(Console.ReadLine());
        Console.SetCursorPosition(29, 15);
        bookInf.bookPublicationDate = Console.ReadLine();
        Console.SetCursorPosition(29, 16);
        bookInf.isbn = Console.ReadLine();
        Console.SetCursorPosition(29, 17);
        bookInf.bookInf = Console.ReadLine();

    }
}
