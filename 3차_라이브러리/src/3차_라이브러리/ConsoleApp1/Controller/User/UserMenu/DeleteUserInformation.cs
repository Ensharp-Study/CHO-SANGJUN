﻿using ConsoleApp1.DataBase;
using System;

public class DeletingUserInformation //inf와같이 줄임말 
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    UserModeUi userModeUi;

    ProgramProcess programProcess;
    UserDAO userDAO;


    public DeletingUserInformation(ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.userModeUi = UserModeUi.GetInstance();

        this.programProcess = programProcess;
        this.userDAO = new UserDAO();
    }

    public void DeleteUserInformation(UserDTO loggedInUserInformation)
    {
        while (true)
        {
            userModeUi.confirmAccountDeletion();
            ConsoleKeyInfo inputKey;


            bool isCheckedEnter = false;
            int selectedMenuNumber = -1;

            Console.SetCursorPosition(43, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("○ 예");
            Console.SetCursorPosition(60, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("○ 아니오");
            selectedMenuNumber = (int)(UserManagementNumber.DELETEING_USER);

            while (isCheckedEnter == false)
            {
                inputKey = Console.ReadKey();
                if (inputKey.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(43, 4);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("○ 예");
                    Console.SetCursorPosition(60, 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("○ 아니오");
                    selectedMenuNumber = (int)(UserManagementNumber.DELETEING_USER);
                }
                else if (inputKey.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(43, 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("○ 예");
                    Console.SetCursorPosition(60, 4);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("○ 아니오");
                    Console.ResetColor();
                    selectedMenuNumber = (int)(UserManagementNumber.SAVING_USER); 
                }
                else if (inputKey.Key == ConsoleKey.Enter)
                {
                    isCheckedEnter = true;
                }
            }

            if (selectedMenuNumber == (int)(UserManagementNumber.DELETEING_USER))
            {
                userDAO.DeleteUserInformation(loggedInUserInformation); // 유저정보 삭제
                Console.Clear();
                userModeUi.PrintAccountDeletionSentence();
            }
            else if (selectedMenuNumber == (int)(UserManagementNumber.SAVING_USER))
            {
                Console.Clear();
                userModeUi.PrintMaintainingAccountSentence();
            }

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}
