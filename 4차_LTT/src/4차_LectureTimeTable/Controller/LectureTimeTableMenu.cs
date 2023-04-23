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
    public class LectureTimeTableMenu
    {
        MenuUi menuUi= new MenuUi();
        LectureException lectureException= new LectureException();

        DataStorage dataStorage;

        public LectureTimeTableMenu(DataStorage dataStorage) //생성자 
        {
            this.dataStorage = dataStorage;
        }

        string[] menuList = { "○ 강의 시간표 조회", "○ 관심과목 담기", "○ 수강 신청", "○ 수강 신청 내역 조회" };
        int selectedMenu;

        public void ControllLectureTimeTableMenu(UserDTO userInformation) //로그인한 유저의 정보 인자로 받아오기
        {
            MenuSelectController menuSelectController = new MenuSelectController(menuUi);
            CourseFinder courseFinder = new CourseFinder(dataStorage, lectureException, menuUi, menuSelectController);
            CourseOfInterestAdder courseOfInterestAdder = new CourseOfInterestAdder(menuUi, dataStorage, lectureException, menuSelectController);
            

            menuUi.PrintMenuUi(userInformation.UserName);
            selectedMenu = menuSelectController.SelectMenuWithUpAndDown(menuList, 4, 42, 12);

            switch (selectedMenu)
            {
                case (int)MenuList.COURSE_FINDER:
                    Console.SetWindowSize(150, 30);
                    courseFinder.FindCourse();
                    break;
                case (int)MenuList.COURSE_OF_INTEREST_ADDER:
                    Console.SetWindowSize(150, 30);
                    courseOfInterestAdder.ControllAddInterestLectureMenu(userInformation);
                    break;

                case (int)MenuList.COURSE_REGISTRATION:

                case (int)MenuList.COURSE_REGISTRATION_CHECKER:
                    break;
                
            }
           

        }

    }
}
