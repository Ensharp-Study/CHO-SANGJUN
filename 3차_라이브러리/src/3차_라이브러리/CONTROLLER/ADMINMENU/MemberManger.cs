using System;

public class MemberManger
{
    public void ManageMember(Data data, Ui ui)
    {
        string userNumber;

        ui.PrintMemberManagerMenu();
        for (int i = 0; i < data.userList.Count; i++) {
            ui.PrintMemberList(data, i);
        }
        Console.SetCursorPosition(70, 2);
        
        userNumber = Console.ReadLine();

        for(int i=0; i< data.userList.Count; i++)
        {
            if(int.Parse(userNumber) == data.userList[i].userNumber)
            {
                data.userList.RemoveAt(i);
            }
        }

        ui.PrintDeletingUserSuccessSentence();
        for (int i = 0; i < data.userList.Count; i++)
        {
            ui.PrintMemberList(data, i);
        } 

    } 

    
}
