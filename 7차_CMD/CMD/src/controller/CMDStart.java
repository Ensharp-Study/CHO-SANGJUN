package controller;

import utility.DesktopInformation;
import view.CMDUI;

import java.util.Scanner;

public class CMDStart {
    public DesktopInformation desktopInformation;
    public CMDUI cmdUI;
    public CommandValidation commandValidation;

    public CMDStart(){
        this.desktopInformation = new DesktopInformation();
        this.cmdUI = new CMDUI();
        this.commandValidation = new CommandValidation();
    }

    public void startCMD(){
        String directoryPath = "user.home"; // 초기 출력 경로
        String command;

        setCMDbasicUI(); //기본 출력창 출력하기
        while (true) {
            cmdUI.printCommandLine(desktopInformation.getDirectoryPath(directoryPath)); // 커맨드 라인 출력
            command = receiveInputCommandLine(); //명령어 입력 받기
            commandValidation

            break;
        }
    }

    public void setCMDbasicUI(){ //CMD 실행시 기본으로 출력되는 UI설정
        String[] InitialOutputOfCMD = new String[2]; //CMD실행시 출력되는 2줄 저장하는 배열

        InitialOutputOfCMD = desktopInformation.getInitialOutputOfCMD(); //cmd 버전정보 불러오기
        cmdUI.printInitialOutputOfCMD(InitialOutputOfCMD); //cmd 버전정보 출력하기
    }

    public String receiveInputCommandLine(){
        Scanner scan = new Scanner(System.in);
        String command = scan.next(); //명령어 입력받기
        return command;
    }
}
