namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        public string AttendanceId { get; set; }

        [StringLength(128)]
        public string SessionId { get; set; }

        [StringLength(128)]
        public string TraineeId { get; set; }
    }
}
