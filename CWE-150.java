import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class test extends HttpServlet {
    public void doGet(HttpServletRequest request, HttpServletResponse response)
    throws IOException, ServletException
    {
        response.setContentType("text/html");
        PrintWriter out = response.getWriter();
        String name = request.getParameter("name");
        // alow only specific characters like - dot or comma or space or alphanumeric characters if something else then error
        if (name.matches("[a-zA-Z0-9.,- ]+")) {
            out.println("Hello " + name);
        } else {
            out.println("You can use only dot comma or space or alphanumeric characters, rest are not allowed");
        }
    }
}
