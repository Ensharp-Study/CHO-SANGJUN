package controller;

import utility.DesktopInformation;
import view.CMDUI;

public class CMDStart {
    public DesktopInformation desktopInformation;
    public CMDUI cmdui;
    public CMDStart(){
        this.desktopInformation = new DesktopInformation();
        this.cmdui = new CMDUI();
    }

    public void startCMD(){
        setCMDbasicUI();
    }

    public void setCMDbasicUI(){ //CMD 실행시 기본으로 출력되는 UI설정
        String[] InitialOutputOfCMD = new String[2]; //CMD실행시 출력되는 2줄 저장하는 배열

        InitialOutputOfCMD = desktopInformation.getInitialOutputOfCMD(); //cmd 버전정보 불러오기
        cmdui.printInitialOutputOfCMD(InitialOutputOfCMD); //cmd 버전정보 출력하기
    }
}
