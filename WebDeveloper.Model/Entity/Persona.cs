using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model.Entity
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Modified Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Photo")]
        public string Photo { get; set; }
    }
}
