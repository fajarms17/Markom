namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_souvenir
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(11)]
        public string type { get; set; }

        public int? t_event_id { get; set; }

        public int request_by { get; set; }

        public DateTime? request_date { get; set; }

        public DateTime? request_due_date { get; set; }

        public int? approved_by { get; set; }

        public DateTime? approved_date { get; set; }

        public int? received_by { get; set; }

        public DateTime? received_date { get; set; }

        public int? settlement_by { get; set; }

        public DateTime? settlement_date { get; set; }

        public int? settlement_approved_by { get; set; }

        public DateTime? settlement_approved_date { get; set; }

        public int? status { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [StringLength(255)]
        public string reject_reason { get; set; }

        public bool? is_delete { get; set; }

        public long? created_by { get; set; }

        public DateTime? created_date { get; set; }

        public long? updated_by { get; set; }

        public DateTime? updated_date { get; set; }
    }
}
