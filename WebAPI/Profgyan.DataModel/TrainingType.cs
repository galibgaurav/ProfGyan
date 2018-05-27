namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingType")]
    public partial class TrainingType
    {
        [Key]
        public string TypeId { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }
    }
}
