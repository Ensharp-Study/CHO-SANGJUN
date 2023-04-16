using System;
using System.Text.RegularExpressions;

public class BookInformationException
{
    public string JudgeBookNameRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                                                    ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^[A-Za-z가-힣0-9?!+=]{1,15}$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("한영문자 또는 숫자 또는 ?!+= 1개 이상 15개 이하로 작성 하세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeBookAuthorRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY); 
            Console.WriteLine("                                                    ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^[A-Za-z가-힣]{1,15}$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("한영문자 1개 이상 15개 이하로 작성 하세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeBookPublisherRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                                              ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^[A-Za-z가-힣0-9]{1,15}$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("한영문자 또는 숫자 1개 이상 15개 이하로 작성 하세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeBookQuantityRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                                    ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^[0-9]{1,3}$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0~999 사이의 정수를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeBookPriceRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                               ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^[1-9]\d{0,6}$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1~9999999 사이의 정수를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeBookPublishDateRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                                       ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^(19\d{2}|20\d{2})-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("19xx or 20xx-xx-xx 를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeBookIsbnRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                                                     ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^(\d{3}-\d{2}-\d{6}-\d-\d)$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("국제 표준 ISBN 형식 xxx-xx-xxxxxx-x-x 를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }

    public string JudgeBookInformationRegularExpression(int cursorPositionX, int cursorPositionY)
    {
        while (true)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine("                                                      ");
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            string input = Console.ReadLine();
            string pattern = @"^[A-Za-z가-힣]+$";
            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch == true)
            {
                return input;
            }
            else
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("최소 1개의 문자를 입력해 주세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                continue;
            }
        }

    }
}
