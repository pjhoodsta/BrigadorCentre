using System.ComponentModel.DataAnnotations;

namespace BrigadorCentreApp.Models
{
    public class HireApplication
    {
        [Required]
        public int Id { get; set; }
        // [Required]
        // public string SSN { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}