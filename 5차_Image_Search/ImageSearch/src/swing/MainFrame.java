
package swing;

import Utility.KakaoRESTAPI;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.io.IOException;
import java.net.URL;

public class MainFrame extends JFrame {
    KakaoRESTAPI kakaoRESTAPI;

    public MainFrame() {
        this.kakaoRESTAPI = new KakaoRESTAPI();

        setTitle("사진 검색 프로그램");
        setSize(800, 500);
        setLocationRelativeTo(null);// 창이 가운데에 나오게 설정
        setResizable(false); //사이즈 조절 불가능
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        this.add(FirstPanel());
        setVisible(true);
    }

    public JPanel FirstPanel(){
        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new FlowLayout());

        String[] imageURL  = kakaoRESTAPI.ConnectionHTTP(); //카카오 API에서 이미지 불러오기
        JLabel imageLabel = new JLabel();

        for(int i=0; i<2; i++){
            imageLabel = ImageProduceByURL(imageURL[i]);
            imageLabel.setSize(100, 100);
            mainPanel.add(imageLabel);
        }

        return mainPanel;
    }

    public JLabel ImageProduceByLocalFile(){
        JLabel ImageLabel = new JLabel(); //이미지 출력할 라벨 설정
        ImageIcon icon = new ImageIcon(MainFrame.class.getResource("/test/image/icon.png"));
        Image img = icon.getImage();

        Image updateImg = img.getScaledInstance(200, 200, Image.SCALE_SMOOTH);
        ImageIcon updateIcon = new ImageIcon(updateImg);

        ImageLabel.setIcon(updateIcon);
        ImageLabel.setBounds(180, 30, 500, 500);
        ImageLabel.setHorizontalAlignment(JLabel.CENTER); // 가운데 정렬

        return ImageLabel;
    }

    public JLabel ImageProduceByURL(String imageURL) {
        JLabel mainImageLabel = new JLabel(); //이미지 출력할 라벨 설정
        Image image = null;

        try {
            URL url = new URL(imageURL);
            image = ImageIO.read(url);
        } catch (IOException e) {
            e.printStackTrace();
        }

        Image updateImage = image.getScaledInstance(200, 200, Image.SCALE_SMOOTH);
        ImageIcon updateIcon = new ImageIcon(updateImage);

        mainImageLabel.setIcon(updateIcon);
        return mainImageLabel;
    }

    /*public void SearchField() {
        startMenuContainer.setLayout(null);

        JTextField textField = new JTextField();
        textField.setSize(30, 30);
        textField.setLocation(100, 100);
        startMenuContainer.add(textField);
    }*/



}



