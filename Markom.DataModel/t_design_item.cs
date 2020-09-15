namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_design_item
    {
        public int id { get; set; }

        public int t_design_id { get; set; }

        public int m_product_id { get; set; }

        [Required]
        [StringLength(255)]
        public string title_item { get; set; }

        public int request_pic { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public DateTime? request_due_date { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public bool? is_delete { get; set; }

        [Required]
        [StringLength(50)]
        public string created_by { get; set; }

        public DateTime created_date { get; set; }

        [StringLength(50)]
        public string updated_by { get; set; }

        public DateTime? updated_date { get; set; }
    }
}
