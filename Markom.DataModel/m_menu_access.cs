namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class m_menu_access
    {
        public int id { get; set; }

        public int m_role_id { get; set; }

        public int m_menu_id { get; set; }

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
