package controller;

import view.CalculatorFrame;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.math.BigDecimal;

public class ButtonEvent{

    public CalculatorFrame calculatorFrame;
    public ButtonEvent(CalculatorFrame calculatorFrame){  //생성자에서 Frame 객체의 필드값 수정하기 위해 가져오기
        this.calculatorFrame = calculatorFrame;
    }

    //1. 숫자 버튼 클릭 시 처리하는 ActionListener
    public class NumberButtonEventListenerClass implements ActionListener{
        public void actionPerformed(ActionEvent e){
            JButton numberButton = (JButton)e.getSource(); //버튼 가져오기

            if(calculatorFrame.isEqualExist){ // 이전에 equal이 입력 되었을 경우
                calculatorFrame.savedNumber= "";
                calculatorFrame.number1 = "0";
                calculatorFrame.number2 = "";
                calculatorFrame.operator = ""; //입력 받은 연산자
                calculatorFrame.isEqualExist = false;
                calculatorFrame.preNumberLabel.setText("");
            }

            if(calculatorFrame.operator == "") { //연산자가 없을 때 숫자1 입력 받기
                calculatorFrame.number1 += numberButton.getText();//버튼에 대응하는 숫자
                calculatorFrame.number1 = removeUnnecessaryZero(calculatorFrame.number1);
                printNumber(calculatorFrame.number1);
            }
            else{ // 연산자가 있을 때 숫자2 입력받기
                calculatorFrame.number2 += numberButton.getText();//버튼에 대응하는 숫자
                calculatorFrame.number2 = removeUnnecessaryZero(calculatorFrame.number2);
                clearInputNumber(); //입력창에 뜬 숫자1 지우기
                printNumber(calculatorFrame.number2);
            }
            saveNumber1ToSavedNumber(calculatorFrame.number1);
        }
        public void printNumber(String number){
            if(calculatorFrame.numberInputLabel.getText() == "0"){
                clearInputNumber();
            }
            calculatorFrame.numberInputLabel.setText(number); //누른 버튼의 숫자 출력
        }
        public void clearInputNumber(){
            calculatorFrame.numberInputLabel.setText("");
        }
        public String removeUnnecessaryZero(String number){ //string 값으로 저장된 숫자 중에 맨앞이나 맨뒤에 불필요한 0을 삭제해주기 위한 함수
            // string > Big Decimal > string 으로 바꿔준다

            BigDecimal bigDecimalNumber = new BigDecimal(number);
            number = bigDecimalNumber.toString();
            return number;
        }
    }

    //2. 연산자 버튼 클릭 시 처리하는 ActionListener
    public class OperatorButtonEventListenerClass implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            JButton operatorButton = (JButton) e.getSource(); //버튼 가져오기
            String operator = operatorButton.getText();

            //앞서 연산자가 없는 경우 연산자 추가
            if(calculatorFrame.operator == "") {
                calculatorFrame.operator = operator;
                printExpression(calculatorFrame.operator);
            }
            else{ // 앞서 연산자가 있는경우 또 연산자가 나왔을때
                if(calculatorFrame.number2 == ""){ //숫자2가 안나왔을때 > 즉, 숫자1 나오고 연산자가 두번 이상 연속으로 나왔을 경우
                    //연산자 교체
                    calculatorFrame.operator = operator;
                    printExpression(calculatorFrame.operator);
                }
                else{ //앞서 숫자1, 연산자, 숫자2 가 나왔고 현재 연산자 버튼을 눌렀을 경우 > 앞의 수식의 계산을 진행
                    calculateNumbers(calculatorFrame.operator); // 기존의 연산자로 계산을 진행
                    calculatorFrame.number2 = ""; //숫자2 초기화
                    calculatorFrame.operator = operator; //계산이 끝난 후 새로 입력받은 연산자를 입력
                    printExpression(calculatorFrame.operator);
                }
            }
            saveNumber1ToSavedNumber(calculatorFrame.number1);
        }
    }

    //3. Equal 버튼 클릭시 처리하는 ActionListener
    public class EqualButtonEventListenerClass implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            //equal값 들어왔는지 확인하는 변수
            calculatorFrame.isEqualExist = true;

            if(calculatorFrame.operator == ""){ //앞서 연산자가 나오지 않은 경우 > 숫자2도 없다.
                printExpression("=");
                //로그에 추가하기
            }
            else{ //앞서 연산자가 나온 경우
                if(calculatorFrame.number2 == ""){ //숫자2가 나오지 않은 경우 (예: 1+=) > 자기 복제
                    calculatorFrame.number2 = calculatorFrame.savedNumber;
                    calculatorFrame.preNumberLabel.setText("");
                    calculatorFrame.preNumberLabel.setText(calculatorFrame.number1 + calculatorFrame.operator + calculatorFrame.savedNumber + "=");

                    //계산
                    calculateNumbers(calculatorFrame.operator);
                    calculatorFrame.numberInputLabel.setText("");
                    calculatorFrame.numberInputLabel.setText(calculatorFrame.number1);
                    calculatorFrame.number2 = "";
                }

                else{ // 숫자1, 연산자, 숫자2 그리고 현재 등호가 나온 경우 > 정상 계산 후 초기화
                    //히스토리 창 출력
                    calculatorFrame.preNumberLabel.setText("");
                    calculatorFrame.preNumberLabel.setText(calculatorFrame.number1 + calculatorFrame.operator + calculatorFrame.number2 + "=");
                    //수식 계산
                    calculateNumbers(calculatorFrame.operator);
                    //입력 창 출력
                    calculatorFrame.numberInputLabel.setText("");
                    calculatorFrame.numberInputLabel.setText(calculatorFrame.number1);

                    saveNumber1ToSavedNumber(calculatorFrame.number1);
                }
            }
        }
    }

    //4. C버튼 눌렀을 때 이벤트 처리 > 모두 초기화
    public class ClearButtonEventListenerClass implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            //모든 변수 초기화
            calculatorFrame.savedNumber= "";
            calculatorFrame.number1 = "0";
            calculatorFrame.number2 = "";
            calculatorFrame.operator = ""; //입력 받은 연산자
            calculatorFrame.isEqualExist = false;

            //출력 창 초기화
            calculatorFrame.preNumberLabel.setText("");
            calculatorFrame.numberInputLabel.setText("");
        }
    }

    public void printExpression(String operator){
        calculatorFrame.preNumberLabel.setText("");
        calculatorFrame.preNumberLabel.setText(calculatorFrame.number1 + operator);
    }

    public void calculateNumbers(String operator){ //연산 함수
        BigDecimal bigDecimalNumber1 = new BigDecimal(calculatorFrame.number1);
        BigDecimal bigDecimalNumber2 = new BigDecimal(calculatorFrame.number2);

        switch (operator){
            case "+":
                calculatorFrame.number1 = (bigDecimalNumber1.add(bigDecimalNumber2)).toString() ;
                break;
            case "-":
                calculatorFrame.number1 = (bigDecimalNumber1.subtract(bigDecimalNumber2)).toString() ;
                break;
            case "x":
                calculatorFrame.number1 = (bigDecimalNumber1.multiply(bigDecimalNumber2)).toString() ;
                break;
            case "÷":
                calculatorFrame.number1 = (bigDecimalNumber1.divide(bigDecimalNumber2)).toString() ;
                break;
        }
    }

    public void saveNumber1ToSavedNumber(String number1){
        //모든 버튼 이벤트가 끝날때마다 현재 calculatorFrame.number1를 저장하기
        calculatorFrame.savedNumber = number1;
    }






}
