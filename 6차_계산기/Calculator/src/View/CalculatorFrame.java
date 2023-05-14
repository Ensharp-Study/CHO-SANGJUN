package View;

import Controller.ButtonEvent;

import javax.swing.*;
import java.awt.*;
import java.util.*;

public class CalculatorFrame extends JFrame {

    //프레임 위에 올릴 basePanel과 basePanel에 올라갈 두개의 패널
    public Panel basePanel = new Panel(new BorderLayout());
    public Panel inputPanel = new Panel(new GridLayout(2, 1));
    public Panel buttonPanel = new Panel(new GridLayout(5, 4, 0, 0));

    //inputPanel의 Components
    public JTextArea preNumberTextArea = new JTextArea();
    public JTextArea numberInputTextArea = new JTextArea("0");

    //buttonPanel의 Components
    public String[] buttonTitle = {"CE", "C", "←", "÷", "7", "8", "9", "x", "4", "5", "6", "-", "1", "2", "3", "+", "±", "0", ".", "="};
    public JButton[] calculabuttons = new JButton[20];

    //버튼 클릭에 대한 ActionListener 클래스 인스턴스 생성
    ButtonEvent buttonEvent;
    ButtonEvent.NumberButtonEventListenerClass numberButtonEventListenerClass;
    ButtonEvent.OperatorButtonEventListenerClass operatorButtonEventListenerClass;
    ButtonEvent.EqualButtonEventListenerClass equalButtonEventListenerClass;
    ButtonEvent.ClearButtonEventListenerClass clearButtonEventListenerClass;
    //계산시 사용하는 변수들 선언
    public Double savedNumber = 0.0; //이전까지 계산된 합계 (초기값 0)
    public Double number = null;
    public String operator = ""; //입력 받은 연산자


    public CalculatorFrame() { //생성자
        setTitle("계산기");
        setSize(324, 534);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        composeBasePanel(); //패널 구성
        add(basePanel); //base 패널 Frame 위에 올리기

        //버튼에 대한 리스너 객체 생성하기 (이렇게 생성해서 쓰면 왜 안되는지)
        this.buttonEvent = new ButtonEvent(this);
        this.numberButtonEventListenerClass = buttonEvent.new NumberButtonEventListenerClass();
        this.operatorButtonEventListenerClass = buttonEvent.new OperatorButtonEventListenerClass();
        this.equalButtonEventListenerClass = buttonEvent.new EqualButtonEventListenerClass();
        this.clearButtonEventListenerClass = buttonEvent.new ClearButtonEventListenerClass();
        setVisible(true);
    }

    public void composeBasePanel() { //패널 구성 후 base 패널에 최종적으로 올리기
        basePanel.setPreferredSize(new Dimension(324, 534));
        inputPanel.setPreferredSize(new Dimension(324, 200));
        buttonPanel.setPreferredSize(new Dimension(324, 305));

        //1. 상단부 숫자 입력 패널 구성
        inputPanel.add(preNumberTextArea);
        inputPanel.add(numberInputTextArea);

        //2. 하단부 버튼 패널 구성
        for (int i = 0; i < 20; i++) {
            calculabuttons[i] = new JButton(buttonTitle[i]);

            //버튼에 ActionListener 할당
            //1. 숫자버튼인 경우 (위에서 미리 객체 생성한거 쓰면 안되는 이유?)
            if((i == 4) || (i == 5) ||(i == 6) ||(i == 8) ||(i == 9) ||(i == 10) ||(i == 12) ||(i == 13) ||(i == 14) ||(i == 17)){
                calculabuttons[i].addActionListener((new ButtonEvent(this)).new NumberButtonEventListenerClass());
            }
            //2. 연산자버튼인 경우
            else if((i == 3) ||(i == 7) ||(i == 11) ||(i == 15) ){
                calculabuttons[i].addActionListener((new ButtonEvent(this)).new OperatorButtonEventListenerClass());
            }
            //3. Equal버튼인 경우
            else if(i == 19){
                calculabuttons[i].addActionListener((new ButtonEvent(this)).new EqualButtonEventListenerClass());
            }
            //4. CLEAR 버튼인 경우
            else if(i == 1){
                calculabuttons[i].addActionListener((new ButtonEvent(this)).new ClearButtonEventListenerClass());
            }

            //버튼패널 위에 버튼 올리기
            buttonPanel.add(calculabuttons[i]);
        }

        // 두개의 패널을 base 패널에 올리기
        basePanel.add(inputPanel, BorderLayout.NORTH);
        basePanel.add(buttonPanel, BorderLayout.SOUTH);
    }
}



