package controller;

import utility.DesktopInformation;
import view.CMDUI;

public class CMDStart {
    public DesktopInformation desktopInformation;
    public CMDUI cmdUI;
    public CMDStart(){
        this.desktopInformation = new DesktopInformation();
        this.cmdUI = new CMDUI();
    }

    public void startCMD(){
        String directoryPath = "user.home";

        setCMDbasicUI();
        while (true) {
            cmdUI.printCommandLine(desktopInformation.getDirectoryPath(directoryPath)); // 커맨드 라인 출력
            receiveInputCommandLine(); //명령어 입력 받기
            break;
        }
    }

    public void setCMDbasicUI(){ //CMD 실행시 기본으로 출력되는 UI설정
        String[] InitialOutputOfCMD = new String[2]; //CMD실행시 출력되는 2줄 저장하는 배열

        InitialOutputOfCMD = desktopInformation.getInitialOutputOfCMD(); //cmd 버전정보 불러오기
        cmdUI.printInitialOutputOfCMD(InitialOutputOfCMD); //cmd 버전정보 출력하기
    }

    public void receiveInputCommandLine(){

    }
}
