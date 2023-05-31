package controller;

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
    public HelpCommand helpCommand;

    public CMDStart(){
        this.cmdUI = CMDUI.getInstance();
        this.desktopInformation = new DesktopInformation();
        this.exceptionHandling = new ExceptionHandling();

        //명령어 처리 클래스
        this.helpCommand = new HelpCommand();
    }

    public void startCMD(){
        String directoryPath = "user.home"; // 초기 출력 경로
        String inputSentence;

        setCMDbasicUI(); //기본 출력창 출력하기
        while (true) {
            cmdUI.printCommandLine(desktopInformation.getDirectoryPath(directoryPath)); // 커맨드 라인 출력
            inputSentence = receiveInputCommandLine(); //명령어 입력 받기
            classifyCommandFunction(inputSentence); //명령어 구분하기

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
        String inputSentence = scan.next(); //명령어 입력받기
        return inputSentence;
    }

    public void classifyCommandFunction(String inputSentence) { // 어떤 명령어가 들어왔는지 확인하는 함수
        String patternOptimizedString;

        patternOptimizedString = exceptionHandling.optimizeStringForJudge(inputSentence); //검사하기 알맞게 문자열 최적화

        if (Pattern.matches(Constants.CD_REGULAR_EXPRESSION, patternOptimizedString)) { //cd 명령어

        } else if (Pattern.matches(Constants.DIR_REGULAR_EXPRESSION, patternOptimizedString)) { //dir 명령어

        } else if (Pattern.matches(Constants.CLS_REGULAR_EXPRESSION, patternOptimizedString)) {//cls 명령어

        } else if (Pattern.matches(Constants.HELP_REGULAR_EXPRESSION, patternOptimizedString)) { //help 명령어
            helpCommand.printHelpPhrase();
        } else if (Pattern.matches(Constants.COPY_REGULAR_EXPRESSION, patternOptimizedString)) { //copy 명령어

        } else if (Pattern.matches(Constants.MOVE_REGULAR_EXPRESSION, patternOptimizedString)) { //move 명령어

        } else { //해당하는 명령어가 없을 때
            // 배치파일이 아닙니다 오류 문 출력
        }
    }
}
