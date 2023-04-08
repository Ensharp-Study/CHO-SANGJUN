using System;
using System.Security.Principal;

public partial class GamePlay
{
    int result1 = 0, result2 = 0;
    string[,] room = new string [3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } }; //보드판 배열로 정의
    string[,] win_case = new string[8, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" }, { "1", "4", "7" }, { "2", "5", "8" }, { "3", "6", "9" }, { "1", "5", "9" }, { "3", "5", "7" } };
    //이기는 케이스 배열로 정리

    Ui ui = new Ui();
    ExceptionHandling exceptionHandling = new ExceptionHandling();
    ExitConfirmation exitConfirmation = new ExitConfirmation(); 

    public int PlayWithComputer(int return_result1, int return_result2) //컴퓨터 VS USER
    {
        int i, j, k,l,m;
        int[] user_choice = new int[5];
        int[] computer_choice = new int[4];
        string user_num;
        int cnt1 = 0;
        int cnt2 = 0;
        string judge = " ";
        int result = 0;
        string win_user;
        int same_num_count=0;
        string not_same_index ="0";
        int result1 = 0, result2 = 0;
        int exitConfirmationNumber;

        int CHOOSINGMENUAGAIN = 0; //메뉴 다시 선택할때
        int ENDINGGAME = 1; //게임 종료할때
        int CHOOSINGERROR = 2; // 종료하기 버튼 잘못 눌렀을때


        while (true) { //사용자 선공, 컴퓨터 후공
                       //사용자 입력
            ui.PrintGameBoard(room); //보드판 출력
            ui.PrintExitConfirmation();

            Console.Write("                                        ▶ [USER]의 번호를 입력하세요:  ");
            user_num = Console.ReadLine();
            exceptionHandling.PutNumberWrong_Fix(user_num);
            exitConfirmationNumber= exitConfirmation.JudgeExitCode(user_num);
            if(exitConfirmationNumber==0)
            {
                return CHOOSINGMENUAGAIN;
            }
            else if(exitConfirmationNumber==1) 
            {
                return ENDINGGAME;
            }
            else if (exitConfirmationNumber == 2)
            {
                ui.PrintGameBoard(room); //보드판 출력
                ui.PrintExitConfirmation();
                Console.Write("                                        ▶ [USER]의 번호를 입력하세요:  ");
                user_num = Console.ReadLine();
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (user_num == room[i, j]) //사용자가 입력한 인덱스 찾아서 해당 배열에 저장
                    {
                        user_choice[cnt1] = int.Parse(room[i, j]); // 사용자가 입력한 칸의 숫자 정보 저장
                        room[i, j] = "O"; //사용자가 입력한 칸 O로 표기
                        cnt1++; //다음 인덱스로 표시하기 위해 1 증가
                        
                        Console.Clear();
                        ui.PrintGameBoard(room); //보드판 출력
                        
                        //밑의 내용은 프로그램 종료 조건이다. (이기거나, 비기거나 -> 9칸이 다 찼을때)
                        result = JudgeWinner("O"); 
                        
                        if((result == 1)) //중간에 이겼을 때
                        {
                            win_user = "user";
                            break;
                        }
                        if(cnt1+cnt2 == 9) //비겼을때
                        {
                            win_user = "DRAW";
                            break;
                        }
                        //여기까지

                        if (cnt1 == 1) //처음 사용자가 입력하고 다음 컴퓨터가 어디를 차지해야 필승할지 정리한 메소드 호출 
                        {
                            judge = JudgeFirstComputerChoice(i, j);
                        }
                    }
                    
                }
                //밑의 내용은 프로그램 종료 조건이다. (이기거나, 비기거나 -> 9칸이 다 찼을때)
                result = JudgeWinner("O");

                if ((result == 1)) //중간에 이겼을 때
                {
                    win_user = "user";
                    break;
                }
                if (cnt1 + cnt2 == 9) //비겼을때
                {
                    win_user = "DRAW";
                    break;
                }
                //여기까지
            }

            //밑의 내용은 프로그램 종료 조건이다. (이기거나, 비기거나 -> 9칸이 다 찼을때)
            result = JudgeWinner("O");

            if (result == 1) //중간에 이겼을 때
            {
                win_user = "user";
                break;
            }

            if ((cnt1 + cnt2) == 9) //비겼을때
            {
                win_user = "DRAW";
                break;
            }
            //여기까지
            
            Console.WriteLine();

            //컴퓨터 입력
            if (cnt1 == 1) //사용자가 먼저 입력하고 컴퓨터가 "처음" 입력할때
            {
                if (judge == "corner") //사용자가 처음에 모서리를 선택한 경우
                {
                    room[1, 1] = "X"; //중앙을 컴퓨터는 골라야 한다.
                    computer_choice[cnt2] = 5; //중앙의 칸 값은 "5" 이므로 컴퓨터가 고른 숫자 배열에 5를 저장
                    ui.PrintGameBoard(room); //보드판 출력
                    cnt2++; //다음 원소 접근을 위해 1증가
                    
                }
                else if (judge == "side") //사용자가 처음에 사이드를 선택한 경우
                {
                    room[1, 1] = "X"; //컴퓨터는 중앙을 골라야 한다.
                    computer_choice[cnt2] = 5; //중앙의 칸 값은 "5" 이므로 컴퓨터가 고른 숫자 배열에 5를 저장
                    ui.PrintGameBoard(room); //보드판 출력
                    cnt2++; //다음 원소 접근을 위해 1증가

                }
                else//중앙을 골랐을 경우
                {
                    room[0, 0] = "X"; //모서리를 고르면 되므로 임의의 모서리 (0,0)을 선택
                    computer_choice[cnt2] = 1; //모서리 칸 값 "1" 저장
                    ui.PrintGameBoard(room); //보드판 출력
                    cnt2++; // 다음 원소 접근을 위해 1 증가
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
                                    ui.PrintGameBoard(room); //보드판 출력
                                    cnt2++;
                                    //밑은 종료조건 이다.
                                    result = JudgeWinner("X");
                                    if ((result == 1))
                                    {
                                        win_user = "computer";
                                        break;
                                    }
                                    if (cnt1 + cnt2 == 9)
                                    {
                                        win_user = "DRAW";
                                        break;
                                    }
                                    //여기까지
                                }
                            }
                            //밑은 종료조건 이다.
                            result = JudgeWinner("X");
                            if ((result == 1))
                            {
                                win_user = "computer";
                                break;
                            }
                            if (cnt1 + cnt2 == 9)
                            {
                                win_user = "DRAW";
                                break;
                            }
                            //여기까지
                        }

                    }
                    //밑은 종료조건 이다.
                    result = JudgeWinner("X");
                    if ((result == 1))
                    {
                        win_user = "computer";
                        break;
                    }
                    if (cnt1 + cnt2 == 9)
                    {
                        win_user = "DRAW";
                        break;
                    }
                    //여기까지
                }


            }
            //밑은 종료조건 이다.
            result = JudgeWinner("X");
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
            //여기까지


        }
        if(win_user == "computer")
        {
            result1 += 1;
        }
        else if(win_user == "user")
        {
            result2 += 1;
        }

        ScreenBoard screenBoard = new ScreenBoard();
        int DoOrNOt = screenBoard.PrintComputerScreenBoard(result1 + return_result1, result2 + return_result2);
        if (DoOrNOt == 1)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.PlayWithComputer(result1 + return_result1, result2 + return_result2);
        }

        return -1;
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
    

    public int JudgeWinner(string OorX) //종료 판독 메소드
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

    public void PlayWithUser(int return_result1, int return_result2)
    {
        
        string user1_num="0";
        string user2_num="0";
        string win_user ="NONE";

        int result1=0, result2=0;   
        int i, j;
        int cnt=0;
        ExceptionHandling exceptionHandling = new ExceptionHandling();
        
        while (true)
        {
            Console.Write("                                        ▶ [USER1] 번호를 입력하세요:  ");
            user1_num = Console.ReadLine();    //user 1
            exceptionHandling.PutNumberWrong_Fix(user1_num);

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

            ui.PrintGameBoard(room); //보드판 출력

            result1 = JudgeWinner("O");
            if (result1 == 1)
            {
                win_user = "user1";
                break;
            }
            if (cnt == 9) break;

            Console.Write("                                        ▶ [USER2] 번호를 입력하세요:  ");
            user2_num = Console.ReadLine(); //user 2
            exceptionHandling.PutNumberWrong_Fix(user2_num);

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

            ui.PrintGameBoard(room);

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
            if( cnt >= 9)
            {
                win_user = "DRAW";
            }
        }

        ScreenBoard screenBoard = new ScreenBoard();
        int DoOrNOt = screenBoard.PrintUserScreenBoard(result1+ return_result1, result2 + return_result2);
        if(DoOrNOt == 1)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.PlayWithUser(result1 + return_result1, result2 + return_result2);
        }
    }
}
