namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_design_item_file
    {
        public int id { get; set; }

        public int t_design_item_id { get; set; }

        [StringLength(100)]
        public string filename { get; set; }

        [StringLength(11)]
        public string size { get; set; }

        [StringLength(11)]
        public string extention { get; set; }

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
