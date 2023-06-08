package controller.buttonEvent;

import view.frames.LoginFrame;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class LoginPanelOpenButtonEvent implements ActionListener {
    public void actionPerformed(ActionEvent e) {
        new LoginFrame();
    }
}
