using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [RegularExpression(@"^[STFGstfg]\d{7}[A-Za-z]", ErrorMessage = "Driving License does not meet NRIC requirements")]
        public string DrivingLicense { get; set; }
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Contact Number is not a valid phone number")]
        public string ContactNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string LastName { get; set; }

    }
}
