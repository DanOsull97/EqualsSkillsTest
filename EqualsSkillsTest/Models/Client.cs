using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EqualsSkillsTest.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; } //In practise, would like validation here to ensure it's formatted to standard, or one of a set of standards (Unsure of international rules regarding this sort of thing)
        [Display(Name = "Date of Application")]
        [DataType(DataType.Date)]
        public DateTime dateApplied { get; set; }
    }
}
