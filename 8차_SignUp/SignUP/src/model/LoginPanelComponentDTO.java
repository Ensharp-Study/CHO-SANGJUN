package model;

import javax.swing.*;

public class LoginPanelComponentDTO {
    private JButton loginButton;
    private JTextField userIDInputField;
    private JPasswordField userPasswordInputField;

    //getter
    public JButton getLoginButton(){
        return loginButton;
    }
    public JTextField getUserIDInputField(){
        return userIDInputField;
    }
    public JPasswordField getUserPasswordInputField(){
        return userPasswordInputField;
    }

    //setter
    public void setLoginButton(JButton loginButton){
        this.loginButton = loginButton;
    }
    public void setUserIDInputField(JTextField userIDInputField){
        this.userIDInputField = userIDInputField;
    }
    public void setUserPasswordInputField(JPasswordField userPasswordInputField){
        this.userPasswordInputField = userPasswordInputField;
    }
}
