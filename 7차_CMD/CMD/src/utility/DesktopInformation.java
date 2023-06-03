package utility;

import java.io.*;
import java.nio.file.*;

public class DesktopInformation {

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



}
