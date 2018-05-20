using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class Bid
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public bool FixedRate { get; set; }
        [Required]
        public string CourseId { get; set; }
        [Required]
        public string TrainerId { get; set; }
        [Required]
        public bool FinalBid { get; set; }
    }
}
