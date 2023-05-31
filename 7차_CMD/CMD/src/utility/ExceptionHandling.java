package utility;

public class ExceptionHandling {
    public String optimizeStringForJudge(String inputSentence){
        String patternOptimizedString; //명령어 판단하기 위해 문자열 조정하기

        patternOptimizedString = inputSentence.toLowerCase(); // 소문자로 변환하기
        //명령어 앞쪽 공백제거
        while(patternOptimizedString.charAt(0) == ' '){
            patternOptimizedString = patternOptimizedString.substring(1);
        }

        //최적화된 문자열 반환
        return patternOptimizedString;
    }

    public void changeDirectoryExceptionHanding(){

    }


}
