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
    bool isMenuExecute = true; //메뉴 탈출 진리형 변수
    bool isJudgingCorrectString; //입력값 검사 후 탈출을 위한 변수

    DataStorage dataStorage;
    CommonFunctionUi commonFunctionUi;
    ProgramProcess programProcess;
    BookInformationException bookInformationException;
    public BookFinder(DataStorage dataStorage, CommonFunctionUi commonFunctionUi, ProgramProcess programProcess, BookInformationException bookInformationException)
    {
        this.dataStorage = dataStorage;
        this.commonFunctionUi = commonFunctionUi;
        this.programProcess = programProcess;
        this.bookInformationException = bookInformationException;
    }

    public void FindBook()
    {
        while (isMenuExecute)
        {
            //책 리스트 출력
            commonFunctionUi.PrintBookFinderMenu();
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
            }

            //입력값 받기 (책 제목, 저자, 출판사)
            Console.SetCursorPosition(17, 1);
            do {
                title = ToReceiveInput.ReceiveInput(17, 1);
                isJudgingCorrectString = bookInformationException.JudgeBookNameRegularExpression(17, 1, title);
            } while(!isJudgingCorrectString);

            Console.SetCursorPosition(19, 2);
            do
            {
                author = ToReceiveInput.ReceiveInput(19, 2);
                isJudgingCorrectString = bookInformationException.JudgeBookAuthorRegularExpression(19, 2, author);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(17, 3);
            do
            {
                publisher = ToReceiveInput.ReceiveInput(17, 3);
                isJudgingCorrectString = bookInformationException.JudgeBookPublisherRegularExpression(17, 3, publisher);
            } while (!isJudgingCorrectString);
     
            Console.WriteLine("\n\n\n");
            Console.Clear();
            commonFunctionUi.PrintBookFinderMenu();

            //입력받은 책과 데이터의 책들 비교
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
            commonFunctionUi.SelectEndorReturnInTheProgram(); //다시하기 또는 나가기 출력

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                isMenuExecute = false;
            }

        }
    }
}
