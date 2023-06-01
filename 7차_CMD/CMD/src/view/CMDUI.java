package view;

import utility.Constants;

public class CMDUI {
    //싱글톤 처리
    private static CMDUI instance;
    private CMDUI(){}
    public static synchronized CMDUI getInstance(){
        if(instance == null){
            instance = new CMDUI();
        }
        return instance;
    }


    public void printInitialOutputOfCMD(String[] InitialOutputOfCMD){
        System.out.println(InitialOutputOfCMD[0] + "\n" + InitialOutputOfCMD[1]);
    }

    public void printCommandLine(String path){ //커맨드라인 출력하는 함수
        System.out.print("\n"+ path + ">");
    }

    public void printHelpNotice(){
        System.out.print(Constants.HELP_NOTICE);
    }

    public void printCommandResult(String result){
        System.out.println(result);
    }

    public void printErrorMessage(String errorMessage){
        System.out.println(errorMessage);
    }
}
