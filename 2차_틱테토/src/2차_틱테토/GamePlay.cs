using System;
using System.Security.Principal;

public partial class GamePlay
{
    string[,] room = new string [3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
    string[,] win_case = new string[8, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" }, { "1", "4", "7" }, { "2", "5", "8" }, { "3", "6", "9" }, { "1", "5", "9" }, { "3", "5", "7" } };
    
    public void PlayWithComputer() //컴퓨터 VS USER
    {
        int i, j, k,l,m;
        int[] user_choice = new int[5];
        int[] computer_choice = new int[4];
        string user_num;
        int cnt1 = 0;
        int cnt2 = 0;
        string judge = " ";
        int result;
        string win_user;
        int same_num_count=0;
        string not_same_index ="0";
        int findroom;
   

        while (true) {
            //사용자 입력
            user_num = Console.ReadLine(); //사용자 입력
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (user_num == room[i, j]) //사용자가 입력한 인덱스 찾아서 해당 배열에 저장
                    {
                        user_choice[cnt1] = int.Parse(room[i, j]); // 사용자가 입력한 칸의 숫자 정보 저장
                        room[i, j] = "O"; //사용자가 입력한 칸 O로 표기
                        cnt1++; //다음 인덱스로 표시하기 위해 1 증가
                        PrintBoard(); //보드판 출력
                        result = JudgeWinner("O"); 
                        if((result == 1))
                        {
                            win_user = "user";
                            break;
                        }
                        if(cnt1+cnt2 == 9)
                        {
                            win_user = "DRAW";
                            break;
                        }
                        if (cnt1 == 1)
                        {
                            judge = JudgeFirstComputerChoice(i, j);
                        }
                    }
                    
                }
            }
            //컴퓨터 입력
            if (cnt1 == 1)
            {
                if (judge == "corner")
                {
                    room[1, 1] = "X";
                    computer_choice[cnt2] = 5;
                    PrintBoard();
                    //Console.Clear();
                    cnt2++;
                    
                }
                else if (judge == "side")
                {
                    room[1, 1] = "X";
                    computer_choice[cnt2] = 5;
                    PrintBoard();
                    //Console.Clear();
                    cnt2++;

                }
                else
                {
                    room[0, 0] = "X";
                    computer_choice[cnt2] = 1;
                    PrintBoard();
                    //Console.Clear();
                    cnt2++;
                }
            }

            else
            {
                for(i=0; i<8; i++) //배열 열
                {
                    same_num_count = 0;
                    for (j=0; j<cnt1; j++) //사용자가 입력한 숫자 저장한 배열
                    {
                        for(k=0; k<3; k++) //배열 행
                        {
                            if (int.Parse(win_case[i,k]) == user_choice[j])
                            {
                                same_num_count++;
                            }
                            else
                            {
                                not_same_index = win_case[i, k];
                            }
                        }
                       
                    }
 
                    if (same_num_count == 2)
                    {
                        for (l = 0; l < 3; l++)
                        {
                            for (m = 0; m < 3; m++)
                            {
                                if (not_same_index == room[l,m])
                                {
                                    room[l, m] = "X";
                                    computer_choice[cnt2] = int.Parse (not_same_index);
                                    PrintBoard();
                                    cnt2++;
                                    result = JudgeWinner("O");
                                    if ((result == 1))
                                    {
                                        win_user = "user";
                                        break;
                                    }
                                    if (cnt1 + cnt2 == 9)
                                    {
                                        win_user = "DRAW";
                                        break;
                                    }
                                }
                            }
                        }

                    }
                }

                
            }


        }
    }
    public string JudgeFirstComputerChoice(int i, int j)
    {
        if( ( (i == 0)&&(j== 0) ) || ((i == 0) && (j == 2)) || ((i == 2) && (j == 0)) || ((i == 2) && (j == 2)))
        {
            return  "corner";
        }
        else if(((i == 0) && (j == 1)) || ((i == 1) && (j == 0)) || ((i == 2) && (j == 1)) || ((i == 1) && (j == 2)))
        {
            return "side";
        }
        else
        {
            return "center";
        }
    }
    public void PrintBoard()
    {
        int i;
        int j;
        for(i=0; i<3; i++)
        {
            for(j=0; j<3; j++)
            {
                Console.Write(room[i, j]);
                Console.Write(" "); 
            }
            Console.WriteLine();
        }
    }

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
