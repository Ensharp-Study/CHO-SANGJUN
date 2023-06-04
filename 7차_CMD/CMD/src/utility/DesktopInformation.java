package utility;

import java.io.*;
import java.nio.file.*;

public class DesktopInformation {
    //싱글 톤 처리
    private static DesktopInformation instance;
    private DesktopInformation() {
    }
    public static DesktopInformation getInstance() {
        if (instance == null) {
            instance = new DesktopInformation();
        }
        return instance;
    }

    public String[] getInitialOutputOfCMD(){ //cmd실행시 초기 출력값 받아오는 함수
        String[] printedSentence = new String[2]; //출력물 저장할 변수
        try {
            Process processOfCMD = Runtime.getRuntime().exec("cmd");

            // CMD 실행 결과를 읽기 위한 InputStream
            InputStream inputStreamOfExecutedCMD = processOfCMD.getInputStream();
            BufferedReader bufferedReaderOfresult = new BufferedReader(new InputStreamReader(inputStreamOfExecutedCMD));

            // CMD 실행시 첫 번째 두 줄을 읽어옴
            for (int i = 0; i < 2; i++) {
                String CMDLine = bufferedReaderOfresult.readLine();
                printedSentence[i] = CMDLine;
            }
            inputStreamOfExecutedCMD.close();
            bufferedReaderOfresult.close();

            //외부 프로그램인 CMD 종료
            processOfCMD.destroy();

        } catch (Exception e) {
            e.printStackTrace();
        }
        return printedSentence; //결과값 문자열 배열 반환
    }

    //getProperty 이용하여 디렉토리 경로 불러오기
    public String getDirectoryPath(String directory){
        String directoryPath = System.getProperty(directory);
        return directoryPath;
    }

    public String getDriveVolumeName(String drivePath) {
        String volumeName = "";
        try {
            Path path = FileSystems.getDefault().getPath(drivePath);
            FileStore fileStore = Files.getFileStore(path);
            volumeName = fileStore.name();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return volumeName;
    }

    public String getDriveVolumeSerialNumber(String drivePath){
        String volumeSerialNumber = "";
        try {
            Path path = Paths.get(drivePath);
            FileStore fileStore = Files.getFileStore(path);
            volumeSerialNumber = fileStore.getAttribute("volume:vsn").toString();
        } catch (Exception e) {
            e.printStackTrace();
        }

        return volumeSerialNumber;
    }

    public String getPath(String inputPath){
        inputPath = inputPath.replaceAll(" ",""); //공백제거

        Path inputDirectoryPath = Paths.get(inputPath).normalize().toAbsolutePath();
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

        /*if (inputPath.contains(" ")) { //경로에 공백이 함께 있는 경우 예외처리
            isCorrectInput = exceptionHandling.judgeWhiteSpaceContainedPathValidation(inputPath); //경로에 공백이 같이 들어왔을 경우 예외처리
            if (!isCorrectInput) {//올바르지 않은 경로 일때
                pathValidation = !Constants.IS_Valid_Path; //경로 오류
                return pathValidation;
            }
        }*/
        //공백이 있는 경우 제거
        /*inputPath = inputPath.replaceAll(" ","");*/

        try {
            Path inputDirectoryPath = Paths.get(inputPath).toAbsolutePath();
            pathValidation = Files.exists(inputDirectoryPath);
        } catch (Exception e) { //경로 중에 공백이 포함되어 있는데 디렉토리명의 공백이 아닌 경우 > 즉 터지는 경우 방지
            pathValidation = false;
        }

        return pathValidation;
    }


}
