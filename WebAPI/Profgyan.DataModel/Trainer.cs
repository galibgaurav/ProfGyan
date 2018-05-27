namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            //CommonDetails = new HashSet<CommonDetail>();
        }

        [StringLength(128)]
        public string UserID { get; set; }

        public string TrainerId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string ComDetailId { get; set; }

        public int? TypeId { get; set; }

        [StringLength(128)]
        public string TrDetailId { get; set; }

        [StringLength(128)]
        public string RatingId { get; set; }

        [StringLength(128)]
        public string StatusId { get; set; }

        public bool? IsVerified { get; set; }

        //Foreign key 
        public string CommonDetailID { get; set; }
        //Navigation properties
        public virtual CommonDetail CommonDetail { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CommonDetail> CommonDetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CommonDetail> CommonDetails { get; set; }
    }
}
