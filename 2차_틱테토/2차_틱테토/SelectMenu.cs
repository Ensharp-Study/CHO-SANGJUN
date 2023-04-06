using System;

public partial class SelectMenu
{
	int menu_number;
	public void Method()
	{	
		menu_number = int.Parse(Console.ReadLine());
        
		GamePlay gamePlay = new GamePlay();
        
		/*if (menu_number == 1)
		{
			gamePlay.PlayWithComputer();

        }
		else*/ if (menu_number == 2)
		{
            gamePlay.PlayWithUser(0,0);
        }
		else
		{
			
			//에외 처리
		}
	}
}
