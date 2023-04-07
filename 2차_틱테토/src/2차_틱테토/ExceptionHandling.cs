using System;

public partial class ExceptionHandling
{

    public void SelectMenuWrong_Fix(string menu_number) 
    {
        Ui ui = new Ui(); // (메소드 밖에 선언하면 안되는 이유 찾아보기)
        SelectMenu selectMenu = new SelectMenu();

        if ( (menu_number != "1") && (menu_number != "2")){
            ui.WrongMenuNumInput();
            selectMenu.MenuFinder();
        }
        
    }
    public void PutNumberWrong_Fix(string number)
    {
        Ui ui = new Ui();
        
        if ( (number != "1") && (number != "2") && (number != "3") && (number != "4") && (number != "5") && (number != "6") && (number != "7") && (number != "8") && (number != "9"))
        {
            ui.WrongBoardNumInput();
            return;
        }
    }
}
