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
        out.println("Hello " + name);
    }
}
