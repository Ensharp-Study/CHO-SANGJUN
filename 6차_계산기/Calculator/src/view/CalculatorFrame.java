package view;

import controller.ButtonEvent;
import controller.KeyEvent;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;

public class CalculatorFrame extends JFrame {

    //프레임 위에 올릴 입력창 패널과 버튼패널 그리고 로그 패널 생성
    public Panel basePanel =new Panel(new GridBagLayout());
    public Panel inputPanel = new Panel(new GridLayout(2, 1));
    public Panel buttonPanel = new Panel(new GridLayout(5, 4, 0, 0));
    //public Panel LogPanel = new Panel(new )

    //inputPanel의 Components
    public JLabel preNumberLabel = new JLabel();
    public JLabel numberInputLabel = new JLabel("0");

    //buttonPanel의 Components
    public String[] buttonTitle = {"CE", "C", "←", "÷", "7", "8", "9", "x", "4", "5", "6", "-", "1", "2", "3", "+", "±", "0", ".", "="};
    public JButton[] calculatebuttons = new JButton[20];

    //계산시 사용하는 변수들 선언
    public Double savedNumber = 0.0; //이전까지 계산된 합계 (초기값 0)
    public Double number = null;
    public String operator = ""; //입력 받은 연산자

    //버튼 클릭에 대한 ActionListener 클래스 인스턴스 생성
    ButtonEvent buttonEvent;
    ButtonEvent.NumberButtonEventListenerClass numberButtonEventListenerClass;
    ButtonEvent.OperatorButtonEventListenerClass operatorButtonEventListenerClass;
    ButtonEvent.EqualButtonEventListenerClass equalButtonEventListenerClass;
    ButtonEvent.ClearButtonEventListenerClass clearButtonEventListenerClass;

    //키 입력에 대한 ActionListener 클래스 인스턴스 생성
    java.awt.event.KeyEvent keyEvent;
    KeyEvent.KeyInputListener keyInputListener;


    public CalculatorFrame() { //생성자
        setTitle("계산기");
        setSize(324, 534);
        setMinimumSize(new Dimension(324,534)); //최소 크기 지정
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        composeBasePanel(); //패널 구성
        add(basePanel); //base 패널 Frame 위에 올리기
        this.addKeyListener((new KeyEvent(this)).new KeyInputListener());
        this.setFocusable(true);

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
        //패널 사이즈는 1:2 비율
        inputPanel.setPreferredSize(new Dimension(324, 178));
        buttonPanel.setPreferredSize(new Dimension(324, 356));

        //1. 상단부 숫자 입력 패널 구성
        GridBagConstraints componentGridBagConstraints = new GridBagConstraints();
        componentGridBagConstraints.gridx = 0;
        componentGridBagConstraints.gridy = 0;
        componentGridBagConstraints.gridwidth = GridBagConstraints.REMAINDER;
        componentGridBagConstraints.gridheight = 1;
        componentGridBagConstraints.weightx = 1.0;
        componentGridBagConstraints.weighty = 0.1;
        componentGridBagConstraints.fill = GridBagConstraints.BOTH;

        //패널에 올라갈 JLabel 크기 및 폰트 설정
        preNumberLabel.setHorizontalAlignment(JLabel.RIGHT);
        preNumberLabel.setFont(new Font("나눔고딕", Font.PLAIN, 20));
        numberInputLabel.setHorizontalAlignment(JLabel.RIGHT);
        numberInputLabel.setFont(new Font("나눔고딕", Font.PLAIN, numberInputLabel.getHeight() * 3 / 4));
        //Frame을 키움에 따라 입력받은 숫자 JLabel의 사이즈도 함께 증가
        numberInputLabel.addComponentListener(new ComponentAdapter() {
            @Override
            public void componentResized(ComponentEvent e) {
                int fontSize = numberInputLabel.getHeight() * 3 / 4;
                numberInputLabel.setFont(new Font("나눔고딕", Font.BOLD, fontSize));
            }
        });
        // inputPanel 위에 컴포넌트 올리기
        inputPanel.add(preNumberLabel);
        inputPanel.add(numberInputLabel);

        basePanel.add(inputPanel, componentGridBagConstraints);


        //2. 하단부 버튼 패널 구성
        componentGridBagConstraints = new GridBagConstraints();
        componentGridBagConstraints.gridx = 0;
        componentGridBagConstraints.gridy = 1;
        componentGridBagConstraints.gridwidth = GridBagConstraints.REMAINDER;
        componentGridBagConstraints.gridheight = 2;
        componentGridBagConstraints.weightx = 1.0;
        componentGridBagConstraints.weighty = 0.2;
        componentGridBagConstraints.fill = GridBagConstraints.BOTH;

        for (int i = 0; i < 20; i++) {
            calculatebuttons[i] = new JButton(buttonTitle[i]);

            //버튼에 ActionListener 할당
            //1. 숫자버튼인 경우 (위에서 미리 객체 생성한거 쓰면 안되는 이유?)
            if((i == 4) || (i == 5) ||(i == 6) ||(i == 8) ||(i == 9) ||(i == 10) ||(i == 12) ||(i == 13) ||(i == 14) ||(i == 17)){
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new NumberButtonEventListenerClass());
            }
            //2. 연산자버튼인 경우
            else if((i == 3) ||(i == 7) ||(i == 11) ||(i == 15) ){
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new OperatorButtonEventListenerClass());
            }
            //3. Equal버튼인 경우
            else if(i == 19){
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new EqualButtonEventListenerClass());
            }
            //4. CLEAR 버튼인 경우
            else if(i == 1){
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new ClearButtonEventListenerClass());
            }

            //버튼패널 위에 버튼 올리기
            buttonPanel.add(calculatebuttons[i]);
        }
        basePanel.add(buttonPanel, componentGridBagConstraints);
    }

    public void composeLogPanel(){
        //창크기가 늘어났을때와 버튼 눌렀을때로 구분
    }
    

}



