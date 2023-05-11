import Utility.KakaoRESTAPI;

public class Main {

    public static void main(String[] args) {
        /*ImageSearchMode imageSearchMode = new ImageSearchMode();
        imageSearchMode.ImageSearchStart();*/
        
        KakaoRESTAPI kakaoRESTAPI = new KakaoRESTAPI();
        kakaoRESTAPI.ConnectionHTTP();
    }

}

