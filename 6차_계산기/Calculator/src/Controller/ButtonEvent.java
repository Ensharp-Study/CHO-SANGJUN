package Controller;

import View.CalculatorFrame;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Stack;

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

            //앞서 operate가 없는 경우. 즉, 숫자1 입력 받는 경우
            else{
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

    //3. Equal 버튼 클릭시 처리하는 ActionListener
    public class EqualButtonEventListenerClass implements ActionListener {
        String itselfNumber; // 연산자 이후 바로 =가 들어올 경우 자기 자신의 숫자를 저장해둘 변수
        public void actionPerformed(ActionEvent e) {
            JButton equalButton = (JButton) e.getSource(); //버튼 가져오기
            String equal = equalButton.getText();

            //숫자 1만 들어가 있는 경우 (초기 아무 버튼도 누르자 않았을 경우 숫자1 은 0값이다.)
            if ((calculatorFrame.number == null) && (calculatorFrame.operator.equals(""))) {
                // 로그만 추가
            }
            //숫자 1과 연산자만 들어가 있는 경우 > 자기 자신과 같은 값과 연산
            else if((calculatorFrame.number == null) && !(calculatorFrame.operator.equals(""))){
                Double numberItself = calculatorFrame.savedNumber;
                calculatorFrame.preNumberTextArea.setText("");
                calculatorFrame.preNumberTextArea.setText(Double.toString(calculatorFrame.savedNumber) + calculatorFrame.operator + Double.toString(numberItself) + "=");
                calculateNumbers(calculatorFrame.operator, numberItself);
                calculatorFrame.numberInputTextArea.setText("");
                calculatorFrame.numberInputTextArea.setText(Double.toString(calculatorFrame.savedNumber));
            }
            // 숫자 1과 연산자 그리고 숫자2 까지 모두 들어가 있는경우 > 연산이 가능하다.
            else if((calculatorFrame.number != null) && !(calculatorFrame.operator.equals(""))){
                calculatorFrame.preNumberTextArea.setText("");
                calculatorFrame.preNumberTextArea.setText(Double.toString(calculatorFrame.savedNumber) + calculatorFrame.operator + Double.toString(calculatorFrame.number) + "=");
                calculateNumbers(calculatorFrame.operator, calculatorFrame.number);
                calculatorFrame.number = null;
                calculatorFrame.operator =""; // 연산 수행 완료 후 number 값과 연산자 값 초기화
                calculatorFrame.numberInputTextArea.setText("");
                calculatorFrame.numberInputTextArea.setText(Double.toString(calculatorFrame.savedNumber));
            }

        }
    }

    public void calculateNumbers(String operator, Double number){ //연산 함수
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
