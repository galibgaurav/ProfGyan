using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profgyan.Model
{
    public class AcessPermission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string RoleID { get; set; }
        [Required]
        public bool Edit { get; set; }
        [Required]
        public bool Update { get; set; }
        [Required]
        public bool Delete { get; set; }
        [Required]
        public bool Read { get; set; }
    }
}
