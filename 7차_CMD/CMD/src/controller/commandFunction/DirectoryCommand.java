package controller.commandFunction;

import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;

import org.apache.commons.io.FileUtils;

import java.io.File;
import java.util.Date;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class DirectoryCommand {
    public DesktopInformation desktopInformation;
    public ExceptionHandling exceptionHandling;
    public DirectoryCommand(DesktopInformation desktopInformation, ExceptionHandling exceptionHandling){
        this.desktopInformation = desktopInformation;
        this.exceptionHandling = exceptionHandling;
    }

    public void differentiateChangeDirectoryFunction(String OptimizedString,String currentPath){
        String path = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,3, Constants.IS_REMOVE_WHITE_SPACE); //입력받은 문자열 명령어 제거 및 앞뒤공백 제거

        if(OptimizedString.startsWith("c:")){ //dir경로에 파일 경로를 처음부터 입력한 경우
            findDirectoryWithPathFromRoot(path);
        }
        else{
            if(OptimizedString.contains("\\")){ //경로가 아닌 하위 디렉토리나 파일만 입력한 경우

            }
            else{ //드라이브 경로가 아닌 중간 경로부터 입력한 경우

            }
        }


    }

    public void getVolumeInformation(){
        String volumeName;
        String volumeSerialNumber;

        volumeName = desktopInformation.getDriveVolumeName("C:\\"); // 볼륨 이름 불러오기
        volumeSerialNumber =desktopInformation.getDriveVolumeSerialNumber("C:\\"); // 드라이브 시리얼 넘버 불러오기
    }

    public void findDirectoryWithPathFromRoot(String path){ //root부터 해당 파일까지 전체경로 입력받은경우
        String directoryPath = path; // 디렉토리 경로
        int count = 0;

        File directory = new File(directoryPath);

        if (directory.exists() && directory.isDirectory()) {
            File[] files = directory.listFiles();

            if (files != null) {
                for (File file : files) {
                    if(!file.isHidden() && !FileUtils.isSymlink(file)) { // 히든파일 및 링크파일 출력하지 않기
                        String name = file.getName();
                        Date lastModified = new Date(file.lastModified());
                        String type = file.isDirectory() ? "디렉터리" : "파일";

                        System.out.println("이름: " + name);
                        System.out.println("수정 시간: " + lastModified);
                        System.out.println("타입: " + type);
                        System.out.println("-----------");
                        count++;
                    }
                }
                System.out.println(count);
            }
        }
    }

}
