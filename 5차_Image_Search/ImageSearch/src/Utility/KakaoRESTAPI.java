package Utility;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import swing.MainFrame;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;


public class KakaoRESTAPI {
    private final static String API_URL = "https://dapi.kakao.com/v2/search/image"; // 검색 API URL
    private final static String API_KEY = "e2685cab5b4653d5ac752f1d4b988428"; // REST API 키

    public void ConnectionHTTP() {

        String[] imageURL = new String[2];

        try {
            String query = "고양이"; // 검색어
            int size = 2; // 한 페이지에 포함되는 문서의 수
            int page = 1; // 페이지 번호
            String sort = "accuracy"; // 정렬 방법

            // URL 파라미터 구성
            String encodedQuery = URLEncoder.encode(query, "UTF-8");
            String urlString = String.format("%s?query=%s&page=%d&size=%d&sort=%s",
                    API_URL, encodedQuery, page, size, sort);

            // HTTP 연결 설정
            URL url = new URL(urlString);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Authorization", "KakaoAK " + API_KEY);

            // API 요청 결과 읽기
            BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream(), "UTF-8"));
            String Line;
            StringBuilder response = new StringBuilder();
            while ((Line = br.readLine()) != null) {
                response.append(Line);
            }
            br.close();
            conn.disconnect();

            String result = response.toString();

            JSONParser parser = new JSONParser();
            JSONObject jsonObject = (JSONObject) parser.parse(result);
            JSONArray documents = (JSONArray)jsonObject.get("documents"); // 배열 뽑아내기

            for(int i=0; i<2; i++) {
                JSONObject document = (JSONObject) documents.get(i);
                imageURL[i]=document.get("image_url").toString();
            }

        } catch (Exception e) {
            e.printStackTrace();
        }

        new MainFrame(imageURL);


    }

}
