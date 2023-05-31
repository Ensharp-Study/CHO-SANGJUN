package controller.commandFunction;

import view.CMDUI;

public class HelpCommand {
    public CMDUI cmdui;
    public HelpCommand(){
        this.cmdui = CMDUI.getInstance();
    }

    public void printHelpPhrase(){
        cmdui.printHelpNotice();
    }

}
