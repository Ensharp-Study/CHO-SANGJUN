package controller.command;

import model.DriveVolumeDTO;
import utility.Constants;
import utility.DesktopInformation;
import utility.ExceptionHandling;

import org.apache.commons.io.FileUtils;
import view.CMDUI;

import java.io.File;
import java.util.Date;
import java.text.SimpleDateFormat;

public class DirectoryCommand {
    public DesktopInformation desktopInformation;
    public ExceptionHandling exceptionHandling;


    public DirectoryCommand(ExceptionHandling exceptionHandling){
        this.desktopInformation = DesktopInformation.getInstance();
        this.exceptionHandling = exceptionHandling;
    }

    public void differentiateChangeDirectoryFunction(String inputSentence, String currentPath){
        String OptimizedString = exceptionHandling.optimizeStringForJudge(inputSentence); //검사하기 알맞게 문자열 최적화
        String pathRemainedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,3, !Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 미제거
        String pathRemovedHeadAndTailWhiteSpace = exceptionHandling.optimizeStringRemoveCommand(OptimizedString,3, Constants.IS_REMOVE_WHITE_SPACE); //앞뒤 공백 제거

        //1. 마침표로 이동하는 경우
        if(pathRemovedHeadAndTailWhiteSpace.equals("")){ // dir만 입력한 경우 > 현재경로 디렉토리 출력
            findDirectoryWithPathFromRoot(currentPath);
            return;
        }
        else if(pathRemovedHeadAndTailWhiteSpace.equals(".")){
            return;
        }
        else if (pathRemovedHeadAndTailWhiteSpace.equals("..") || pathRemovedHeadAndTailWhiteSpace.equals("..\\") || pathRemovedHeadAndTailWhiteSpace.equals("../")){ //이전 경로인 경우
            return;
        }
        else if (pathRemovedHeadAndTailWhiteSpace.equals("\\") || pathRemovedHeadAndTailWhiteSpace.equals("/")){ // 최상위 폴더로 이동하는 경우
            return;
        }
        else if(pathRemovedHeadAndTailWhiteSpace.replaceAll(" ","").contains("/?")) { // "cd/?" 명령어는 공백에 상관없이 그리고 뒤에 어떤 문자가 같이와도 실행된다.
            return;
        }
    }

    public DriveVolumeDTO getVolumeInformation(){
        DriveVolumeDTO driveVolumeDTO = new DriveVolumeDTO();
        driveVolumeDTO.setVolumeName(desktopInformation.getDriveVolumeName("C:\\")); // 볼륨 이름 불러오기
        driveVolumeDTO.setvolumeSerialNumber(desktopInformation.getDriveVolumeSerialNumber("C:\\")); // 드라이브 시리얼 넘버 불러오기
        return driveVolumeDTO;
    }

    public void findDirectoryWithPathFromRoot(String path){
        String directoryPath = path; // 디렉토리 경로
        String directoryOrFileName; //파일 혹은 디렉토리 이름
        Date directoryOrFileModifiedDate; //파일 속성에서 불러온 수정일자
        String formattedDate; //포맷팅된 디렉토리 수정일자
        String directoryOrFileType; // 파일인지 디렉토리인지 형식
        SimpleDateFormat directoryTimeFormat = new SimpleDateFormat("yyyy-MM-dd a hh:mm"); //포맷 양식

        //1. 드라이브 정보 출력
        DriveVolumeDTO driveVolumeDTO = getVolumeInformation();
        CMDUI.printVolumeInformation(driveVolumeDTO);

        //2. 현재 디렉토리 출력

        //경로 정보 출력
        File directory = new File(directoryPath);
        if (directory.exists() && directory.isDirectory()) {
            File[] files = directory.listFiles();
            if (files != null) {
                //현재폴더
                //상위폴더
                for (File file : files) {
                    if(!file.isHidden() && !FileUtils.isSymlink(file)) { // 히든파일 및 링크파일 출력하지 않기
                        directoryOrFileName = file.getName();
                        directoryOrFileModifiedDate = new Date(file.lastModified());
                        formattedDate = directoryTimeFormat.format(directoryOrFileModifiedDate);
                        directoryOrFileType = file.isDirectory() ? "<DIR>" : "     ";

                        System.out.println(formattedDate + "   " + directoryOrFileType + "   " + directoryOrFileName);
                    }
                }
                //바이트 출력
            }
        }
    }

}
