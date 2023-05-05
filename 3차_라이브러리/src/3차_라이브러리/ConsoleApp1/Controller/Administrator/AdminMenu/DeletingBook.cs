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

    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;

    ProgramProcess programProcess;


    public DeletingBook(ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();
 
        this.programProcess = programProcess;
    }

    bool isJudgingCorrectString;
    public void DeleteABook() //책 삭제하기
    {
        while (true)
        {
            //책 검색하기
            FindBook();

            //책 삭제하기
            Console.SetCursorPosition(64, 2);
            deletedBookIdString = Console.ReadLine();  //삭제할 책 아이디 입력
            deletedBookIdInt = int.Parse(deletedBookIdString); 
            for (int i = 0; i < dataStorage.bookList.Count; i++) //모든 책 접근
            {
                if (dataStorage.bookList[i].BookId == deletedBookIdInt)
                {
                    dataStorage.bookList.RemoveAt(i);
                    break;
                }
            }
            Console.Clear();
            administratorModeUi.PrintDeletingBookSuccessSentence();

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }

    public void FindBook()
    {
        //책 검색하기 기능
        commonFunctionUi.PrintBookFinderMenu(); //책 검색하는 인터페이스

        for (int i = 0; i < dataStorage.bookList.Count; i++) //모든책 리스트 접근
        {
            //commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
        }

        Console.SetCursorPosition(17, 1);  //검색할 책 정보 입력받기
        do
        {
            title = InputByReadKey.ReceiveInput(17, 1, 15, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(17, 1, title, Constants.BOOK_NAME_REGULAR_EXPRESSION, Constants.BOOK_NAME_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(19, 2); //작가
        do
        {
            author = InputByReadKey.ReceiveInput(19, 2, 15, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(19, 2, author, Constants.BOOK_AUTHOR_REGULAR_EXPRESSION, Constants.BOOK_AUTHOR_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(17, 3); //출판사
        do
        {
            publisher = InputByReadKey.ReceiveInput(17, 3, 15, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(17, 3, publisher, Constants.BOOK_PUBLISHER_REGULAR_EXPRESSION, Constants.BOOK_PUBLISHER_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.WriteLine("\n\n\n");

        Console.Clear();

        administratorModeUi.PrintDeletingBookMenu(); //삭제 메뉴 및 검색된 책 리스트 출력
        for (int i = 0; i < dataStorage.bookList.Count; i++)
        {

            if (string.IsNullOrEmpty(title) == false ||
                string.IsNullOrEmpty(author) == false ||
                string.IsNullOrEmpty(publisher) == false) // 입력받은 값이 공백인 경우 제외
            {
                if ((dataStorage.bookList[i].BookName).Contains(title) &&
                    (dataStorage.bookList[i].BookAuthor).Contains(author) &&
                    (dataStorage.bookList[i].BookPublisher).Contains(publisher)) //제목 일치하는지 확인
                {
                    PrintPossiblity++;
                }
            }

            if (PrintPossiblity > 0) // 일치하면 출력
            {
                //commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                PrintPossiblity = 0;
            }
        }
    }
}
