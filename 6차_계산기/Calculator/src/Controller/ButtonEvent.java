package Controller;

import View.CalculatorFrame;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ButtonEvent{

    public CalculatorFrame calculatorFrame;
    public ButtonEvent(CalculatorFrame calculatorFrame){  //생성자에서 Frame 객체의 필드값 수정하기 위해 가져오기
        this.calculatorFrame = calculatorFrame;
    }

    //1. 숫자 버튼 클릭 시 처리하는 ActionListener
    public class NumberButtonEventListenerClass implements ActionListener{
        public void actionPerformed(ActionEvent e){
            JButton numberButton = (JButton)e.getSource(); //버튼 가져오기
            String number = numberButton.getText();//버튼에 대응하는 숫자

            //초기 입력창이 0값이면 0 지워주기
            if(calculatorFrame.numberInputTextArea.getText().equals("0")){
                calculatorFrame.numberInputTextArea.setText("");
            }

            //앞서 operator가 입력이 되었으면
            if( !(calculatorFrame.operator.equals("")) ) {
                //숫자1 + 연산자 + 숫자2 중 숫자2까지도 입력되었을 경우 > 숫자2 뒤에 덧붙인다.
                if ( calculatorFrame.number != null ){
                    String formatNumber = String.format( Double.toString(calculatorFrame.number), number);
                    calculatorFrame.number = Double.parseDouble(formatNumber);
                    printNumber(number);
                }
                //연산자까지 만 입력되고 숫자2가 입력 되지 않았을 경우
                else{
                    calculatorFrame.numberInputTextArea.setText("");
                    printNumber(number);
                    calculatorFrame.number = Double.parseDouble(number);
                }
            }

            else{ //맨처음 숫자1을 입력받을 경우
                //숫자1이 입력 되어 있지 않을 경우
                if ( calculatorFrame.savedNumber.equals(0.0) ){
                    calculatorFrame.savedNumber = Double.parseDouble(number);
                    printNumber(number);
                }
                //연산자까지만 입력되고 숫자2가 입력 되지 않았을 경우
                else{
                    String formatNumber = String.format( Double.toString(calculatorFrame.savedNumber), number);
                    calculatorFrame.savedNumber = Double.parseDouble(formatNumber);
                    printNumber(number);
                }
            }

        }
        public void printNumber(String Number){
            calculatorFrame.numberInputTextArea.append(Number); //누른 버튼의 숫자 출력
        }
    }

    //2. 연산자 버튼 클릭 시 처리하는 ActionListener
    public class OperatorButtonEventListenerClass implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            JButton operatorButton = (JButton) e.getSource(); //버튼 가져오기
            String operator = operatorButton.getText();

            //연산자가 입력 되면 앞서 입력된 숫자는

            //앞서 연산자와 두가지 숫자가 모두 입력 되었을 경우 연산진행 (즉, 앞서 숫자 + 연산자 + 숫자가 작성되어 있었고 방금 연산자가 입력된 경우)
            if( (!(calculatorFrame.operator.equals(""))) && (calculatorFrame.number != null ) ){
                calculateNumbers(calculatorFrame.operator, calculatorFrame.number);
                //연산 결과 값 및 다음 입력 연산자 출력
                calculatorFrame.preNumberTextArea.setText( Double.toString(calculatorFrame.savedNumber) + operator);
                calculatorFrame.operator = operator;
                calculatorFrame.number = null;
            }

            //연산을 수행 하지 못하는 경우 ( 즉, 앞서 숫자만 입력 되어 있었고 방금 연산자가 입력된 경우)
            else{
                calculatorFrame.preNumberTextArea.setText(Double.toString(calculatorFrame.savedNumber) + operator);
                calculatorFrame.operator = operator;
            }

        }
    }
    public void calculateNumbers(String operator, Double number){
        switch (operator){
            case "+":
                calculatorFrame.savedNumber += number;
                break;
            case "-":
                calculatorFrame.savedNumber -= number;
                break;
            case "x":
                calculatorFrame.savedNumber *= number;
                break;
            case "÷":
                calculatorFrame.savedNumber /= number;
                break;

        }
    }

}
