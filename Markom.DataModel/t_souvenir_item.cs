namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_souvenir_item
    {
        public int id { get; set; }

        public int t_souvenir_id { get; set; }

        public int m_souvenir_id { get; set; }

        public long? qty { get; set; }

        public long? qty_settlemeny { get; set; }

        [Required]
        [StringLength(255)]
        public string note { get; set; }

        public bool? is_delete { get; set; }

        public long? created_by { get; set; }

        public DateTime? created_date { get; set; }

        public long? updated_by { get; set; }

        public DateTime? updated_date { get; set; }
    }
}
