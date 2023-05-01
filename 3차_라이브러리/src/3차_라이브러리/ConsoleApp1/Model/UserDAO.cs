using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataBase
{
    public class UserDAO
    {
        ConnectionWithServer connectionWithServer;
        public UserDAO() 
        {
            this.connectionWithServer = new ConnectionWithServer();
        }

        public string CompareAccountInformation(string id, string password) // 아이디 패스워드와 비교하는 함수
        {
            string userNumber;
            string queryStatement = "SELECT * FROM user_data;";
            MySqlDataReader readedData = connectionWithServer.Select(queryStatement);

            while (readedData.Read())
            {
                if (readedData["UserId"].ToString() == id)
                {
                    if (readedData["UserPassword"].ToString() == password)
                    {
                        userNumber= readedData["UserNumber"].ToString();
                        readedData.Close();
                        return userNumber;
                    }
                    Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요"); //아이디만 맞고 비밀번호는 틀렸을 경우
                    break;
                    Console.ReadKey();
                }
            }
            readedData.Close();
            Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
            Console.ReadKey();
            return null;
        }
        
        public void NewUserDataCreate(UserDTO newUserInformation)
        {
            string queryStatement = string.Format("INSERT INTO user_data ( UserId, UserPassword, UserPhoneNumber, UserName,UserAddress, UserAge) VALUES ('{0}','{1}','{2}','{3}', '{4}','{5}');", newUserInformation.Id, newUserInformation.Password, newUserInformation.UserPhoneNumber,newUserInformation.UserName,newUserInformation.UserAddress,newUserInformation.UserAge);
            connectionWithServer.CUD(queryStatement);
        }

    }
}
