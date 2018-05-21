using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class BookMarksTrainee_Map
    {
        [Required]
        public string BookmarkId { get; set; }
        [Required]
        public string TraineeId { get; set; }
    }
}
