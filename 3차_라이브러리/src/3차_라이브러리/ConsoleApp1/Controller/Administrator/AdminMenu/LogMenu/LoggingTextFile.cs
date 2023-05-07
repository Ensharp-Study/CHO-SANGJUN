﻿using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller.Administrator.AdminMenu.LogMenu
{
    public class LoggingTextFile
    {
        LogDAO logDAO;
        public LoggingTextFile()
        {
            this.logDAO = new LogDAO();
        }

        public void SaveLogDateToTEXT()
        {
            List<LogDTO> allLogData = new List<LogDTO>();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //바탕화면 경로 설정
            string filePath = Path.Combine(desktopPath, "로그정보.txt");

            // ui.
            //모든 로그정보 불러오기
            allLogData = logDAO.ReadAllLogData();

            //출력 문자 틀 구성하기
            string text = Constants.LOG_TEXT_FRAME_1 + Constants.LOG_TEXT_FRAME_2 + Constants.LOG_TEXT_FRAME_3;
            allLogData = logDAO.ReadAllLogData();
            foreach (LogDTO log in allLogData)
            {
                text = text + Constants.LOG_LIST_FRAME_1 + 
                    Constants.LOG_ID + (log.LogNumber).ToString() + 
                    Constants.LOG_TIME + log.LogTime +
                    Constants.LOG_USER + log.LogUser +
                    Constants.LOG_INFORMATION + log.LogInformation +
                    Constants.LOG_ACTION + log.LogAction+
                    Constants.LOG_LIST_FRAME_2;
            }

            //파일 저장하기
            File.WriteAllText(filePath, text);
        }
    }
}
