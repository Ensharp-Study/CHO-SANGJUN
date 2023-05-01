using ConsoleApp1.DataBase;
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

    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    CommonFunctionUi commonFunctionUi;
    
    ProgramProcess programProcess;
    BookDTO bookDTO;
    BookDAO bookDAO;

    public BookFinder(ProgramProcess programProcess, BookDTO bookDTO, BookDAO bookDAO)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();

        this.programProcess = programProcess;
        this.bookDTO = bookDTO;
        this.bookDAO = bookDAO;
        
    }

    public void FindBook()
    {
        while (isMenuExecute)
        {
            //책 리스트 출력
            commonFunctionUi.PrintBookFinderMenu();

            for (int i = 1; i <= bookDAO.ReadAllBookCount(); i++)
            {
                commonFunctionUi.PrintBookList(bookDAO.ReadAllBookData(i), i);
            }
            
            //입력값 받기 (책 제목, 저자, 출판사)
            Console.SetCursorPosition(17, 1);
            do { // 제목
                title = InputByReadKey.ReceiveInput(17, 1, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(17, 1, title, Constants.BOOK_NAME_REGULAR_EXPRESSION, Constants.BOOK_NAME_ERROR_MESSAGE);
            } while(!isJudgingCorrectString);

            Console.SetCursorPosition(19, 2);
            do // 작가
            {
                author = InputByReadKey.ReceiveInput(19, 2, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(19, 2, author, Constants.BOOK_AUTHOR_REGULAR_EXPRESSION, Constants.BOOK_AUTHOR_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(17, 3);
            do // 출판사
            {
                publisher = InputByReadKey.ReceiveInput(17, 3, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(17, 3, publisher, Constants.BOOK_PUBLISHER_REGULAR_EXPRESSION, Constants.BOOK_PUBLISHER_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);
     
            Console.WriteLine("\n\n\n");
            Console.Clear();
            commonFunctionUi.PrintBookFinderMenu();

            //입력받은 책과 데이터의 책들 비교
            for (int i = 1; i <= bookDAO.ReadAllBookCount(); i++)
            {
                if (string.IsNullOrEmpty(title) == false ||
                   string.IsNullOrEmpty(author) == false ||
                   string.IsNullOrEmpty(publisher) == false) // 입력받은 값이 공백인 경우 제외
                {
                    if ((bookDAO.ReadAllBookData(i).BookName).Contains(title) &&
                        (bookDAO.ReadAllBookData(i).BookAuthor).Contains(author) &&
                        (bookDAO.ReadAllBookData(i).BookPublisher).Contains(publisher)) 
                    {
                        printPossiblity++;
                    }
                }

                if (printPossiblity > 0) // 일치하면 출력
                {
                    commonFunctionUi.PrintBookList(bookDAO.ReadAllBookData(i), i);
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
