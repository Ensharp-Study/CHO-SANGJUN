package view.panels;

import view.component.ComponentCreator;
import model.LoginPanelComponentDTO;

import javax.swing.*;
import java.awt.*;

public class LoginPanel extends JPanel{
    private ComponentCreator componentCreator;
    private LoginPanelComponentDTO loginPanelComponentDTO;

    //LoginPanel view.component
    private JButton loginButton;
    private JTextField userIDInputField;
    private JPasswordField userPasswordInputField;

    public LoginPanel(){
        this.componentCreator = ComponentCreator.getInstance();
        setLoginPanel();
    }

    private void setLoginPanel(){
        this.setLayout(null);
        this.setBounds(150,450,600,100);
        this.setBackground(new Color(255,255,255,120));
        //loginPanel위에 컴포넌트 올리기
        addComponentOnLoginPanel();

    }
    private void addComponentOnLoginPanel(){
        loginPanelComponentDTO = componentCreator.createLoginPanelComponent();
        add(loginPanelComponentDTO.getLoginButton());
        add(loginPanelComponentDTO.getUserIDInputField());
        add(loginPanelComponentDTO.getUserPasswordInputField());
    }

}
