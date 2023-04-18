using System;
using System.Linq.Expressions;
using System.Runtime.Remoting.Lifetime;
using System.Text;
public class ToReceiveInput{

    public static string ReceiveInput(int cursorPositionX,int cursorPositionY)
    {
        StringBuilder stringBuilder = new StringBuilder();
        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
        Console.Write("                                       ");
        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
        while (true)
        {
            Console.TreatControlCAsInput = true; //control C로 강제종료 막기
            ConsoleKeyInfo inputKey = Console.ReadKey();

            if(inputKey.Key == ConsoleKey.Enter) //입력 완료
            {
                break;
            }
            else if (inputKey.Key == ConsoleKey.Backspace && stringBuilder.Length >0) //백스페이스 눌렀을때 처리
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
                Console.Write(" \b");
            }
            else if((inputKey.Modifiers == ConsoleModifiers.Control && inputKey.Key == ConsoleKey.C) 
                || (inputKey.Modifiers == ConsoleModifiers.Control && inputKey.Key == ConsoleKey.V) 
                || (inputKey.Modifiers == ConsoleModifiers.Control && inputKey.Key == ConsoleKey.Z)) //Control 조합키 막기
            {
                Console.Write("                                   ");
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("잘못된 입력입니다. 다시 입력하세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.Write("                                   ");
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            }
            else if (Char.IsLetterOrDigit(inputKey.KeyChar) 
                || Char.IsWhiteSpace(inputKey.KeyChar) 
                || Char.IsPunctuation(inputKey.KeyChar) 
                || Char.IsSymbol(inputKey.KeyChar))      //문자,숫자,기호,구두점 입력 받았을 시
            {
                stringBuilder.Append(inputKey.KeyChar);
            }
        }

        
        return stringBuilder.ToString();
    }


    public static string ReceiveInputForMasking(int cursorPositionX, int cursorPositionY)
    {
        StringBuilder stringBuilder = new StringBuilder();
        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
        Console.Write("                                       ");
        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
        while (true)
        {
            Console.TreatControlCAsInput = true; //control C로 강제종료 막기
            ConsoleKeyInfo inputKey = Console.ReadKey();

            if (inputKey.Key == ConsoleKey.Enter) //입력 완료
            {
                break;
            }
            else if (inputKey.Key == ConsoleKey.Backspace && stringBuilder.Length > 0) //백스페이스 눌렀을때 처리
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
                Console.Write(" \b");
            }
            else if ((inputKey.Modifiers == ConsoleModifiers.Control && inputKey.Key == ConsoleKey.C)
                || (inputKey.Modifiers == ConsoleModifiers.Control && inputKey.Key == ConsoleKey.V)
                || (inputKey.Modifiers == ConsoleModifiers.Control && inputKey.Key == ConsoleKey.Z)) //Control 조합키 막기
            {
                Console.Write("                                   ");
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("잘못된 입력입니다. 다시 입력하세요!");
                Console.ResetColor();
                Console.ReadKey(true);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.Write("                                   ");
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            }
            else if (Char.IsLetterOrDigit(inputKey.KeyChar)
                || Char.IsWhiteSpace(inputKey.KeyChar)
                || Char.IsPunctuation(inputKey.KeyChar)
                || Char.IsSymbol(inputKey.KeyChar))      //문자,숫자,기호,구두점 입력 받았을 시
            {
                Console.Write("\b \b");
                Console.Write("*");
                stringBuilder.Append(inputKey.KeyChar);
            }
        }


        return stringBuilder.ToString();
    }
}

