import java.io.*;
import java.net.*;
import javax.net.ssl.*;

public class test {
    public static void main(String[] args) throws Exception {
        URL url = new URL("https://www.google.com");
        HttpsURLConnection con = (HttpsURLConnection) url.openConnection();
        con.setHostnameVerifier(new HostnameVerifier() {
            public boolean verify(String hostname, SSLSession session) {
                return true;
            }
        });
        con.setRequestMethod("GET");
        con.connect();
        System.out.println(con.getResponseCode());
        System.out.println(con.getResponseMessage());
    }
}
