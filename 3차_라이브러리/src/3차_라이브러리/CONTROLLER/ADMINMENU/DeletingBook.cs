using System;
using System.Security.Policy;

public class DeletingBook
{
    string title;
    string author;
    string publisher;
    string deletedBookIdString;
    int deletedBookIdInt;
    int PrintPossiblity = 0;
    ConsoleKeyInfo inputKey;

    Data data;
    Ui ui;
    MagicNumber magicNumber;

    public DeletingBook(Data data, Ui ui, MagicNumber magicNumber)
    {
        this.data = data;
        this.ui = ui;
        this.magicNumber = magicNumber;
    }

    public void DeleteABook()
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

            ui.PrintDeletingBookMenu(); //삭제 메뉴 및 검색된 책 리스트 출력
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
            deletedBookIdString = Console.ReadLine();  //삭제할 책 아이디 입력
            deletedBookIdInt = int.Parse(deletedBookIdString);
            for (int i = 0; i < data.bookList.Count; i++)
            {
                if (data.bookList[i].bookId == deletedBookIdInt)
                {
                    data.bookList.RemoveAt(i);
                    break;
                }
            }
            Console.Clear();
            ui.PrintDeletingBookSuccessSentence();

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
