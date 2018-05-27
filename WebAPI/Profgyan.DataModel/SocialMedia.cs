namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SocialMedia")]
    public partial class SocialMedia
    {
        public string SocialMediaId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        //foreign key
        public string TrDetailId { get; set; }
        //nnavigation property
        public TrainerDetail TrainerDetail { get; set; }
    }
}
