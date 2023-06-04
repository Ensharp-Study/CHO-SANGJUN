package controller.command;

import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;
import view.CMDUI;

public class ChangeDirectoryCommand {
    public DesktopInformation desktopInformation;
    public ExceptionHandling exceptionHandling;

    public ChangeDirectoryCommand(ExceptionHandling exceptionHandling){
        this.desktopInformation = DesktopInformation.getInstance();
        this.exceptionHandling = exceptionHandling;
    }

    public String differentiateChangeDirectoryFunction(String inputSentence, String currentPath) {
        String OptimizedString = exceptionHandling.optimizeStringForJudge(inputSentence); //검사하기 알맞게 문자열 최적화
        String pathRemainedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString, 2, !Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 미제거
        String pathRemovedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString, 2, Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 제거


        //1. 마침표로 이동하는 경우
        if (pathRemovedHeadAndTailWhiteSpace.equals("")) { // cd만 입력한 경우 > 현재경로 출력
            CMDUI.printCommandResult(currentPath);
            return currentPath;
        } else if (pathRemovedHeadAndTailWhiteSpace.equals(".")) {
            return currentPath;
        } else if (pathRemovedHeadAndTailWhiteSpace.equals("..") || pathRemovedHeadAndTailWhiteSpace.equals("..\\") || pathRemovedHeadAndTailWhiteSpace.equals("../")) { //이전 경로인 경우
            currentPath = desktopInformation.getParentPath(currentPath);
            return currentPath;
        } else if (pathRemovedHeadAndTailWhiteSpace.equals("\\") || pathRemovedHeadAndTailWhiteSpace.equals("/")) { // 최상위 폴더로 이동하는 경우
            currentPath = desktopInformation.getRootPath(currentPath);
            return currentPath;
        } else if (pathRemovedHeadAndTailWhiteSpace.replaceAll(" ", "").contains("/?")) { // "cd/?" 명령어는 공백에 상관없이 그리고 뒤에 어떤 문자가 같이와도 실행된다.
            CMDUI.printNotice(Constants.CHANGE_DIRECTORY_NOTICE);
            return currentPath;
        }

        //2.상대 경로를 입력 받는 경우
        if (pathRemovedHeadAndTailWhiteSpace.startsWith(".")) {
            if (desktopInformation.checkPathExists(currentPath + "/" + pathRemovedHeadAndTailWhiteSpace)) //상대경로 이므로 현재 디렉토리에 입력한 경로 붙이기
            {
                currentPath = desktopInformation.getPath(currentPath + "/" + pathRemovedHeadAndTailWhiteSpace);
                return currentPath;
            }
            //지정된 경로를 찾을 수 없습니다.
            CMDUI.printErrorMessage(Constants.CANNOT_FIND_PATH);

        }

        //3. 절대 경로를 입력 받는 경우
        if (pathRemainedHeadAndTailWhiteSpace.charAt(0) == ' ') {
            //cd와 뒤의 문자열이 띄어쓰기 되어있으면 앞뒤 띄어쓰기 제거하기 위해 pathRemovedHeadAndTailWhiteSpace 사용
            if (pathRemovedHeadAndTailWhiteSpace.startsWith("c:")) { //root부터 전체 경로를 입력 했을 경우
                if (desktopInformation.checkPathExists(pathRemovedHeadAndTailWhiteSpace)) { // 파일경로가 있을때
                    currentPath = pathRemovedHeadAndTailWhiteSpace;
                    return currentPath;
                }
                //지정된 경로를 찾을 수 없습니다.
                CMDUI.printErrorMessage(Constants.CANNOT_FIND_PATH);
                return currentPath;
            }

            // "\Users\junch" 와 같이 절대경로 중 일부만 입력 시
            else if (pathRemovedHeadAndTailWhiteSpace.startsWith("\\") || pathRemovedHeadAndTailWhiteSpace.startsWith("/")) {
                if (desktopInformation.checkPathExists(pathRemovedHeadAndTailWhiteSpace)) {
                    currentPath = desktopInformation.getPath(pathRemovedHeadAndTailWhiteSpace);
                    return currentPath;
                }
                //지정된 경로를 찾을 수 없습니다.
                CMDUI.printErrorMessage(Constants.CANNOT_FIND_PATH);
                return currentPath;
            }

            //디렉토리명만 입력 받았을 시
            else if (!pathRemovedHeadAndTailWhiteSpace.contains("\\") && !pathRemovedHeadAndTailWhiteSpace.contains("/")) {
                if (desktopInformation.checkPathExists(currentPath + "\\" + pathRemovedHeadAndTailWhiteSpace)) {
                    currentPath = desktopInformation.getPath(currentPath + "\\" + pathRemovedHeadAndTailWhiteSpace);
                    return currentPath;
                }
                //지정된 경로를 찾을 수 없습니다.
                CMDUI.printErrorMessage(Constants.CANNOT_FIND_PATH);
                return currentPath;
            }

            //이외 이상한 값 입력 받았을 시
            //지정된 경로를 찾을 수 없습니다.
            CMDUI.printErrorMessage(Constants.CANNOT_FIND_PATH);
            return currentPath;
        }

        //4. 올바르지 않은 명령어 입력시
        else {
            // cd뒤에 문자가 붙어서 나오는 경우
            //입력받은 c와 d가 대문자인지 소문자인지 알아내기 위해 맨처음 입력받은 문자열에서 cd부분 가져오기
            String cdInput = inputSentence.trim().substring(0, 2);
            //입력받은 값 중 띄어쓰기 나오기 전 문자열만 추출하기
            String stringsArray[] = pathRemovedHeadAndTailWhiteSpace.split(" ");
            CMDUI.printErrorMessage("\'" + cdInput + stringsArray[0] + "\'" + Constants.NOT_FIND_COMMAND);
            return currentPath;
        }
    }

}
