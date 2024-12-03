using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SPSO.Models
{
    public class OwnerModel
    {
        private string lastName;
        private string firstName;
        private string email;
        private string phoneNumber;

        [Required(ErrorMessage = "User last name is required")]
        [StringLength(50, MinimumLength =1, ErrorMessage ="User last name must be not empty and not over 50 character")]
        public string LastName
        { get { return lastName; } set { lastName = value; } }

        [Required(ErrorMessage = "User first name is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "User first name must be not empty and not over 100 character")]
        public string FirstName 
        { get { return firstName; } set { firstName = value; } }

        [Required(ErrorMessage = "User email is required")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "User email must be not empty and not over 150 character")]
        public string Email 
            { get { return email; } set { email = value; } }

        [Required(ErrorMessage = "User phone number is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "User phone number must be exactly 10 character")]
        public string PhoneNumber
            { get { return phoneNumber; } set { phoneNumber = value; } }
    }
}
