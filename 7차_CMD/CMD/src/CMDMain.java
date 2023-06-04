import controller.CMDStart;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.List;

public class CMDMain {
    public static void main(String[] args) {
        CMDStart cmdStart = new CMDStart();
        cmdStart.startCMD();
    }
}