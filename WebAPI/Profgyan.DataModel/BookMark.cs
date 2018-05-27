namespace Profgyan.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookMark
    {
        public string BookmarkId { get; set; }

        [StringLength(128)]
        public string CourseId { get; set; }
    }
}
