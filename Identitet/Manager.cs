using Microsoft.AspNetCore.Identity;

namespace Identitet
{
    public class Person : IdentityUser
    { }
    public class Manager : Person
    {
    }
    public class User : Person
    {
    }
}
