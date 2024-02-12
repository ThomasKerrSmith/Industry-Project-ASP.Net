using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IndustryProjectASP.Net.Models
{
    public class Users : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
