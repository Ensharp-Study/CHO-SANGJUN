using System;
using System.Net;
using System.Text.RegularExpressions;

public class UserInformationException
{
    public bool JudgeIdWithRegularExpression(int cursorPositionX, int cursorPositionY, string inputString)
    {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string pattern = @"^[a-zA-Z0-9]{8,15}$";
            bool isMatch = Regex.IsMatch(inputString, pattern);

            if (isMatch == true)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("숫자 + 영어 8~15글자를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                return false;
            }
  
    }

    public bool JudgePasswordWithRegularExpression(int cursorPositionX, int cursorPositionY, string inputString)
    {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string pattern = @"^[a-zA-Z0-9]{8,15}$";
            bool isMatch = Regex.IsMatch(inputString, pattern);

            if (isMatch == true)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("숫자 + 영어 8~15글자를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                return false;
            }
    }

    public bool JudgeUserNameWithRegularExpression(int cursorPositionX, int cursorPositionY, string inputString)
    {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string pattern = @"[ㄱ-ㅎ가-힣a-zA-Z]+";
            bool isMatch = Regex.IsMatch(inputString, pattern);

            if (isMatch == true)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("한글,영어포함 1글자 이상 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                return false;
            }
    }

    public bool JudgeUserAgeWithRegularExpression(int cursorPositionX, int cursorPositionY, string inputString)
    {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string pattern = @"^(0|[1-9]\d?|1\d{2}|200)$";
            bool isMatch = Regex.IsMatch(inputString, pattern);

        if (isMatch == true)
        {
            return true;
        }
        else
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0또는 1부터 200사이의 자연수를 입력해 주세요!");
            Console.ResetColor();
            Console.ReadKey(true);
            return false;
        }
        
        

    }

    public bool JudgeUserNumberWithRegularExpression(int cursorPositionX, int cursorPositionY, string inputString)
    {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string pattern = @"01{1}[016789]{1}-[0-9]{3,4}-[0-9]{4}";
            bool isMatch = Regex.IsMatch(inputString, pattern);

            if (isMatch == true)
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("01x-xxxx-xxxx 형식으로 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                return false;
            }

    }
}
