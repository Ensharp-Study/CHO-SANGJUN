using System;
using System.Net;
using System.Text.RegularExpressions;

public class ExceptionHandling
{
    public string JudgeIdAndPasswordWithRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                         ");
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

    public string JudgeBookTitleWithRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                         ");
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
}



// 로그 쌓이는거, 터지는거 수정, 엔터 무한 