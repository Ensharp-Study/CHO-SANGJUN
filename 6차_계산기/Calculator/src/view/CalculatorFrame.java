package view;

import controller.ButtonEvent;
import controller.KeyEvent;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.util.ArrayList;

public class CalculatorFrame extends JFrame {

    //프레임 위에 올릴 입력창 패널과 버튼패널 그리고 로그 패널 생성
    public Panel basePanel = new Panel();
    public Panel logButtonPanel = new Panel(new BorderLayout());
    public Panel inputPanel = new Panel(new GridLayout(2, 1, 0, 0));
    public Panel buttonPanel = new Panel(new GridLayout(5, 4, 0, 0));
    public Panel logPanel = new Panel(new FlowLayout());

    //logButtonPanel의 Components
    public JButton logButton = new JButton("기록");

    //inputPanel의 Components
    public JLabel preNumberLabel = new JLabel("");
    public JLabel numberInputLabel = new JLabel("0");

    //buttonPanel의 Components
    public String[] buttonTitle = {"CE", "C", "←", "÷", "7", "8", "9", "x", "4", "5", "6", "-", "1", "2", "3", "+", "±", "0", ".", "="};
    public JButton[] calculatebuttons = new JButton[20];

    //계산시 사용하는 변수들 선언
    public String savedNumber= "";
    public String firstNumber = "0";
    public String secondNumber = "";
    public String operator = ""; //입력 받은 연산자
    public Boolean isEqualExist = false;

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
        // 패널 레이아웃 설정
        basePanel.setLayout(new BoxLayout(basePanel,BoxLayout.Y_AXIS));

        //패널 사이즈 지정
        //base패널 내 3개의 패널 비율 설정
        Dimension frameSize = new Dimension(this.getWidth(), this.getHeight()); // frame 사이즈 불러오기
        basePanel.setPreferredSize(new Dimension(frameSize.width, frameSize.height)); //base프레임은 frame 사이즈와 동일하게 설정
        logButtonPanel.setPreferredSize(new Dimension(frameSize.width, (int)(frameSize.height * (1.0/12))));
        inputPanel.setPreferredSize(new Dimension(frameSize.width, (int)(frameSize.height * (3.0/12))));
        buttonPanel.setPreferredSize(new Dimension(frameSize.width, (int)(frameSize.height * (8.0/12))));

        //0. 로그버튼 패널 입력 구성
        logButtonPanel.add(logButton, BorderLayout.EAST);
        basePanel.add(logButtonPanel);

        //1. 상단부 숫자 입력 패널 구성
        //패널에 올라갈 JLabel 텍스트 정렬 설정
        preNumberLabel.setHorizontalAlignment(JLabel.RIGHT);
        numberInputLabel.setHorizontalAlignment(JLabel.RIGHT);

        //Frame을 키움에 따라 입력받은 숫자 JLabel의 사이즈도 함께 증가
        numberInputLabel.addComponentListener(new ComponentAdapter() {
            @Override
            public void componentResized(ComponentEvent e) {
                int fontSize = e.getComponent().getHeight() * 3 / 4; // 창의 높이를 이용한 폰트 크기 계산
                numberInputLabel.setFont(new Font("나눔고딕", Font.BOLD, fontSize));
            }
        });

        // inputPanel 위에 컴포넌트 올리기
        inputPanel.add(preNumberLabel);
        inputPanel.add(numberInputLabel);
        basePanel.add(inputPanel);

        //2. 하단부 버튼 패널 구성
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
                //버튼에 색깔 추가
                calculatebuttons[i].setBackground(new Color(140,231,237)); //색 설정
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new EqualButtonEventListenerClass());
            }
            //4. CLEAR 버튼인 경우
            else if(i == 1){
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new ClearButtonEventListenerClass());
            }
            //5. 소수점 버튼인 경우
            else if (i == 18){
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new DecimalPointButtonEventListenerClass());
            }
            //6.BackSpace 버튼인 경우
            else if (i == 2){
                calculatebuttons[i].addActionListener((new ButtonEvent(this)).new BackSpaceButtonEventListenerClass());
            }
            //7.ClearEntry 버튼인 경우
            else if (i == 0){

            }
            //8.PlusAndMinus 버튼인 경우
            else if (i == 16){

            }
            //버튼패널 위에 버튼 올리기
            buttonPanel.add(calculatebuttons[i]);
        }
        basePanel.add(buttonPanel);
    }

    public void composeLogPanel(){

        //로그창에 수식 및 결과값 저장할 리스트 생성
        ArrayList<String> expressions = new ArrayList<>();
        ArrayList<String> result = new ArrayList<>();
        JList expressionList = new JList();
        JList resultList = new JList();

        //창크기가 늘어났을때와 버튼 눌렀을때로 구분
        //1. 버튼 누르고 창이 커졌을 경우
    }


}



