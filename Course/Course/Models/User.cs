using Course.Behaviors;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace Course.Models
{
    public class UserModel 
 
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

      
    }
}