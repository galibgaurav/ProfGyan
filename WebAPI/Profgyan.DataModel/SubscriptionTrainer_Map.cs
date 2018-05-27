namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriptionTrainer_Map
    {
        [Key]
        public string SubscriptionId { get; set; }

        [StringLength(128)]
        public string TrainerId { get; set; }
    }
}
