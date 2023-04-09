using System;
using System.Text.RegularExpressions;

public class Login
{
    Data data = new Data();
    UserMenu usermenu = new UserMenu();
    public void GetLogin(Ui ui)
    {
        string id;
        string password;
        string pattern;
        

        ui.PrintLoginMenu();
        Console.SetCursorPosition(53, 23);
        id = Console.ReadLine();
        Console.SetCursorPosition(61, 24);
        password = Console.ReadLine();

        //정규표준식을 이용하여 id 및 패스워드 동일 한지 탐색
        pattern = id;
        
        for(int indexI=0; indexI<data.userList.Count; indexI++ )
        {
            if (Regex.IsMatch(data.userList[indexI].id, pattern))
            {
                pattern = password;
                for (int indexJ = 0; indexJ < data.userList.Count; indexJ++)
                {
                    if (Regex.IsMatch(data.userList[indexJ].password, pattern))
                    {
                        usermenu.ControllUserMenu(ui, data);
                    }
                    else
                    {
                        Console.WriteLine("비밀번호 입력이 틀렸습니다.");
                    }
                }
            }
            
        }
        //회원정보가 없습니다 처리

    }
}
