using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Myproject.Models
{
    public class User 
    {
        
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
