import controller.CMDStart;

import java.io.File;
import java.nio.file.FileStore;
import java.nio.file.FileSystems;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class CMDMain {
    public static void main(String[] args) {
        CMDStart cmdStart = new CMDStart();
        cmdStart.startCMD();
    }
}