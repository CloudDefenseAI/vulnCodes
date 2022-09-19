import java.io.BufferedReader;
import java.io.InputStreamReader;

public class test {
    public static void main(String[] args) throws Exception {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String input = br.readLine();
        if (input.matches("[a-zA-Z0-9.]+")) {
            Runtime.getRuntime().exec("ping " + input);
        }
    }
}
