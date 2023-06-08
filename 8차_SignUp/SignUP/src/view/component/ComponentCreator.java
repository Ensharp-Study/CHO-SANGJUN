package view.component;

import controller.buttonEvent.LoginPanelOpenButtonEvent;
import model.LoginPanelComponentDTO;
import utility.Constants;

import javax.swing.*;
import java.awt.*;

public class ComponentCreator {
    //싱글턴 처리
    private static ComponentCreator instance = new ComponentCreator();
    private ComponentCreator() {}
    public static ComponentCreator getInstance() {
        return instance;
    }

    //Panel클래스로 보낼 컨포넌트 DTO
    LoginPanelComponentDTO loginPanelComponentDTO;
    //버튼 이벤트
    LoginPanelOpenButtonEvent loginPanelOpenButtonEvent;

    //MainPanel Component
    private JButton loginPanelOpenButton;
    //LoginPanel component
    private JButton loginButton;
    private JTextField userIDInputField;
    private JPasswordField userPasswordInputField;


    //MainPanel Component 생성
    public JButton createMainPanelComponent(){
        loginPanelOpenButton = new JButton();
        loginPanelOpenButton.setBounds(420,600,350,135); //버튼 사이즈 지정

        //버튼에 이미지 처리
        loginPanelOpenButton = putImageOnButton(Constants.loginPanelOpenButtonBaseImagePath, Constants.loginPanelOpenButtonHoverImagePath, loginPanelOpenButton,loginPanelOpenButton.getWidth(),loginPanelOpenButton.getHeight());

        //버튼에 이벤트 처리
        loginPanelOpenButtonEvent = new LoginPanelOpenButtonEvent();
        loginPanelOpenButton.addActionListener(loginPanelOpenButtonEvent);
        return loginPanelOpenButton;
    }

    //LoginPanel Component 생성
    public LoginPanelComponentDTO createLoginPanelComponent(){
        loginPanelComponentDTO = new LoginPanelComponentDTO();

        loginButton = new JButton();
        userIDInputField = new JTextField();
        userPasswordInputField = new JPasswordField();

        loginPanelComponentDTO.setLoginButton(loginButton);
        loginPanelComponentDTO.setUserIDInputField(userIDInputField);
        loginPanelComponentDTO.setUserPasswordInputField(userPasswordInputField);

        return loginPanelComponentDTO;
    }

    private JButton putImageOnButton(String imageBasePath, String imageHoverPath , JButton button, int buttonWidth, int buttonHeight){
        //버튼 기본 UI값들 삭제
        button.setBorderPainted(false);
        button.setFocusPainted(false);
        button.setFocusable(false);
        button.setContentAreaFilled(false);

        //이미지 아이콘 생성
        ImageIcon baseImage = new ImageIcon(ComponentCreator.class.getResource(imageBasePath));
        ImageIcon hoverImage = new ImageIcon(ComponentCreator.class.getResource(imageHoverPath));
        //이미지 사이즈 변경
        Image resizedBaseImage = baseImage.getImage().getScaledInstance(buttonWidth,buttonHeight,Image.SCALE_SMOOTH);
        Image resizedHoverImage = hoverImage.getImage().getScaledInstance(buttonWidth,buttonHeight,Image.SCALE_SMOOTH);
        //사이즈 변경된 이미지 다시 아이콘으로 변환
        baseImage = new ImageIcon(resizedBaseImage);
        hoverImage = new ImageIcon(resizedHoverImage);

        //버튼에 이미지 올리기 및 호버처리
        button.setIcon(baseImage);
        button.setRolloverIcon(hoverImage);

        return button;
    }
}
