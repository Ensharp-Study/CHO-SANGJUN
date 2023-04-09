using System;
using System.Text.RegularExpressions;

public class Login
{
    Data data = new Data();
    UserMenu usermenu = new UserMenu();
    public void GetLogin(Ui ui,MagicNumber magicNumber)
    {
        string id;
        string password;
        string pattern;
        bool isJudgingCorrectInput = true;
        //정규표준식을 이용하여 id 및 패스워드 동일 한지 탐색

        while (isJudgingCorrectInput)
        {
            ui.PrintLoginMenu();
            Console.SetCursorPosition(53, 23);
            id = Console.ReadLine();
            pattern = id;
            Console.SetCursorPosition(61, 24);
            password = Console.ReadLine();

            for (int indexI = 0; indexI < data.userList.Count; indexI++)
            {
                if (Regex.IsMatch(data.userList[indexI].id, pattern))
                {
                    pattern = password;
                    for (int indexJ = 0; indexJ < data.userList.Count; indexJ++)
                    {
                        if (Regex.IsMatch(data.userList[indexJ].password, pattern))
                        {
                            usermenu.ControllUserMenu(ui, data, magicNumber);
                            isJudgingCorrectInput =false;
                        }
                        else
                        {
                            Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요        ");
                        }
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
