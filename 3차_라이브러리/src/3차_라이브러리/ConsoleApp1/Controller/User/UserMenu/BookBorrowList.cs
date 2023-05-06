﻿using System;
using System.Collections.Generic;
using ConsoleApp1.Model;

public class BookBorrowList
{
    UserModeUi userModeUi;
    BookDAO bookDAO;
    public BookBorrowList()
    {
        this.userModeUi = UserModeUi.GetInstance();
        this.bookDAO = new BookDAO();
    }

    public void ShowBookBorrowList(UserDTO loggedInUserInformation)
	{
        bool isMenuExecute = true; //메뉴 탈출 진리형 변수
        List<BookDTO> borrowedBookInformation;

        while (isMenuExecute)
		{
			userModeUi.PrintBorrowingList();
            borrowedBookInformation = bookDAO.ReadBorrowedBookList(loggedInUserInformation);

            for (int i = 0; i < borrowedBookInformation.Count; i++)
			{
				userModeUi.PrintUserBorrowingList(borrowedBookInformation[i]);
			}

        }

    }
}
