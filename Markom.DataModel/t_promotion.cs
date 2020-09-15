namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_promotion
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(1)]
        public string flag_design { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        public int t_event_id { get; set; }

        [StringLength(11)]
        public string t_design_id { get; set; }

        public int? request_by { get; set; }

        public DateTime? request_date { get; set; }

        public int? approved_by { get; set; }

        public DateTime? approved_date { get; set; }

        public int? assign_to { get; set; }

        public DateTime? close_date { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? status { get; set; }

        [StringLength(255)]
        public string reject_reason { get; set; }

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
