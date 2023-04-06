using System;

public partial class Ui
{
	public void PrintMenuUi()
	{
		Console.WriteLine("*************************************************");
        Console.WriteLine("*                                               *");
        Console.WriteLine("*                                               *");
        Console.WriteLine("*                   [ MENU ]                    *");
        Console.WriteLine("*                                               *");
        Console.WriteLine("*              메뉴를 골라 주세요.              *");
        Console.WriteLine("*                                               *");
        Console.WriteLine("*             1. USER VS COMPUTER               *");
        Console.WriteLine("*                                               *");
        Console.WriteLine("*             2. USER VS USER                   *");
        Console.WriteLine("*                                               *");
        Console.Write("*             [메뉴 입력]:"); 
        Console.WriteLine("{0}               *",int.Parse(Console.ReadLine()));
        Console.WriteLine("*                                               *");
        Console.WriteLine("*                                               *");
        Console.WriteLine("*                                               *");
        Console.WriteLine("*************************************************");
    }
}
