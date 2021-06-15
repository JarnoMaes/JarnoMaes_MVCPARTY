using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JarnoMaes_MVCPARTY.Models
{
    public class VisitorsModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [DisplayName("Your First Name")]
        public string FirstName { get; set; }
       
        [Required]
        [StringLength(25, MinimumLength = 3)]
        [DisplayName("Your Last Name")]
        public string SecondName { get; set; }
       
        [Required]
        [EmailAddress]
        [DisplayName("Your Email Adress")]
        public string EmailAdress { get; set; }
       
        [Required]
        [DisplayName("Your Phone Number")]
        public string PhoneNumber { get; set; }
       
        [Required]
        [Range(18, 60)]
        [DisplayName("Your Age")]
        public int Age { get; set; }
       
        [Required]
        [DisplayName("Your Home Adress")]
        public string Adress { get; set; }
        
        [Required]
        [Range(1000, 1500)]
        [DisplayName("Your Zip Code")]
        public int PostalCode { get; set; }
        
        [Required]
        [DisplayName("City Do You Live in")]
        public string City { get; set; }       
        
        [Required]
        [DisplayName("Are You Family ?")]
        public bool IsFamily { get; set; }

    }
}
