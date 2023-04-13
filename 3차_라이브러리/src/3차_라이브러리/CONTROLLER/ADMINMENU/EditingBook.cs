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
    

    public void EditBook(Data data, Ui ui)
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
        ui.PrintEditingBookInformation(data);

        Console.SetCursorPosition(40, 13);
        title = Console.ReadLine();



    }

}

