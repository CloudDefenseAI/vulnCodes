import java.util.Scanner;
public class test {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the number of times you want to print your name");
        int n = sc.nextInt();
        for (int i = 0; i < n; i++) {
            System.out.println("My name is " + i);
        }
    }
}
