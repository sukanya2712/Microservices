using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bookstore.Admin.Entity
{
    public class AdminEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }

        [Required(ErrorMessage = "First Name {0} is required")]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Minimum length can be 5 chracter and Maximum length can be 50")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name {0} is required")]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Minimum length can be 5 chracter and Maximum length can be 50")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email {0} is required")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password {0} is required")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
