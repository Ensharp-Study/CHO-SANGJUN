package controller.commandFunction;

import utility.Constants;
import view.CMDUI;

public class CommonLanguageSpecificationCommand { // cls 명령어
    public CMDUI cmdui;
    public CommonLanguageSpecificationCommand(){
        this.cmdui = CMDUI.getInstance();
    }

    public void clearAll(){
        System.out.println(Constants.CLEAR_SCREEN);
    }
}
