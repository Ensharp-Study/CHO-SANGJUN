package view.frames;

import view.panels.LoginBasePanel;
import view.panels.MainPanel;

import javax.swing.*;
import java.awt.*;

public class LoginFrame extends JFrame {

    private LoginBasePanel loginBasePanel;

    public LoginFrame(){
        setLoginFrame(); //프레임 생성
        addPanelOnFrame(); //프레임 위에 패널 올리기
        setVisible(true);
    }
    private void setLoginFrame(){
        setSize(450,600);
        setTitle("로그인");
        setLayout(null);
        setLocationRelativeTo(null);
        setResizable(false);
        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE); //해당 프레임만 닫기
    }

    private void addPanelOnFrame(){
        loginBasePanel = new LoginBasePanel();
        this.add(loginBasePanel);
    }
}
