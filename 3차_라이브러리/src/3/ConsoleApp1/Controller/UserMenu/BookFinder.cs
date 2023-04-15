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
    ConsoleKeyInfo inputKey;

    DataStorage dataStorage;
    Ui ui;

    public BookFinder(DataStorage dataStorage, Ui ui)
    {
        this.ui = ui;
        this.dataStorage = dataStorage;
    }

    public void FindBook()
    {
        while (true)
        {
            ui.PrintBookFinderMenu();
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                ui.PrintBookList(dataStorage, i);
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
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (string.IsNullOrEmpty(title) == false ||
                   string.IsNullOrEmpty(author) == false ||
                   string.IsNullOrEmpty(publisher) == false) // 입력받은 값이 공백인 경우 제외
                {
                    if ((dataStorage.bookList[i].bookName).Contains(title) &&
                        (dataStorage.bookList[i].bookAuthor).Contains(author) &&
                        (dataStorage.bookList[i].bookPublisher).Contains(publisher)) //제목 일치하는지 확인
                    {
                        PrintPossiblity++;
                    }
                }

                if (PrintPossiblity > 0) // 일치하면 출력
                {
                    {
                        ui.PrintBookList(dataStorage, i);
                    }
                    PrintPossiblity = 0;
                }
            }

            ui.SelectEndorReturnInTheProgram();

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                return;
            }

            else if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }
    }
}
