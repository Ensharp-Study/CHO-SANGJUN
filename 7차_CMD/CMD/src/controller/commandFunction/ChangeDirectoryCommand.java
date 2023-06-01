package controller.commandFunction;

import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;
import view.CMDUI;

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

        String pathRemainedWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,2, !Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 미제거
        String pathRemovedWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,2, Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 제거

        if(pathRemovedWhiteSpace.equals("")){ // cd만 입력한 경우 > 현재경로 출력
            cmdui.printCommandResult(currentPath);
        }
        else if (pathRemovedWhiteSpace.startsWith("..") || pathRemovedWhiteSpace.startsWith("..\\")){ //이전 경로인 경우

        }
        else if (pathRemovedWhiteSpace.equals("\\")){ // 최상위 폴더로 이동하는 경우

        }


        return currentPath;
    }
}
