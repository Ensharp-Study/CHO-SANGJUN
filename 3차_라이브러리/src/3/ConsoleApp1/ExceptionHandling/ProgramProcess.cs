using System;
public class ProgramProcess
{
    public int SelectProgramDirection() //다시 메인메뉴나 로그인 창을 돌아가게 해주는 함수
    {
        ConsoleKeyInfo inputKey;

        inputKey = Console.ReadKey();

        if (inputKey.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            return Constants.CONTINUE;
        }

        else if (inputKey.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            return Constants.RETURN;
        }

        else return -1;
    }


}
