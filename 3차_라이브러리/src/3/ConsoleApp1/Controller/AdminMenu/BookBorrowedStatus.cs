using System;

public class BookBorrowedStatus
{
    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;
    ProgramProcess programProcess;

    public BookBorrowedStatus(DataStorage dataStorage, AdministratorModeUi administratorModeUi, ProgramProcess programProcess)
    {
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
        this.programProcess = programProcess;
    }

    public void CheckBookBorrowedList() //빌린 책 출력하는 함수
    {
        while (true)
        {
            administratorModeUi.PrintBookBorrowedMenu(); //빌린 책 출력하는 함수 인터페이스 출력 

            for (int i = 0; i < dataStorage.userList.Count; i++) //모든 유저정보 for문으로 접근
            {
                administratorModeUi.PrintUserName(dataStorage.userList[i].userName); //유저 이름 출력 인터페이스
                for (int j = 0; j < dataStorage.userList[i].borrowBookList.Count; j++) //유저정보 내 빌린책 리스트 접근
                {
                    administratorModeUi.PrintUserBorrowedBookList(dataStorage.userList[i].borrowBookList[j]); //빌린책 리스트 출력
                }
            }

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }

        }
    }
}
    

