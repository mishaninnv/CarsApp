using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CarsApp.Authorize;

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; 
    public const string AUDIENCE = "MyAuthClient"; 
    const string KEY = "jlskdsdfdfdsfakriqaohgobh123487)(*$E#@fjlaksjdffjha;h87";
    public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
}
