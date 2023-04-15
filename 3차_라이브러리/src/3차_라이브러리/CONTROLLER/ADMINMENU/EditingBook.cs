using System;
using System.Security.Policy;

public class EditingBook
{
    string title;
    string author;
    string publisher;
    string quantity;
    string price;
    string publishDate;

    int PrintPossiblity = 0;
    string EditedBookIdString;
    int EditedBookIdInt;
    ConsoleKeyInfo inputKey;

    Data data;
    Ui ui;

    public EditingBook(Data data, Ui ui) {

        this.data = data;
        this.ui = ui;
    }


    public void EditBook()
    {
        while (true)
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

            ui.PrintEditingBookAskingMenu(); //수정할 아이디 받는 창과 리스트 나열 출력
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

            Console.SetCursorPosition(64, 2);
            EditedBookIdString = Console.ReadLine();
            EditedBookIdInt = int.Parse(EditedBookIdString);
            Console.Clear();
            ui.PrintEditingBookMenu();
            for (int i = 0; i < data.bookList.Count; i++)
            {
                if (data.bookList[i].bookId == EditedBookIdInt)
                {
                    ui.PrintCurrentSavedBookInformation(data, i);
                    break;
                }
            }

            ui.PrintEditingBookInformation();

            Console.SetCursorPosition(63, 24);
            title = Console.ReadLine();
            Console.SetCursorPosition(63, 25);
            author = Console.ReadLine();
            Console.SetCursorPosition(63, 26);
            publisher = Console.ReadLine();
            Console.SetCursorPosition(63, 27);
            quantity = Console.ReadLine();
            Console.SetCursorPosition(63, 28);
            price = Console.ReadLine();
            Console.SetCursorPosition(63, 29);
            publishDate = Console.ReadLine();

            for (int i = 0; i < data.bookList.Count; i++)
            {
                if (data.bookList[i].bookId == EditedBookIdInt)
                {
                    data.bookList[i].bookName = title;
                    data.bookList[i].bookAuthor = author;
                    data.bookList[i].bookPublisher = publisher;
                    data.bookList[i].bookQuantity = int.Parse(quantity);
                    data.bookList[i].bookPrice = int.Parse(price);
                    data.bookList[i].bookPublicationDate = publishDate;
                    break;
                }
            }
            Console.Clear();
            ui.PrintEditingBookSuccessSentence();
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

