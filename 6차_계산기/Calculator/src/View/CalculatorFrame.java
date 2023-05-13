package View;

import Controller.ButtonEvent;

import javax.swing.*;
import java.awt.*;

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
    public JButton period = new JButton();
    public JButton plusAndMinus = new JButton();

    public CalculatorFrame() {
        setTitle("계산기");
        setSize(324, 534);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        composeBasePanel(); //패널 구성
        add(basePanel); //base 패널 Frame 위에 올리기
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
            //1. 숫자버튼인 경우
            if((i == 4) || (i == 5) ||(i == 6) ||(i == 8) ||(i == 9) ||(i == 10) ||(i == 12) ||(i == 13) ||(i == 14) ||(i == 17)){
                calculabuttons[i].addActionListener((new ButtonEvent(this)).new NumberButtonEventListenerClass());
            }
            //2. 연산자버튼인 경우
            else{
                calculabuttons[i].addActionListener(new ButtonEvent((this)).new OperatorButtonEventListenerClass());
            }

            //버튼패널 위에 버튼 올리기
            buttonPanel.add(calculabuttons[i]);
        }



        // 두개의 패널을 base 패널에 올리기
        basePanel.add(inputPanel, BorderLayout.NORTH);
        basePanel.add(buttonPanel, BorderLayout.SOUTH);
    }
}



