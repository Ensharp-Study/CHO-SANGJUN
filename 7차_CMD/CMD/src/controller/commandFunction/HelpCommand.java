package controller.commandFunction;

import utility.Constants;
import view.CMDUI;

public class HelpCommand {
    public CMDUI cmdui;
    public HelpCommand(){
        this.cmdui = CMDUI.getInstance();
    }

    public void printHelpPhrase(){
        cmdui.printNotice(Constants.HELP_NOTICE);
    }

}
