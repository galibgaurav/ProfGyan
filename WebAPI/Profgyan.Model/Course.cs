using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public byte[] Logo { get; set; }
        [Required]
        public string StatusId { get; set; }
        [Required]
        public string URL { get; set; }
    }
}
