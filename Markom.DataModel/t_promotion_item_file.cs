namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_promotion_item_file
    {
        public int id { get; set; }

        public int t_promotion_id { get; set; }

        [StringLength(100)]
        public string filename { get; set; }

        [StringLength(11)]
        public string size { get; set; }

        [StringLength(11)]
        public string extention { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public DateTime? request_due_date { get; set; }

        public long? qty { get; set; }

        public int todo { get; set; }

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
