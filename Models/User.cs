namespace WebApiP.Models;

public class User
{

    public int Id { get; set; }
    public string? Username { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public UserRole Role { get; set; } = UserRole.USER;
    
}

public enum UserRole
{
    // 2, 1, 0
    SUPERADMIN, ADMIN, USER
}

// Another way of thinking
public class AppUserRole
{
    public static readonly string SUPERADMIN = "SUPERADMIN";
    public static readonly string ADMIN = "ADMIN";
    public static readonly string USER = "USER";
}