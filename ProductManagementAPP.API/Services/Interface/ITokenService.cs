namespace ProductManagementApp.API
{
    using ProductManagementApp.Model;

    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
