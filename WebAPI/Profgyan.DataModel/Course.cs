namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public string CourseId { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [StringLength(128)]
        public string StatusId { get; set; }

        public string URL { get; set; }
    }
}
