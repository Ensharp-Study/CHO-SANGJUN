package View;

import javax.swing.*;
import java.awt.*;

public class CalculatorFrame extends JFrame {

    //프레임 위에 올릴 basePanel과 basePanel에 올라갈 두개의 패널
    Panel basePanel = new Panel(new BorderLayout());
    Panel inputPanel = new Panel(new GridLayout(2, 1));
    Panel buttonPanel = new Panel(new GridLayout(5, 4, 0, 0));

    //inputPanel의 Components
    JTextArea preNumberTextArea = new JTextArea();
    JTextArea numberInputTextArea = new JTextArea();

    //buttonPanel의 Components
    String[] buttonTitle = {"clearEntry", "clear", "backSpace", "division", "multiplication", "subtractaction", "addtion", "equal", "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "period", "plusAndMinus"};
    JButton[] calculabuttons = new JButton[20];
    JButton period = new JButton();
    JButton plusAndMinus = new JButton();

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
            buttonPanel.add(calculabuttons[i]);
        }

        // 두개의 패널을 base 패널에 올리기
        basePanel.add(inputPanel, BorderLayout.NORTH);
        basePanel.add(buttonPanel, BorderLayout.SOUTH);
    }
}



