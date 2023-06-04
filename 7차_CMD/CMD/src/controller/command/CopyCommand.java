package controller.command;

import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;
import view.CMDUI;

import java.util.ArrayList;
import java.util.List;

public class CopyCommand {
    public DesktopInformation desktopInformation;
    public ExceptionHandling exceptionHandling;
    public CopyCommand(ExceptionHandling exceptionHandling){
        this.desktopInformation = DesktopInformation.getInstance();
        this.exceptionHandling = exceptionHandling;
    }
    public String differentiateCopyFunction(String inputSentence, String currentPath){
        String OptimizedString = exceptionHandling.optimizeStringForJudge(inputSentence); //검사하기 알맞게 문자열 최적화
        String pathRemainedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString, 4, !Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 미제거
        String pathRemovedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString, 4, Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 제거
        List<String> vaildPaths = new ArrayList<String>();

        if(pathRemainedHeadAndTailWhiteSpace.charAt(0) == ' '){
            vaildPaths = checkValidationOfInputCommand(pathRemovedHeadAndTailWhiteSpace,currentPath);
            if(vaildPaths.size() == 0) System.out.println("no");
            for(int i = 0; i< vaildPaths.size(); i++){
                System.out.println(vaildPaths.get(i));
            }
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

    public List<String> checkValidationOfInputCommand(String pathRemovedHeadAndTailWhiteSpace, String currentPath){ //입력받은 명령어 문장 유효성 check하기
        String[] splittedInputCommand;
        List<String> validPathList = new ArrayList<String>();
        String potentiallyValidPath;
        int count = 0;

        //1. 공백을 기준으로 문자열 나누기
        splittedInputCommand = pathRemovedHeadAndTailWhiteSpace.split(" ");
        for(int i=0; i<splittedInputCommand.length; i++){
            validPathList.add(splittedInputCommand[i]);
        }

        //2. 나눠진 문자열들 앞뒤 합쳐서 유효한 주소이면 합치기 (디렉토리명이나 파일명에 공백이 포함되어 있을 경우를 찾기 위해 시행)
        while(count < validPathList.size() - 1){
            potentiallyValidPath = validPathList.get(count) + " " + validPathList.get(count + 1);
            if(desktopInformation.checkPathExists(potentiallyValidPath)){
                validPathList.set(count,potentiallyValidPath);
                validPathList.remove(count + 1);
                count = 0;
            }
            else count++;
        }
        //3. 상대경로인 경우(즉 , c:\으로 시작하지 않는 경우 상대경로 이므로 현재 경로랑 합쳐주기)
        for(int i=0; i<validPathList.size(); i++){
            if(!validPathList.get(i).startsWith("c:\\") && (validPathList.get(i).contains("\\") || validPathList.get(i).contains("/"))){ //파일이 아닌 경로인 경우만 확인
                validPathList.set(i, currentPath + "\\" +validPathList.get(i));
            }
        }

        //4. 리스트에 저장된 모든 디렉토리의 경로가 올바른지 확인하기
        for(int i=0; i<validPathList.size(); i++){
            if(validPathList.get(i).contains("\\") || validPathList.get(i).contains("/")) { //파일이 아닌 경로인 경우만 확인
                if (!desktopInformation.checkPathExists(validPathList.get(i))) {
                    //하나라도 올바르지 않은 경우 모든 원소 지우기
                    validPathList.clear();
                    return validPathList;
                }
            }
        }
        return validPathList;
    }
}
