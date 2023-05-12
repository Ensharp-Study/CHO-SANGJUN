
package swing;

import Utility.KakaoRESTAPI;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
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
        this.add(SearchMainPanelProduce());
        setVisible(true);
    }

    public JPanel SearchMainPanelProduce() {
        JPanel searchMainPanel = new JPanel() { //패널 생성과 동시에 배경 채우기
            Image background = new ImageIcon(MainFrame.class.getResource("image/Wallpapers.jpeg")).getImage();
            public void paintComponent(Graphics g) {//그리는 함수
                super.paintComponent(g);
                g.drawImage(background, 0, 0, getWidth(), getHeight(), this);//background를 그려줌
            }
        };
        searchMainPanel.setLayout(new FlowLayout(FlowLayout.CENTER, 10, 30));
        searchMainPanel.setSize(800, 500); //원하는 크기로 설정

        //검색 입력 안내문
        JLabel inputNotice = new JLabel("검색어 입력");
        inputNotice.setSize(100,30);
        searchMainPanel.add(inputNotice);

        //검색 입력 textField 선언 및 panel에 추가
        JTextField textField = new JTextField();
        textField.setPreferredSize(new Dimension(100, 30));
        searchMainPanel.add(textField);

        //검색 버튼 추가
        JButton searchButton = new JButton("검색");


        //버튼 키 이벤트 추가
        searchButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (e.getSource() == searchButton) {
                    //버튼 눌렀을 때 이벤트 처리
                    MainFrame.add(AfterSearchPanel());
                }
            }
        });

        searchMainPanel.add(searchButton);
        return searchMainPanel;
    }


    public JPanel AfterSearchPanel(){
        JPanel afterSearchPanel = new JPanel();
        afterSearchPanel.setLayout(new FlowLayout());

        String[] imageURL  = kakaoRESTAPI.ConnectionHTTP(); //카카오 API에서 이미지 불러오기
        JLabel imageLabel = new JLabel();

        for(int i=0; i<2; i++){
            imageLabel = ImageProduceByURL(imageURL[i]);
            imageLabel.setSize(100, 100);
            afterSearchPanel.add(imageLabel);
        }

        return afterSearchPanel;
    }


    public JLabel ImageProduceByLocalFile(String path){
        JLabel ImageLabel = new JLabel(); //이미지 출력할 라벨 설정
        ImageIcon icon = new ImageIcon(MainFrame.class.getResource(path));
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

}



