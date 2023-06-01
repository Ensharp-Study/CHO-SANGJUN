package controller;

import controller.commandFunction.ChangeDirectoryCommand;
import controller.commandFunction.CommonLanguageSpecificationCommand;
import controller.commandFunction.DirectoryCommand;
import controller.commandFunction.HelpCommand;
import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;
import view.CMDUI;

import java.util.Scanner;
import java.util.regex.Pattern;

public class CMDStart {
    public DesktopInformation desktopInformation;
    public CMDUI cmdUI;
    public ExceptionHandling exceptionHandling;

    //명령어 처리 클래스
    public ChangeDirectoryCommand changeDirectoryCommand;
    public DirectoryCommand directoryCommand;
    public HelpCommand helpCommand;
    public CommonLanguageSpecificationCommand commonLanguageSpecificationCommand;

    public CMDStart(){
        this.cmdUI = CMDUI.getInstance();
        this.desktopInformation = new DesktopInformation();
        this.exceptionHandling = new ExceptionHandling();

        //명령어 처리 클래스
        this.changeDirectoryCommand = new ChangeDirectoryCommand(desktopInformation,exceptionHandling);
        this.directoryCommand = new DirectoryCommand(desktopInformation,exceptionHandling);
        this.helpCommand = new HelpCommand();
        this.commonLanguageSpecificationCommand =new CommonLanguageSpecificationCommand();
    }

    public void startCMD(){
        String searchWord = "user.home"; // 초기 출력 경로
        String currentPath;
        String inputSentence;

        setCMDbasicUI(); //기본 출력창 출력하기
        currentPath = desktopInformation.getDirectoryPath(searchWord);
        cmdUI.printCommandLine(currentPath); // 맨처음 커맨드 라인 출력

        while (true) {
            inputSentence = receiveInputCommandLine(); //명령어 입력 받기
            currentPath = classifyCommandFunction(inputSentence, currentPath); //명령어 구분하고 해당 명령어 클래스로 들어가기
            cmdUI.printCommandLine(currentPath); //다음입력 받기
        }
    }

    public void setCMDbasicUI(){ //CMD 실행시 기본으로 출력되는 UI설정
        String[] InitialOutputOfCMD = new String[2]; //CMD실행시 출력되는 2줄 저장하는 배열

        InitialOutputOfCMD = desktopInformation.getInitialOutputOfCMD(); //cmd 버전정보 불러오기
        cmdUI.printInitialOutputOfCMD(InitialOutputOfCMD); //cmd 버전정보 출력하기
    }

    public String receiveInputCommandLine(){
        Scanner scan = new Scanner(System.in);
        String inputSentence = scan.nextLine(); //명령어 입력받기
        return inputSentence;
    }

    public String classifyCommandFunction(String inputSentence, String currentPath) { // 어떤 명령어가 들어왔는지 확인하는 함수
        String OptimizedString;

        OptimizedString = exceptionHandling.optimizeStringForJudge(inputSentence); //검사하기 알맞게 문자열 최적화

        if (OptimizedString.startsWith("cd")) { //cd 명령어
            currentPath = changeDirectoryCommand.differentiateChangeDirectoryFunction(OptimizedString, currentPath);
        }
        else if (OptimizedString.startsWith("dir")) { //dir 명령어
            directoryCommand.differentiateChangeDirectoryFunction(OptimizedString, currentPath);
        }
        else if (OptimizedString.startsWith("cls")) {//cls 명령어
            commonLanguageSpecificationCommand.clearAll();
        }
        else if (OptimizedString.startsWith("help")) { //help 명령어
            helpCommand.printHelpPhrase();
        }
        else if (OptimizedString.startsWith("copy")) { //copy 명령어

        }
        else if (OptimizedString.startsWith("move")) { //move 명령어

        }
        else { //해당하는 명령어가 없을 때
            // 배치파일이 아닙니다 오류 문 출력
        }

        return currentPath;
    }
}
