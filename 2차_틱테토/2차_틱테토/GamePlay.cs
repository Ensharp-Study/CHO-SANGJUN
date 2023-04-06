using System;

public partial class GamePlay
{
    string[,] room = new string [3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

    /*public void PlayWithComputer()
    {
        int i;
        char user_num;
             
        
        while (true)
        {
            user_num= Convert.ToChar(Console.ReadLine()); 
            if (user_num == 5) { 
            
            }
            else
            {

            }
        }
	}*/
    public int JudgeWinner(string OorX)
    {
        if ((room[0,0] == OorX) && (room[1,0] == OorX) && (room[2,0] == OorX))
        {
            return 1;
        }
        else if((room[0, 1] == OorX) && (room[1, 1] == OorX) && (room[2, 1] == OorX))
        {
            return 1;
        }
        else if ((room[0, 2] == OorX) && (room[1, 2] == OorX) && (room[2, 2] == OorX))
        {
            return 1;
        }
        else if ((room[0, 0] == OorX) && (room[0, 1] == OorX) && (room[0, 2] == OorX))
        {
            return 1;
        }
        else if ((room[1, 0] == OorX) && (room[1, 1] == OorX) && (room[1, 2] == OorX))
        {
            return 1;
        }
        else if ((room[2, 0] == OorX) && (room[2, 1] == OorX) && (room[2, 2] == OorX))
        {
            return 1;
        }
        else if ((room[0, 0] == OorX) && (room[1, 1] == OorX) && (room[2, 2] == OorX))
        {
            return 1;
        }
        else if ((room[0, 2] == OorX) && (room[1, 1] == OorX) && (room[2, 0] == OorX))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public void PlayWithUser(int a, int b)
    {
        
        string user1_num="0";
        string user2_num="0";
        string win_user ="NONE";

        int result1=0, result2=0;   
        int i, j;
        int cnt=0;

        while (true)
        {
            user1_num = Console.ReadLine();    //user 1
            
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (room[i, j] == user1_num)
                    {
                        room[i, j] = "O";
                        cnt++;
                    }

                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(room[i, j]);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

            result1 = JudgeWinner("O");
            if (result1 == 1)
            {
                win_user = "user1";
                break;
            }
            if (cnt == 9) break;


            user2_num = Console.ReadLine(); //user 2
            
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (room[i, j] == user2_num)
                    {
                        room[i, j] = "X";
                        cnt++;
                    }

                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(room[i, j]);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }

            result2 = JudgeWinner("X");
            if (result2 == 1)
            {
                win_user = "user2";
                break;
            }

            if (cnt == 9) break;
        }

        if(win_user == "NONE")
        {
            if( cnt == 9)
            {
                win_user = "DRAW";
            }
            else
            {
                //예외처리
            }
        }
        
        //Console.WriteLine(win_user);

        ScreenBoard screenBoard = new ScreenBoard();
        int DoOrNOt = screenBoard.PrintScreenBoard(result1+a, result2+b);
        if(DoOrNOt == 1)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.PlayWithUser(result1 + a, result2 + b);
        }
    }
}
