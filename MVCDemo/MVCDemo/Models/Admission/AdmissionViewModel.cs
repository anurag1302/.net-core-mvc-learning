using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models.Admission
{
    public class AdmissionViewModel
    {
        [Required(ErrorMessage ="First Name is mandatory.")]
        [Display(Name ="First Name")]
        [MaxLength(10,ErrorMessage ="Max length is 10.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Address is mandatory.")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact Number is mandatory.")]
        [Display(Name = "Contact Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Passed year is mandatory.")]
        [Display(Name = "12th Completed In?")]
        public int? PassedYear { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password do not match")]
        public string ComparePassword { get; set; }
    }
}
