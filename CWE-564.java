import java.sql.*;
import java.util.Scanner;

public class test {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the username");
        String username = sc.nextLine();
        System.out.println("Enter the password");
        String password = sc.nextLine();
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/test", "root", "root");
            String query = "select * from users where username = ? and password = ?";
            PreparedStatement stmt = con.prepareStatement(query);
            stmt.setString(1, username);
            stmt.setString(2, password);
            ResultSet rs = stmt.executeQuery();
            if (rs.next()) {
                System.out.println("Login successful");
            } else {
                System.out.println("Login failed");
            }
        } catch (Exception e) {
            System.out.println(e);
        }
    }
}
