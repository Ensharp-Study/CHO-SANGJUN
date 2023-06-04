package controller.command;

import controller.commandHelper.CopyAndMove;
import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;
import view.CMDUI;

import java.util.ArrayList;
import java.util.List;

public class MoveCommand extends CopyAndMove {
    public DesktopInformation desktopInformation;
    public ExceptionHandling exceptionHandling;

    public MoveCommand(ExceptionHandling exceptionHandling){
        this.desktopInformation = DesktopInformation.getInstance();
        this.exceptionHandling = exceptionHandling;
    }

    public String differentiateMoveFunction(String inputSentence, String currentPath){
        String OptimizedString = exceptionHandling.optimizeStringForJudge(inputSentence); //검사하기 알맞게 문자열 최적화
        String pathRemainedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString, 4, !Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 미제거
        String pathRemovedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString, 4, Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 제거
        List<String> vaildPaths = new ArrayList<String>();

        if(pathRemainedHeadAndTailWhiteSpace.charAt(0) == ' '){
            vaildPaths = checkAndFindValidationPathAndFileInInputCommand(pathRemovedHeadAndTailWhiteSpace,currentPath);
            if(vaildPaths.size() == 0){ //입력받은 경로나 파일이 올바르지 않은 경우
                CMDUI.printErrorMessage(Constants.CANNOT_FIND_FILE);
                return currentPath;
            }
            //올바른 경우 파일 복사하기
            distinguishMoveCase(vaildPaths, currentPath);

        }

        else{ //copy명령어 뒤에 공백이 아닌 경우 > 올바르지 않은 명령어 처리
            //입력받은 c,o,p,y가 대문자인지 소문자인지 알아내기 위해 맨처음 입력받은 문자열에서 copy부분 가져오기
            String cdInput = inputSentence.trim().substring(0, 4);
            //입력받은 값 중 띄어쓰기 나오기 전 문자열만 추출하기
            String stringsArray[] = pathRemovedHeadAndTailWhiteSpace.split(" ");
            CMDUI.printErrorMessage("\'" + cdInput + stringsArray[0] + "\'" + Constants.NOT_FIND_COMMAND);
            return currentPath;
        }

        return currentPath;
    }

