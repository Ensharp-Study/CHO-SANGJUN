package controller.commandFunction;

import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;
import view.CMDUI;

import java.io.File;
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

        String pathRemainedWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,2, !Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 미제거
        String pathRemovedWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,2, Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 제거

        if(pathRemovedWhiteSpace.equals("")){ // cd만 입력한 경우 > 현재경로 출력
            cmdui.printCommandResult(currentPath);
        }
        else if (pathRemovedWhiteSpace.equals("..") || pathRemovedWhiteSpace.equals("..\\") || pathRemovedWhiteSpace.equals("../")){ //이전 경로인 경우
            currentPath = getParentPath(currentPath);
        }
        else if (pathRemovedWhiteSpace.equals("\\")){ // 최상위 폴더로 이동하는 경우
            currentPath = getRootPath(currentPath);
        }


        return currentPath;
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
}
