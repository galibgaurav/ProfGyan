namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public string AppointmentId { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(300)]
        public string Message { get; set; }

        //Foreign key
        public string TraineeID { get; set; }
        public string TrainerId { get; set; }
        //Navigation Property
        public Trainee Trainee { get; set; }
        public Trainer Trainer { get; set; }
    }
}
