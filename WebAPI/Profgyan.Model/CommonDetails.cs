using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class CommonDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime AcademicYear { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Grade { get; set; }
     
        public byte[] UserPhoto { get; set; }

    }
}
