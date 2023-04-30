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

    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;
    ProgramProcess programProcess;
    BookInformationException bookInformationException;


    public DeletingBook(DataStorage dataStorage, AdministratorModeUi administratorModeUi, CommonFunctionUi commonFunctionUi, ProgramProcess programProcess, BookInformationException bookInformationException)
    {
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
        this.commonFunctionUi = commonFunctionUi;
        this.programProcess = programProcess;
        this.bookInformationException = bookInformationException;
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
            commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
        }

        Console.SetCursorPosition(17, 1);  //검색할 책 정보 입력받기
        do
        {
            title = InputByReadKey.ReceiveInput(17, 1);
            isJudgingCorrectString = bookInformationException.JudgeBookNameRegularExpression(17, 1, title);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(19, 2);
        do
        {
            author = InputByReadKey.ReceiveInput(19, 2);
            isJudgingCorrectString = bookInformationException.JudgeBookAuthorRegularExpression(19, 2, author);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(17, 3);
        do
        {
            publisher = InputByReadKey.ReceiveInput(17, 3);
            isJudgingCorrectString = bookInformationException.JudgeBookPublisherRegularExpression(17, 3, publisher);
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
                {
                    commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                }
                PrintPossiblity = 0;
            }
        }
    }
}
