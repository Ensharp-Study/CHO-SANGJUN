using System;
using System.Runtime.InteropServices;

public partial class ScreenBoard
{
    public int user1_win_count;
    public int user2_win_count;

    public int PrintUserScreenBoard(int user1_score, int user2_score)
    {
        Ui ui = new Ui();
        ui.PrintUserScoreBoardUi(user1_score, user2_score);
        ui.DoItAgain();
        int do_or_not = int.Parse(Console.ReadLine());
        if (do_or_not == 1)
        {
            return 1;
        }
        else if (do_or_not == 2)
        {
            return 2;
        }
        else
        {
            return 3;
            //예외처리
        }
    }

    public int PrintComputerScreenBoard(int user1_score, int user2_score)
    {
        Ui ui = new Ui();
        ui.PrintComputerScoreBoardUi(user1_score, user2_score);
        ui.DoItAgain();
        int do_or_not = int.Parse(Console.ReadLine());
        if (do_or_not == 1)
        {
            return 1;
        }
        else if (do_or_not == 2)
        {
            return 2;
        }
        else
        {
            return 3;
            //예외처리
        }
    }
}