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
            userData = new List<UserDTO>();

            UserDTO userOneData = new UserDTO(); //기존에 저장 된 유저 정보 
            userOneData.UserId = "20011609";
            userOneData.UserPassword = "password1";
            userOneData.UserName = "조상준";
            userData.Add(userOneData);

            UserDTO userTwoData = new UserDTO();
            userTwoData.UserId = "22010323";
            userTwoData.UserPassword = "password234";
            userTwoData.UserName = "김현아";
            userData.Add(userTwoData);

            UserDTO userThreeData = new UserDTO();
            userThreeData.UserId = "19011069";
            userThreeData.UserPassword = "password123";
            userThreeData.UserName = "권오성";
            userData.Add(userThreeData);
        }

        public List<UserDTO> userData;

        public Array lectureTotalData; //엑셀에서 불러온 데이터 저장하는 배열



    }
}
