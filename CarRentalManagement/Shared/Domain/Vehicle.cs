using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel, IValidatableObject
    {
        [Required]
        public int Year { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]{3}\d{4}[A-Za-z]",
            ErrorMessage = "License Plate Number does not meet requirements")]
        public string LicensePlateNumber { get; set; }

        [Required]
        public int? MakeId { get; set; }

        public virtual Make Make { get; set; }

        [Required]
        public int? ModelId { get; set; }
        public virtual Model Model { get; set; }

        [Required]
        public int? ColourId { get; set; }
        public virtual Colour Colour { get; set; }
        public virtual List<Booking> Bookings { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double RentalRate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (MakeId == null)
            {
                yield return new ValidationResult("Make must be chosen", new[] { "makeid" });
            }
            if (ModelId == null)
            {
                yield return new ValidationResult("Model must be chosen", new[] { "modelid" });
            }
            if (ColourId == null)
            {
                yield return new ValidationResult("Colour must be chosen", new[] { "colourid" });
            }
        }
    }
}