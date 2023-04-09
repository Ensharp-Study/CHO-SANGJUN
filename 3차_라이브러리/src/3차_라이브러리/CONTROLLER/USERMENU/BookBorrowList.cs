using System;

public class BookBorrowList
{
	public void ShowBookBorrowList(Data data,Ui ui, MagicNumber magicNumber,UserInf user)
	{
		ui.PrintBorrowingList();
		for(int i=0; i<user.borrowBookList.Count; i++)
		{
			ui.PrintUserBorrowingList(user.borrowBookList[i]);

        }
		

    }
}
