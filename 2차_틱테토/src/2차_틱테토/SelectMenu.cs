using System;

public partial class SelectMenu
{
	string menu_number;
	int int_menu_number;

    public void MenuFinder()
	{	
		string menu_number = Console.ReadLine();
        ExceptionHandling exceptionHandling = new ExceptionHandling();
		exceptionHandling.SelectMenuWrong_Fix(menu_number);
        Console.Clear();
		GamePlay gamePlay = new GamePlay();
        
		int_menu_number = int.Parse(menu_number);

		if (int_menu_number == 1)
		{
			gamePlay.PlayWithComputer(0,0);

        }
		else if (int_menu_number == 2)
		{
            gamePlay.PlayWithUser(0,0);
        }
		else
		{
			
			//에외 처리
		}
	}
}
