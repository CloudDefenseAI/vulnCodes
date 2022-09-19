usrname = request.getParameter("usrname");
// check if user is already logged in and usrname from session is same as usrname from request
if (session.getAttribute(ATTR_USR) != null && session.getAttribute(ATTR_USR).equals(usrname)) {
 // do nothing
} else {
    session.setAttribute(ATTR_USR, usrname);
}
