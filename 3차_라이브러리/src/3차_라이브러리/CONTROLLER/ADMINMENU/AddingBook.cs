using System;

public class AddingBook
{
	public void AddNewBook(Data data, Ui ui, MagicNumber magicNumber)
	{
        while (true)
        {
            ConsoleKeyInfo inputKey;
            ui.PrintAddingBookMenu();
            BookInf bookInf = new BookInf();

            Console.SetCursorPosition(29, 11);
            bookInf.bookName = Console.ReadLine();
            Console.SetCursorPosition(29, 12);
            bookInf.bookAuthor = Console.ReadLine();
            Console.SetCursorPosition(29, 13);
            bookInf.bookPublisher = Console.ReadLine();
            Console.SetCursorPosition(29, 14);
            bookInf.bookQuantity = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(29, 15);
            bookInf.bookPrice = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(29, 16);
            bookInf.bookPublicationDate = Console.ReadLine();
            Console.SetCursorPosition(29, 17);
            bookInf.isbn = Console.ReadLine();
            Console.SetCursorPosition(29, 18);
            bookInf.bookInf = Console.ReadLine();
            data.bookList.Add(bookInf);
            Console.Clear();

            ui.PrintAddingBookSuccessSentence();

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
            else if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                break;
            }

        }

    }
}
