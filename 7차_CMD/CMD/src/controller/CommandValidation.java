package controller;

import utility.Constants;

import java.util.regex.Pattern;

public class CommandValidation {

    public void classifyCommandFunction(String command){ // 어떤 명령어가 들어왔는지 확인하는 함수
        String patternOptimizedString; //명령어 판단하기 위해 문자열 조정하기

        patternOptimizedString = command.toLowerCase(); // 소문자로 변환하기
        patternOptimizedString = command.replaceAll(" ", "");//공백제거

        if(Pattern.matches(Constants.CD_REGULAR_EXPRESSION, patternOptimizedString)){ //cd 명령어

        }
        else if(Pattern.matches(Constants.DIR_REGULAR_EXPRESSION, patternOptimizedString)){ //dir 명령어

        }
        else if(Pattern.matches(Constants.CLS_REGULAR_EXPRESSION, patternOptimizedString)){//cls 명령어

        }
        else if(Pattern.matches(Constants.HELP_REGULAR_EXPRESSION, patternOptimizedString)){ //help 명령어

        }
        else if(Pattern.matches(Constants.COPY_REGULAR_EXPRESSION, patternOptimizedString)){ //copy 명령어

        }
        else if(Pattern.matches(Constants.MOVE_REGULAR_EXPRESSION, patternOptimizedString)){ //move 명령어

        }
        else{ //해당하는 명령어가 없을 때

        }
    }

    public boolean changeDirectoryExceptionHanding(){ //cd 명령어 예외처리

    }


}
