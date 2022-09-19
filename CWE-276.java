import java.io.*;
import java.util.*;

public class test {
    public static void main(String[] args) {
        try {
            Properties prop = new Properties();
            OutputStream output = null;
            output = new FileOutputStream("config.properties");
            prop.setProperty("db.url", "jdbc:mysql://localhost:3306/test");
            prop.setProperty("db.user", "root");
            prop.setProperty("db.password", "root");
            prop.store(output, null);
            File file = new File("config.properties");
            file.setReadable(true, false);
            file.setWritable(true, false);
            file.setExecutable(true, false);
        } catch (IOException io) {
            io.printStackTrace();
        }
    }
}
