using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string TraineeId { get; set; }
        [Required]
        public string TrainerId { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
