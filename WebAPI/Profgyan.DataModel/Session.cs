namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Session")]
    public partial class Session
    {
        public string SessionId { get; set; }

        public DateTime? Timing { get; set; }

        [StringLength(128)]
        public string CourseId { get; set; }
    }
}
