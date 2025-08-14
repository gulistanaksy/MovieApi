using Microsoft.AspNetCore.Identity;


// dahil etmek istediğimiz alanlar
namespace MovieApi.Persistence.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ProfileImageUrl { get; set; }
    }
}