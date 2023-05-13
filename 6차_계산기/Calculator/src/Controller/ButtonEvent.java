package Controller;

import View.CalculatorFrame;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ButtonEvent extends JFrame{
    public CalculatorFrame calculatorFrame;
    public ButtonEvent(CalculatorFrame calculatorFrame){  //생성자에서 Frame 객체의 필드값 수정하기 위해 가져오기
        this.calculatorFrame = calculatorFrame;
    }

    //1. 숫자 버튼 클릭 시 처리하는 ActionListener
    public class NumberButtonEventListenerClass implements ActionListener{
        public void actionPerformed(ActionEvent e){
            JButton numberButton = (JButton)e.getSource(); //버튼 가져오기
            String number = numberButton.getText();
            if(calculatorFrame.numberInputTextArea.getText() == "0"){ //초기 입력창이 0값이면
                calculatorFrame.numberInputTextArea.setText(""); //0 지워주기
            }
            setNumber(numberButton.getText()); //입력 버튼 숫자 출력
        }
        public void setNumber(String Number){
            calculatorFrame.numberInputTextArea.append(Number); //누른 버튼의 숫자 출력
        }
    }

    //2. 연산자 버튼 클릭 시 처리하는 ActionListener
    public class OperatorButtonEventListenerClass implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            JButton operatorButton = (JButton) e.getSource(); //버튼 가져오기
            String operator = operatorButton.getText();

            if(!(calculatorFrame.numberInputTextArea.getText().equals("0"))){ //초기 입력창이 0값이면 연산기호 출력 안하기
                setOperator(operator); //입력 버튼 연산자 출력
            }
        }
        public void setOperator(String operator){
            calculatorFrame.numberInputTextArea.append(operator); //누른 버튼의 연산자 출력
        }
    }

}
