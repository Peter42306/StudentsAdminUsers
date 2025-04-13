using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAdminUsers.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Not more than 50 symbols")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Wrong email format")]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\+380\d{9}$", ErrorMessage = "Format: +380XXXXXXXXX")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        
        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }
    }
}
