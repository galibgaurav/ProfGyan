namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enrollment")]
    public partial class Enrollment
    {
        public string EnrollmentId { get; set; }

        [StringLength(128)]
        public string CourseId { get; set; }

        [StringLength(128)]
        public string TrainerId { get; set; }

        public DateTime? DateEnrolled { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDateTime { get; set; }
        
        //Foreign key
        public string CourseID { get; set; }

        //Navigation Property key
        public virtual Course Course { get; set; }
    }
}
