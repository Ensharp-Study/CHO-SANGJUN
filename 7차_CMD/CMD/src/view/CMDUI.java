package view;

public class CMDUI {
    public void printInitialOutputOfCMD(String[] InitialOutputOfCMD){
        System.out.println(InitialOutputOfCMD[0] + "\n" + InitialOutputOfCMD[1]);
    }

    public void printCommandLine(String path){ //커맨드라인 출력하는 함수
        System.out.print(path + ">");
    }
}
