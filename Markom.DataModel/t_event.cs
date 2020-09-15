namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_event
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string event_name { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(255)]
        public string place { get; set; }

        public long? budget { get; set; }

        public int request_by { get; set; }

        public DateTime request_date { get; set; }

        public int? approved_by { get; set; }

        public DateTime? approved_date { get; set; }

        public int? assign_to { get; set; }

        public DateTime? closed_date { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? status { get; set; }

        [StringLength(255)]
        public string reject_reason { get; set; }

        public bool? is_delete { get; set; }

        [StringLength(50)]
        public string craeted_by { get; set; }

        public DateTime? created_date { get; set; }

        [StringLength(50)]
        public string updated_by { get; set; }

        public DateTime? updated_date { get; set; }
    }
}
