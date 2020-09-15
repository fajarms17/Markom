using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markom.ViewModel
{
    public class RoleViewModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        
        [StringLength(50)]
        [Required(ErrorMessage = "Role Name Tidak Boleh Kosong")]
        public string name { get; set; }

        [Required(ErrorMessage = "Deskripsi Tidak Boleh Kosong")]
        [StringLength(255)]
        public string description { get; set; }

        public bool is_delete { get; set; }

        [Required]
        [StringLength(50)]
        public string created_by { get; set; }

        public DateTime created_date { get; set; }

        [StringLength(50)]
        public string updated_by { get; set; }

        public DateTime? updated_date { get; set; }
    }
}
