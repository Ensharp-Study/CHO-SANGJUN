using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Controller
{
    public class LectureTimeTableMenu //초기 메뉴 선택하는 클래스
    {
        public DataStorage dataStorage;
        public MenuUi menuUi = new MenuUi();
        public LectureException lectureException = new LectureException(); //생성자로 내리기

        public LectureTimeTableMenu(DataStorage dataStorage) //생성자 
        {
            this.dataStorage = dataStorage;
        }

        string[] menuList = { "○ 강의 시간표 조회", "○ 관심과목 담기", "○ 수강 신청", "○ 수강 신청 내역 조회" };
        int selectedMenu;

        public void ControllLectureTimeTableMenu(UserDTO userInformation) //로그인한 유저의 정보 인자로 받아오기
        {
            while (true)
            {
                MenuSelectController menuSelectController = new MenuSelectController(menuUi);
                CourseFinder courseFinder = new CourseFinder(dataStorage, lectureException, menuUi, menuSelectController);
                CourseOfInterestAdder courseOfInterestAdder = new CourseOfInterestAdder(menuUi, dataStorage, lectureException, menuSelectController);

                menuUi.PrintMenuUi(userInformation.UserName);
                selectedMenu = menuSelectController.SelectMenuWithUpAndDown(menuList, 4, 42, 12); //초기 메뉴선택 상하키 함수로 선택

                switch (selectedMenu)
                {
                    case (int)MenuList.COURSE_FINDER: //강의 찾기
                        Console.SetWindowSize(190, 30);
                        courseFinder.FindCourse();
                        break;
                    case (int)MenuList.COURSE_OF_INTEREST_ADDER: //관심과목 담기
                        Console.SetWindowSize(180, 30);
                        courseOfInterestAdder.ControllAddInterestLectureMenu(userInformation);
                        break;

                    case (int)MenuList.COURSE_REGISTRATION: //수강신청하기

                    case (int)MenuList.COURSE_REGISTRATION_CHECKER: //시간표 확인하기
                        break;

                }
            }

        }
        
    }
}
