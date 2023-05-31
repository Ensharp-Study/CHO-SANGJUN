package utility;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

public class DesktopInformation {

    public DesktopInformation(){

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


}
