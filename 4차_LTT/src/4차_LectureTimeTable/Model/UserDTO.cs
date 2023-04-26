using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Model
{
    public class UserDTO
    {
        public UserDTO() 
        {
            userInterestLecture = new List<LectureDTO>();
        }
        private string userId;
        public string UserId
        {
            get { return userId; } 
            set { userId = value; }
        }

        private string userPassword;
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        private List<LectureDTO> userInterestLecture;  //사용자의 관심과목을 저장하는 리스트 선언
        public List<LectureDTO> UserInterestLecture
        {
            get { return userInterestLecture; }
        }

        private int availableCreditsForRegistrationOfInterestLecture; //관심과목 담기 가능 학점
        public int AvailableCreditsForRegistrationOfInterestLecture
        {
            get { return  availableCreditsForRegistrationOfInterestLecture;}
            set { availableCreditsForRegistrationOfInterestLecture = value; }
        }

        private int earnedCreditsOfInterestLecture; //담은 학점수
        public int EarnedCreditsOfInterestLecture
        {
            get { return earnedCreditsOfInterestLecture; }
            set { earnedCreditsOfInterestLecture = value; }
        }


        private string userInterestLectureCredits;
        public string UserInterestLectureCredits
        {
            get { return userInterestLectureCredits; }
            set { userInterestLectureCredits = value; }
        }

    }
}
