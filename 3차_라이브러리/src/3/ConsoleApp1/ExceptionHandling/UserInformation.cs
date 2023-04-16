using System;
using System.Net;
using System.Text.RegularExpressions;

public class UserInformation

{
    public string JudgeIdAndPasswordWithRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine ("                                            ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9]{8,15}$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("숫자 + 영어 8~15글자를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeUserNameWithRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                         ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"[ㄱ-ㅎ가-힣a-zA-Z]+";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("한글,영어포함 1글자 이상 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeUserAgeWithRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                                      ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^(0|[1-9]\d?|1\d{2}|200)$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0또는 1부터 200사이의 자연수를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeUserNumberWithRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                         ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"01{1}[016789]{1}-[0-9]{3,4}-[0-9]{4}";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("01x-xxxx-xxxx 형식으로 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }
}



// 로그 쌓이는거, 터지는거 수정, 엔터 무한 