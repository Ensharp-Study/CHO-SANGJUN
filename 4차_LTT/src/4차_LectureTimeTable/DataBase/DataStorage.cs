using _4차_LectureTimeTable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.DataBase
{
    public class DataStorage
    {
        public DataStorage()
        {
            UserDTO userOneData = new UserDTO();        //기존에 저장 된 유저 정보 
            userOneData.UserId = "juncho1201";
            userOneData.UserPassword = "password123";
            userData.Add(userOneData);

            UserDTO userTwoData = new UserDTO();
            userTwoData.UserId = "mynameisuser2";
            userTwoData.UserPassword = "password234";
            userData.Add(userTwoData);
        }

        public List<UserDTO>userData = new List<UserDTO>();


    }
}
