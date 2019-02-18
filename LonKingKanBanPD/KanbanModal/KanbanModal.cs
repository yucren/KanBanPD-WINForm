namespace LonKingKanBanPD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KanbanModal : DbContext
    {
        public KanbanModal()
            : base("name=KanbanModal")
        {

        }
        public virtual DbSet<LKM_Depart> LKM_Depart { get; set; }

        public virtual DbSet<lkm_blank_inventory> lkm_blank_inventory { get; set; }
        public virtual DbSet<lkm_CommonBill> lkm_CommonBill { get; set; }
        public virtual DbSet<lkm_exec_kanban_entry> lkm_exec_kanban_entry { get; set; }
        public virtual DbSet<lkm_kanban> lkm_kanban { get; set; }
        public virtual DbSet<lkm_Materials> lkm_Materials { get; set; }
        public virtual DbSet<LKM_MCCItemEntry> LKM_MCCItemEntry { get; set; }
        public virtual DbSet<LKM_MCCPTEntry> LKM_MCCPTEntry { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LKM_Depart>()
                .Property(e => e.parentID)
                .IsUnicode(false);
            modelBuilder.Entity<lkm_blank_inventory>()
                .Property(e => e.fremark)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_exec_kanban_entry>()
                .Property(e => e.fbasic_billno)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_exec_kanban_entry>()
                .Property(e => e.fbillno)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_exec_kanban_entry>()
                .Property(e => e.fstatuName)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_kanban>()
                .Property(e => e.fbillno)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_kanban>()
                .Property(e => e.fremark)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_kanban>()
                .Property(e => e.fcreater)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_kanban>()
                .Property(e => e.fcardno)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_kanban>()
                .Property(e => e.fproductline)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_kanban>()
                .Property(e => e.fthickness)
                .IsUnicode(false);

            modelBuilder.Entity<lkm_Materials>()
                .Property(e => e.fkbtype)
                .IsUnicode(false);

            modelBuilder.Entity<LKM_MCCPTEntry>()
                .Property(e => e.fPersons)
                .IsUnicode(false);
        }
    }
}
