using ConsoleApp1.DataBase;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

public class BookFinder
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    CommonFunctionUi commonFunctionUi;
    
    ProgramProcess programProcess;
    BookDAO bookDAO;

    public BookFinder(ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();

        this.programProcess = programProcess;
        this.bookDAO = new BookDAO();
    }

    public void FindBook()
    {
        bool isJudgingCorrectString; //입력값 검사 후 탈출을 위한 변수
        bool isMenuExecute = true; //메뉴 탈출 진리형 변수
        string title="";
        string author="";
        string publisher="";
        bool isPrintPossiblity;

        List<BookDTO> allBookInformation;

        while (isMenuExecute)
        {
            //책 검색창 출력
            commonFunctionUi.PrintBookFinderMenu();

            //책 리스트 출력
            allBookInformation = bookDAO.ReadAllBookData();
            for (int i = 0; i < allBookInformation.Count; i++)
            {
                commonFunctionUi.PrintBookList(allBookInformation[i]);
            }


            //입력값 받기 (책 제목, 저자, 출판사)
            isJudgingCorrectString = false;
            Console.SetCursorPosition(17, 1);
            while (!isJudgingCorrectString)//제목
            { 
                title = InputByReadKey.ReceiveInput(17, 1, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(17, 1, title, Constants.BOOK_NAME_REGULAR_EXPRESSION, Constants.BOOK_NAME_ERROR_MESSAGE);
            }

            isJudgingCorrectString = false;
            Console.SetCursorPosition(19, 2);
            while (!isJudgingCorrectString) // 작가
            {
                author = InputByReadKey.ReceiveInput(19, 2, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(19, 2, author, Constants.BOOK_AUTHOR_REGULAR_EXPRESSION, Constants.BOOK_AUTHOR_ERROR_MESSAGE);
            } 

            isJudgingCorrectString = false;
            Console.SetCursorPosition(17, 3);
            while (!isJudgingCorrectString) // 출판사
            {
                publisher = InputByReadKey.ReceiveInput(17, 3, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(17, 3, publisher, Constants.BOOK_PUBLISHER_REGULAR_EXPRESSION, Constants.BOOK_PUBLISHER_ERROR_MESSAGE);
            } 
     
            //Console.WriteLine("\n\n\n");
            Console.Clear();
            commonFunctionUi.PrintBookFinderMenu();

            //입력받은 책과 데이터의 책들 비교
            isPrintPossiblity = false;
            for (int i = 0; i < allBookInformation.Count; i++)
            {
                if ((allBookInformation[i].BookName).Contains(title) && (allBookInformation[i].BookAuthor).Contains(author) && (allBookInformation[i].BookPublisher).Contains(publisher))
                {
                    isPrintPossiblity = true;
                }

                if (isPrintPossiblity) // 일치하면 출력
                {
                    commonFunctionUi.PrintBookList(allBookInformation[i]);
                    isPrintPossiblity = false;
                }
            }
            commonFunctionUi.SelectEndorReturnInTheProgram(); //다시하기 또는 나가기 출력

            //프로그램 뒤로 나가기 //공통함수
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                isMenuExecute = false;
            }

        }
    }
}
