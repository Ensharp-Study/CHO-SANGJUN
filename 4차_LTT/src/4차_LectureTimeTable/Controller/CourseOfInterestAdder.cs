using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;

namespace _4차_LectureTimeTable.Controller
{
    public class CourseOfInterestAdder
    {
        LectureOfInterestAdderUi lectureOfInterestAdderUi = new LectureOfInterestAdderUi();
        MenuUi menuUi;
        MenuSelectController menuSelectController;
        CourseFinder courseFinder;

        public CourseOfInterestAdder( MenuUi menuUi, MenuSelectController menuSelectController, CourseFinder courseFinder)
        { 
            this.menuUi = menuUi;
            this.menuSelectController = menuSelectController;
            this.courseFinder = courseFinder;
        }

        public int selectedMenu;
        public string[] menuList = { "○ 관심과목 검색", "○ 관심과목 내역", "○ 관심과목 삭제" };
        public void AddInterestLecture(UserDTO userInformation)
        {
            Console.Clear();
            menuUi.PrintMenuUi(userInformation.UserName);
            selectedMenu = menuSelectController.SelectMenuWithUpAndDown(menuList, 3, 42, 12);

        }
        
    }
}
