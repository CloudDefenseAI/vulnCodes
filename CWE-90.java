import java.util.Hashtable;
import javax.naming.Context;
import javax.naming.directory.DirContext;
import javax.naming.directory.InitialDirContext;

public class test {
    public static void main(String[] args) throws Exception {
        Hashtable<String, String> env = new Hashtable<String, String>();
        env.put(Context.INITIAL_CONTEXT_FACTORY, "com.sun.jndi.ldap.LdapCtxFactory");
        env.put(Context.PROVIDER_URL, "ldap://localhost:389");
        env.put(Context.SECURITY_AUTHENTICATION, "simple");
        env.put(Context.SECURITY_PRINCIPAL, "cn=Manager,dc=example,dc=com");
        env.put(Context.SECURITY_CREDENTIALS, "secret");
        DirContext ctx = new InitialDirContext(env);
        String filter = "(uid=" + args[0] + ")";
        ctx.search("ou=People,dc=example,dc=com", filter, null);
    }
}
