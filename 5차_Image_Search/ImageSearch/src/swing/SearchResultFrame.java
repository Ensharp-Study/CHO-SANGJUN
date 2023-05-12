package swing;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.io.IOException;
import java.net.URL;

public class SearchResultFrame extends JFrame{
    public SearchResultFrame(String[] imageURL,String searchData){
        setTitle("사진 검색 프로그램");
        setSize(800, 500);
        setLocationRelativeTo(null);// 창이 가운데에 나오게 설정
        setResizable(false); //사이즈 조절 불가능
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.add(TotalPanelProduce(imageURL,searchData));

        setVisible(true);
    }
    public JPanel TotalPanelProduce(String[] imageURL,String searchData){
        JPanel TotalPanelProduce = new JPanel();
        TotalPanelProduce.setLayout(new BorderLayout());
        TotalPanelProduce.setPreferredSize(new Dimension(800,500));

        TotalPanelProduce.add(SearchResultNoticePanelProduce(searchData),BorderLayout.NORTH);
        TotalPanelProduce.add(ImagePanelProduce(imageURL),BorderLayout.SOUTH);

        return TotalPanelProduce;
    }


    public JPanel SearchResultNoticePanelProduce(String searchData){
        JPanel searchResultNoticePanel = new JPanel();
        searchResultNoticePanel.setLayout(new FlowLayout());
        searchResultNoticePanel.setPreferredSize(new Dimension(800,100));

        //textfield 설정 및 String 값 대입
        JTextField searchDataTextField = new JTextField(searchData);
        searchDataTextField.setPreferredSize(new Dimension(500,30));
        searchDataTextField.setHorizontalAlignment(JTextField.CENTER);
        searchResultNoticePanel.add(searchDataTextField);
        return searchResultNoticePanel;
    }

    public JPanel ImagePanelProduce(String[] imageURL){
        JPanel imagePanel = new JPanel();
        imagePanel.setLayout(new FlowLayout());
        imagePanel.setPreferredSize(new Dimension(800,350));

        //이미지 출력
        JLabel imageLabel = new JLabel();
        for(int i=0; i<10; i++){
            imageLabel = ImageProduceByURL(imageURL[i]);
            imageLabel.setSize(100, 100);
            imagePanel.add(imageLabel);
        }

        return imagePanel;
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

        Image updateImage = image.getScaledInstance(100, 100, Image.SCALE_SMOOTH);
        ImageIcon updateIcon = new ImageIcon(updateImage);

        mainImageLabel.setIcon(updateIcon);
        return mainImageLabel;
    }
}
