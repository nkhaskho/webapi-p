namespace WebApiP.Models;

public class User
{

    public int Id { get; set; }
    public string? Username { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();

    public string Role { get; set; } = AppUserRole.USER;
    
}

public enum UserRole
{
    SUPERADMIN, ADMIN, USER
}

public class AppUserRole
{
    public static readonly string SUPERADMIN = "SUPERADMIN";
    public static readonly string ADMIN = "ADMIN";
    public static readonly string USER = "USER";
}