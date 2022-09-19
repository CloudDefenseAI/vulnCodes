import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class test {
    public static void main(String[] args) throws IOException {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter Your name, this will be used to create a directory");
        String command = sc.nextLine();
        // check if command contains any special characters then throw an exception
        if (command.matches("^[a-zA-Z0-9]*$")) {
            Process p = Runtime.getRuntime().exec("mkdir " + command);
            BufferedReader in = new BufferedReader(new InputStreamReader(p.getInputStream()));
            String line = null;
            while ((line = in.readLine()) != null) {
                System.out.println(line);
            }
        } else {
            System.out.println("Invalid command");
        }
    }
}
