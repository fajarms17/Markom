namespace Markom.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class m_employee
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string employee_number { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string last_name { get; set; }

        public int? m_company_id { get; set; }

        [StringLength(150)]
        public string email { get; set; }

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
