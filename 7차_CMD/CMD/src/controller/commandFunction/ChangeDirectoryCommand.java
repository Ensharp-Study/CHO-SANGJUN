package controller.commandFunction;

import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;
import view.CMDUI;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class ChangeDirectoryCommand {
    public DesktopInformation desktopInformation;
    public ExceptionHandling exceptionHandling;
    public CMDUI cmdui;

    public ChangeDirectoryCommand(DesktopInformation desktopInformation, ExceptionHandling exceptionHandling){
        this.desktopInformation = desktopInformation;
        this.exceptionHandling = exceptionHandling;
        this.cmdui = CMDUI.getInstance();
    }

    public String differentiateChangeDirectoryFunction(String OptimizedString,String currentPath){

        String pathRemainedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,2, !Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 미제거
        String pathRemovedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,2, Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 제거

        //1. 마침표로 이동하는 경우
        if(pathRemovedHeadAndTailWhiteSpace.equals("")){ // cd만 입력한 경우 > 현재경로 출력
            cmdui.printCommandResult(currentPath);
            return currentPath;
        }
        else if (pathRemovedHeadAndTailWhiteSpace.equals("..") || pathRemovedHeadAndTailWhiteSpace.equals("..\\") || pathRemovedHeadAndTailWhiteSpace.equals("../")){ //이전 경로인 경우
            currentPath = getParentPath(currentPath);
            return currentPath;
        }
        else if (pathRemovedHeadAndTailWhiteSpace.equals("\\") || pathRemovedHeadAndTailWhiteSpace.equals("/")){ // 최상위 폴더로 이동하는 경우
            currentPath = getRootPath(currentPath);
            return currentPath;
        }

        //2. 절대 경로를 입력 받는 경우
        if(pathRemainedHeadAndTailWhiteSpace.charAt(0) == ' '){
            //cd와 뒤의 문자열이 띄어쓰기 되어있으면 앞뒤 띄어쓰기 제거하기 위해 pathRemovedHeadAndTailWhiteSpace 사용
            if(pathRemovedHeadAndTailWhiteSpace.startsWith("c:")){ //root부터 전체 경로를 입력 했을 경우
                if(checkPathExists(pathRemovedHeadAndTailWhiteSpace)) { // 파일경로가 있을때
                    currentPath = pathRemovedHeadAndTailWhiteSpace;
                }
                else {
                    //지정된 경로를 찾을 수 없습니다.
                    cmdui.printErrorMessage(Constants.CANNOT_FIND_PATH);
                }
            }

            // "\Users\junch" 와 같이 절대경로 중 일부만 입력 시
            else if(pathRemovedHeadAndTailWhiteSpace.startsWith("\\") || pathRemovedHeadAndTailWhiteSpace.startsWith("/")){
                if( checkPathExists(pathRemovedHeadAndTailWhiteSpace)){
                    currentPath=getPath(pathRemovedHeadAndTailWhiteSpace);
                }
                else {
                    //지정된 경로를 찾을 수 없습니다.
                    cmdui.printErrorMessage(Constants.CANNOT_FIND_PATH);
                }
            }

            //디렉토리명만 입력 받았을 시
            else if(!pathRemovedHeadAndTailWhiteSpace.contains("\\") && !pathRemovedHeadAndTailWhiteSpace.contains("/")){
                if ( checkPathExists(currentPath + "\\" + pathRemovedHeadAndTailWhiteSpace)){
                    currentPath=getPath(currentPath + "\\" + pathRemovedHeadAndTailWhiteSpace);
                }
                else{
                    String stringsArray[] = pathRemovedHeadAndTailWhiteSpace.split(" "); //입력받은 값 중 띄어쓰기 나오기 전 문자열만 추출하기
                    cmdui.printErrorMessage("\'"+ stringsArray[0] + "\'"+ Constants.NOT_FIND_COMMAND);
                }
            }

            //이외 이상한 값 입력 받았을 시
            else{
                //지정된 경로를 찾을 수 없습니다.
                cmdui.printErrorMessage(Constants.CANNOT_FIND_PATH);
            }
        }

        //3. 올바르지 않은 명령어 입력시
        else{ // cd뒤에 문자가 붙어서 나오는 경우

        }
        return currentPath;
    }

    public String getPath(String inputPath){
        inputPath = inputPath.replaceAll(" ",""); //공백제거

        Path inputDirectoryPath = Paths.get(inputPath).toAbsolutePath();
        inputPath = inputDirectoryPath.toString();
        return inputPath;
    }

    public String getParentPath(String currentPath) {
        String parentPath;

        Path currentDirectoryPath = Paths.get(currentPath);
        Path parentDirectoryPath = currentDirectoryPath.getParent();

        if (parentDirectoryPath == null) return currentPath; // 현재 경로가 root인 경우
        parentPath = parentDirectoryPath.toString();
        return parentPath;
    }

    public String getRootPath(String currentPath){
        String rootPath;

        Path currentDirectoryPath = Paths.get(currentPath);
        Path rootDirectoryPath = currentDirectoryPath.getRoot();

        rootPath = rootDirectoryPath.toString();
        return rootPath;
    }

    public boolean checkPathExists(String inputPath) {
        boolean pathValidation;
        boolean isCorrectInput;

        if (inputPath.contains(" ")) { //경로에 공백이 함께 있는 경우 예외처리
            isCorrectInput = exceptionHandling.judgeWhiteSpaceContainedPathValidation(inputPath); //경로에 공백이 같이 들어왔을 경우 예외처리
            if (!isCorrectInput) {//올바르지 않은 경로 일때
                pathValidation = !Constants.IS_Valid_Path; //경로 오류
                return pathValidation;
            }
        }
        //공백이 있는 경우 제거
        inputPath = inputPath.replaceAll(" ","");

        Path inputDirectoryPath = Paths.get(inputPath).toAbsolutePath();
        pathValidation = Files.exists(inputDirectoryPath);

        return pathValidation;
    }
}
