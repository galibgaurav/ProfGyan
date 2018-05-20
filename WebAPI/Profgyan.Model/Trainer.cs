using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class Trainer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string ComDetailId { get; set; }

        [Required]
        public string TypeId { get; set; }
        [Required]
        public string TrDetailId { get; set; }
        [Required]
        public string RatingId { get; set; }
        [Required]
        public string StatusId { get; set; }
        [Required]
        public bool IsVerified { get; set; }
    }
}
