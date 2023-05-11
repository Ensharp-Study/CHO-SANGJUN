
package swing;

import javax.swing.*;
import java.awt.*;

public class MainFrame extends JFrame {

    Container startMenuContainer;
    public MainFrame(String[] imageURL ) {
        setTitle("사진 검색 프로그램");
        setSize(800, 500);
        setLocationRelativeTo(null);// 창이 가운데에 나오게 설정
        setResizable(false); //사이즈 조절 불가능
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        this.startMenuContainer = getContentPane();
        MainImageProduce();
        SearchField();
        this.add(startMenuContainer);
        setVisible(true);
    }

    public void MainImageProduce() {
        startMenuContainer.setLayout(null);

        JLabel mainImageLabel = new JLabel(); //이미지 출력할 라벨 설정

        ImageIcon mainImageIcon = new ImageIcon(MainFrame.class.getResource("/swing/Image/Kakao Friends Screen Golf.png"));
        Image img = mainImageIcon.getImage();
        Image updateImg = img.getScaledInstance(200, 200, Image.SCALE_SMOOTH);
        ImageIcon updateIcon = new ImageIcon(updateImg);

        mainImageLabel.setIcon(updateIcon);

        mainImageLabel.setBounds(180, 30, 500, 500);
        mainImageLabel.setHorizontalAlignment(JLabel.CENTER); // 가운데 정렬
        startMenuContainer.add(mainImageLabel);

    }

    public void SearchField() {
        startMenuContainer.setLayout(null);

        JTextField textField = new JTextField();
        textField.setSize(30, 30);
        textField.setLocation(100, 100);
        startMenuContainer.add(textField);
    }

}



