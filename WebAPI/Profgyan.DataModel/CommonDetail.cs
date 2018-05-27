namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CommonDetail
    {
        public string ID { get; set; }

        [StringLength(128)]
        public string ComDetailId { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public DateTime? AcademicYear { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Grade { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        
    }
}
