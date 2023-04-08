using System;

public partial class SelectMenu
{
	string menuNumber;
	int intMenuNumber;
	

    ExceptionHandling exceptionHandling = new ExceptionHandling();
    GamePlay gamePlay = new GamePlay();
	Ui ui = new Ui();	
    public void MenuFinder() // 메뉴 고르기
	{
		int judgingEnd;

		while (true)
		{
            ui.PrintMenuUi();
            string menuNumber = Console.ReadLine(); //메뉴 번호 입력받기
			intMenuNumber = int.Parse(menuNumber);

			exceptionHandling.SelectMenuWrong_Fix(menuNumber); //예외처리
			Console.Clear();


			if (intMenuNumber == 1)
			{
                judgingEnd = gamePlay.PlayWithComputer(0, 0);
				if (judgingEnd == 1)
				{
					break;
				}
			}
			else if (intMenuNumber == 2)
			{
				gamePlay.PlayWithUser(0, 0);
			}
			else if (intMenuNumber == 3)
			{
				//프로그램 종료 위해 while 탈출
				ui.PrintEndSign();
                break;
			}
		}
		return; //프로그램 종료
	}
}
