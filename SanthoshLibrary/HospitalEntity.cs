using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanthoshLibrary
{
    public class HospitalEntity
    {
        public int Id  {get;set;}
        [Required]
        [Display (Name= "Username")]
        [MaxLength (30)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        [Display(Name= "Contact Number")]
       /* [Range(1,999999999)]*/
        public long Phonenumber { get; set; }
        public long Pincode { get; set; }

    }
}
