using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
       [DataType(DataType.PhoneNumber)]
       // [Phone]
        public Int64 PhoneNumber { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(2)] [MinLength(2)]
        public string State { get; set; }

        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }

        [MaxLength(25)]
        public string Country { get; set; }
        
        [Required]
        [MaxLength(15)]
        [MinLength(6)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

    }
}
