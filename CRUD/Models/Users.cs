using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public string Status { get; set; }
    }
}
