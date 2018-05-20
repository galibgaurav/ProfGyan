using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class TrainerDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string TrainerId { get; set; }
        [Required]
        public string IndustrialExperience { get; set; }
        [Required]
        public List<string> Companies { get; set; }
        [Required]
        public List<string> SkillSet { get; set; }
        [Required]
        public string TeachingExperience { get; set; }
        [Required]
        public string TeachingReason { get; set; }
        [Required]
        public string SocialMediaId { get; set; }
    }
}
