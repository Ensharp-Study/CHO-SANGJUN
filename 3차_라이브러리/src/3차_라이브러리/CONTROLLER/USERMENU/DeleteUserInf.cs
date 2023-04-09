using System;

public class DeletingUserInf
{
	public void DeleteUserInf(Data data, UserInf user)
	{
		for (int i = 0; i < data.userList.Count; i++)
		{
			if (data.userList[i] == user)
			{
				data.userList.RemoveAt(i);
			}
		}
	}
}
