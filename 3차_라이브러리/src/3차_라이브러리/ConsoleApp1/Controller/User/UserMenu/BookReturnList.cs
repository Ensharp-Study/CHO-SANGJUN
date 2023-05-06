﻿using System;
using System.Collections.Generic;
using ConsoleApp1.Model;

public class BookReturnList
{
    UserModeUi userModeUi;
    BookDAO bookDAO;

    public BookReturnList()
    {
        this.userModeUi = UserModeUi.GetInstance();
        this.bookDAO = new BookDAO();
    }

    public void ShowBookReturnList(UserDTO loggedInUserInformation) // 함수 명 변경
    {
        bool isMenuExecute = true; //메뉴 탈출 진리형 변수
        List<BookDTO> returnedBookInformation;

        while (isMenuExecute)
        {
            userModeUi.PrintReturningMenuList();
            returnedBookInformation = bookDAO.ReadReturnedBookList(loggedInUserInformation);

            for (int i = 0; i < returnedBookInformation.Count; i++)
            {
                userModeUi.PrintUserReturningList(returnedBookInformation[i]);
            }

        }
    }
}
