namespace AutenticateLdap.LDAP.Interfaces
{
    public interface IAuthenticationService
    {
        bool Login(string username, string password);
    }
}
