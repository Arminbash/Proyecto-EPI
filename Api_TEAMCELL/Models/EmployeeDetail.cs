using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api_TEAMCELL.Models
{
    public class EmployeeDetail
    {
        [Key]
        public int IdEmployee { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string SecondName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstSurname { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string SecondSurname { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string IdentificationCard { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string State { get; set; }
        [Required]
        public Boolean Status { get; set; }
    }
}
