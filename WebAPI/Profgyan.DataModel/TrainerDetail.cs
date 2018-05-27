namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TrainerDetail
    {
        [Key]
        public string TrDetailId { get; set; }

        public int? Experience { get; set; }

        [StringLength(200)]
        public string Companies { get; set; }

        [StringLength(300)]
        public string SkillSet { get; set; }

        [StringLength(300)]
        public string TeachingExperience { get; set; }

        [StringLength(300)]
        public string Rewards { get; set; }

        [StringLength(300)]
        public string TeachingReason { get; set; }

        [StringLength(128)]
        public string SocialMediaId { get; set; }

        //Foreign Key 
        public string TrainerId { get; set; }
        //Navigation Property

        public Trainer Trainer { get; set; }
    }
}
