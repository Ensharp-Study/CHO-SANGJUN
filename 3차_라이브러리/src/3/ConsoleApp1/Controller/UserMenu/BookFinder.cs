using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

public class BookFinder
{
	string title;
	string author;
	string publisher;
    int printPossiblity = 0;
    bool isMenuExecute = true;


    DataStorage dataStorage;
    CommonFunctionUi commonFunctionUi;
    ProgramProcess programProcess;

    public BookFinder(DataStorage dataStorage, CommonFunctionUi commonFunctionUi, ProgramProcess programProcess)
    {
        this.dataStorage = dataStorage;
        this.commonFunctionUi = commonFunctionUi;
        this.programProcess = programProcess;
    }

    public void FindBook()
    {
        while (isMenuExecute)
        {
            commonFunctionUi.PrintBookFinderMenu();
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
            }
            Console.SetCursorPosition(17, 1);
            title = Console.ReadLine();
            Console.SetCursorPosition(19, 2);
            author = Console.ReadLine();
            Console.SetCursorPosition(17, 3);
            publisher = Console.ReadLine();
            Console.WriteLine("\n\n\n");
            Console.Clear();

            commonFunctionUi.PrintBookFinderMenu();
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (string.IsNullOrEmpty(title) == false ||
                   string.IsNullOrEmpty(author) == false ||
                   string.IsNullOrEmpty(publisher) == false) // 입력받은 값이 공백인 경우 제외
                {
                    if ((dataStorage.bookList[i].BookName).Contains(title) &&
                        (dataStorage.bookList[i].BookAuthor).Contains(author) &&
                        (dataStorage.bookList[i].BookPublisher).Contains(publisher)) 
                    {
                        printPossiblity++;
                    }
                }

                if (printPossiblity > 0) // 일치하면 출력
                {
                    {
                        commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                    }
                    printPossiblity = 0;
                }
            }
            commonFunctionUi.SelectEndorReturnInTheProgram();

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                isMenuExecute = false;
            }

        }
    }
}
