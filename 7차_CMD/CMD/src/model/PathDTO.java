package model;

public class PathDTO {
    private String firstFilePath;
    private String secondFilePath;

    //Getter 메소드
    public String getFirstFilePath() {
        return firstFilePath;
    }
    public String getSecondFilePath() {
        return secondFilePath;
    }

    // Setter 메서드
    public void setFirstFilePath(String firstFilePath) {
        this.firstFilePath = firstFilePath;
    }

    public void setSecondFilePath(String secondFilePath) {
        this.secondFilePath = secondFilePath;
    }

}
