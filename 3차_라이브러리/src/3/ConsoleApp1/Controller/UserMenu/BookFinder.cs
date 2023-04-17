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
        while (true)
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
                        commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                    }
                    PrintPossiblity = 0;
                }
            }

            commonFunctionUi.SelectEndorReturnInTheProgram();

            //프로그램 뒤로 나가기
            if (programProcess.SelectProgramDirection() == Constants.RETURN)
            {
                break;
            }

        }
    }
}
