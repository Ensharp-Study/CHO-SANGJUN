package utility;

public class ExceptionHandling {
    public String optimizeStringForJudge(String inputSentence){
        String patternOptimizedString; //명령어 판단하기 위해 문자열 조정하기

        patternOptimizedString = inputSentence.toLowerCase(); // 소문자로 변환하기
        patternOptimizedString = patternOptimizedString.trim(); //명령어 앞,뒤쪽 공백제거

        //최적화된 문자열 반환
        return patternOptimizedString;
    }
    public String optimizeStringRemoveCommand(String inputCommandLine, int commandLength, boolean isWhitespaceRemove){
        inputCommandLine = inputCommandLine.substring(commandLength); //  명령어 지우기
        if(isWhitespaceRemove) inputCommandLine = inputCommandLine.trim(); //참인경우에만 앞뒤 공백 제거
        return inputCommandLine;
    }

    public void changeDirectoryExceptionHanding(){

    }


}
