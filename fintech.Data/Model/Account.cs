using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace fintech.Data.Model
{
    public class Account
    {
        public int Id { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "Account number must contain numeric character only")]
        [MaxLength(20)]
        [Required]
        public string AccountNumber { get; set; }
        [RegularExpression(@"^[a-zA-D\d]+$", ErrorMessage = "Owner name must contain only valid characters")]
        [MaxLength(20)]
        [Required]
        public string OwnerName { get; set; }
        
        [Precision(18,3)]
        [Required]
        public decimal Balance { get; set; } 
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Phone number must contains numeric character only")]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
