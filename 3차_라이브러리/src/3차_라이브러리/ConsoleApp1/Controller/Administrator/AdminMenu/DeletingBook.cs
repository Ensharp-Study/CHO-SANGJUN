using System;
using System.Security.Policy;
using System.Collections.Generic;
using ConsoleApp1.Model;
using System.Net;
using System.Threading;

public class DeletingBook
{
    string title;
    string author;
    string publisher;
    string deletedBookId;
    int PrintPossiblity = 0;

    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;

    ProgramProcess programProcess;
    BookFinder bookFinder;
    BookDAO bookDAO;


    public DeletingBook(ProgramProcess programProcess, BookFinder bookFinder)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();
 
        this.programProcess = programProcess;
        this.bookFinder = bookFinder;
        this.bookDAO = new BookDAO();
    }

    public void DeleteABook() //책 삭제하기
    {
        List<BookDTO> selectedBookInformation;
        bool isJudgingCorrectString;
        bool isBookExistInList;

        while (true)
        {
            //책 검색하기
            bookFinder.PrintBookFinderMenu(); // 메뉴 검색 창 및 책 리스트 출력
            bookFinder.InputBookSearchData(); //책 검색 입력하기
            Console.Clear();

            administratorModeUi.PrintDeletingBookMenu(); // 삭제 메뉴 출력
            selectedBookInformation = bookFinder.CompareAndPrintBookList(); // 검색 정보와 책 정보 비교 후 출력, 출력된 책 리스트 저장

            //책 삭제하기

            //삭제할 책 아이디 입력
            Console.SetCursorPosition(64, 2);
            isJudgingCorrectString = false;
            while (!isJudgingCorrectString) 
            {
                deletedBookId = InputByReadKey.ReceiveInput(64, 2, 3, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(64, 2, deletedBookId, Constants.NUMBER_REGULAR_EXPRESSION, Constants.NUMBER_ERROR_MESSAGE);
            }

            //1. 검색 결과 리스트에 있는지 확인
            isBookExistInList = false;
            for (int i=0; i< selectedBookInformation.Count; i++) 
            { 
                if(int.Parse (deletedBookId) == selectedBookInformation[i].BookId) //있다면 삭제
                {
                    isBookExistInList = true;
                    break;
                }
            }

            if(isBookExistInList) 
            {
                int bookCountInBorrowedList= bookDAO.FindBookInBorrowedList(deletedBookId); // 2. 해당 책이 이미 대여중일 경우
                if (bookCountInBorrowedList != 0) //대여 중일 경우
                {
                    Console.Clear();
                    administratorModeUi.PrintDeletingBookFailAlreadyBorrowedSentence();
                }
                else // 대여 목록에 없을 경우
                {
                    bookDAO.DeleteBook(deletedBookId);//책 삭제

                    Console.Clear();
                    administratorModeUi.PrintDeletingBookSuccessSentence();  //삭제 성공 메시지 출력
                }
            }
            else // 검색된 리스트에 존재 하지않을때
            {
                Console.Clear();
                administratorModeUi.PrintDeletingBookFailNotExistInListSentence();
            }
          
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}
