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
            userRegistratedLecture = new List<LectureDTO>();

            TimeTableOfOfflineLecture = new string[26, 6]; //시간표 시간 30분 단위, 월~금으로 배열 구성
            Array.Clear(TimeTableOfOfflineLecture, 0, TimeTableOfOfflineLecture.Length);
        }

        private string userId;
        private string userPassword;
        private string userName;
        private int availableCreditsForRegistrationOfInterestLecture; //관심과목 담기 가능 학점
        private int earnedCreditsOfInterestLecture; //담은 학점수
        private string userInterestLectureCredits;

        private List<LectureDTO> userInterestLecture;  //사용자의 관심과목을 저장하는 리스트 선언
        private List<LectureDTO> userRegistratedLecture; //사용자의 수강 신청과목을 저장하는 리스트 선언

        string[,] TimeTableOfOfflineLecture;

        public string UserId
        {
            get { return userId; } 
            set { userId = value; }
        }

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        
        public List<LectureDTO> UserInterestLecture
        {
            get { return userInterestLecture; }
        }
        
        public int AvailableCreditsForRegistrationOfInterestLecture
        {
            get { return  availableCreditsForRegistrationOfInterestLecture;}
            set { availableCreditsForRegistrationOfInterestLecture = value; }
        }

        public int EarnedCreditsOfInterestLecture
        {
            get { return earnedCreditsOfInterestLecture; }
            set { earnedCreditsOfInterestLecture = value; }
        }
        
        public string UserInterestLectureCredits
        {
            get { return userInterestLectureCredits; }
            set { userInterestLectureCredits = value; }
        }

        public List<LectureDTO> UserRegistratedLecture
        {
            get { return userRegistratedLecture; }
        }
       
    }
}
