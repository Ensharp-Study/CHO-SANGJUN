using System;
using System.Text.RegularExpressions;

public class UserLogin
{
    Ui ui;
    MagicNumber magicNumber;
    Data data;
    ExceptionHandling exceptionHandling;

    public UserLogin(Ui ui, MagicNumber magicNumber, Data data, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.magicNumber = magicNumber;
        this.data = data;
        this.exceptionHandling = exceptionHandling;
    }

    public void GetUserLogin()
    {
        string id;
        string password;
        bool isJudgingCorrectInput = true;

        while (isJudgingCorrectInput)
        {
            Console.Clear();
            ui.ViewMainMenu();
            ui.PrintLoginMenu();

            Console.SetCursorPosition(53, 23);
            id = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(53,23);
            
            Console.SetCursorPosition(61, 24);
            password = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(61, 24);

            for (int indexI = 0; indexI < data.userList.Count; indexI++)
            {
                if (string.Equals(id, data.userList[indexI].id))
                {
                    if (string.Equals(password, data.userList[indexI].password))
                    {
                        Console.Clear() ;
                        UserMenu usermenu = new UserMenu(ui, data, magicNumber,  data.userList[indexI],  exceptionHandling);
                        usermenu.ControllUserMenu();
                        isJudgingCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요        ");
                    }
                }

                else
                {
                    Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                }


            }
        }
    }
}
