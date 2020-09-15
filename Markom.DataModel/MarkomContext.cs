namespace Markom.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MarkomContext : DbContext
    {
        public MarkomContext()
            : base("name=MarkomContext")
        {
        }

        public virtual DbSet<m_company> m_company { get; set; }
        public virtual DbSet<m_employee> m_employee { get; set; }
        public virtual DbSet<m_menu> m_menu { get; set; }
        public virtual DbSet<m_menu_access> m_menu_access { get; set; }
        public virtual DbSet<m_product> m_product { get; set; }
        public virtual DbSet<m_role> m_role { get; set; }
        public virtual DbSet<m_souvenir> m_souvenir { get; set; }
        public virtual DbSet<m_unit> m_unit { get; set; }
        public virtual DbSet<m_user> m_user { get; set; }
        public virtual DbSet<t_design> t_design { get; set; }
        public virtual DbSet<t_design_item> t_design_item { get; set; }
        public virtual DbSet<t_design_item_file> t_design_item_file { get; set; }
        public virtual DbSet<t_event> t_event { get; set; }
        public virtual DbSet<t_promotion> t_promotion { get; set; }
        public virtual DbSet<t_promotion_item> t_promotion_item { get; set; }
        public virtual DbSet<t_promotion_item_file> t_promotion_item_file { get; set; }
        public virtual DbSet<t_souvenir> t_souvenir { get; set; }
        public virtual DbSet<t_souvenir_item> t_souvenir_item { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_company>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<m_company>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<m_company>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<m_company>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<m_company>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<m_company>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_company>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_employee>()
                .Property(e => e.employee_number)
                .IsUnicode(false);

            modelBuilder.Entity<m_employee>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<m_employee>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<m_employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<m_employee>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_employee>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_menu>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<m_menu>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<m_menu>()
                .Property(e => e.controller)
                .IsUnicode(false);

            modelBuilder.Entity<m_menu>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_menu>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_menu_access>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_menu_access>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_product>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<m_product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<m_product>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<m_product>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_product>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_role>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<m_role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<m_role>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<m_role>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_role>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_souvenir>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<m_souvenir>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<m_souvenir>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<m_souvenir>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_souvenir>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_unit>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<m_unit>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<m_unit>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<m_unit>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_unit>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<m_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<m_user>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<m_user>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_design>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<t_design>()
                .Property(e => e.title_header)
                .IsUnicode(false);

            modelBuilder.Entity<t_design>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_design>()
                .Property(e => e.reject_reason)
                .IsUnicode(false);

            modelBuilder.Entity<t_design>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_design>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item>()
                .Property(e => e.title_item)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item_file>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item_file>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item_file>()
                .Property(e => e.extention)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item_file>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_design_item_file>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_event>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<t_event>()
                .Property(e => e.event_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_event>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<t_event>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_event>()
                .Property(e => e.reject_reason)
                .IsUnicode(false);

            modelBuilder.Entity<t_event>()
                .Property(e => e.craeted_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_event>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.flag_design)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.t_design_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.reject_reason)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item>()
                .Property(e => e.m_product_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item_file>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item_file>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item_file>()
                .Property(e => e.extention)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item_file>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item_file>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_promotion_item_file>()
                .Property(e => e.updated_by)
                .IsUnicode(false);

            modelBuilder.Entity<t_souvenir>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<t_souvenir>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<t_souvenir>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_souvenir>()
                .Property(e => e.reject_reason)
                .IsUnicode(false);

            modelBuilder.Entity<t_souvenir_item>()
                .Property(e => e.note)
                .IsUnicode(false);
        }
    }
}
