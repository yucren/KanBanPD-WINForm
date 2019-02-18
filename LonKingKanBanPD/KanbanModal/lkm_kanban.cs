namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkm_kanban
    {
        [Key]
        public int finterid { get; set; }

        [Required]
        [StringLength(8)]
        public string fbillno { get; set; }

        public int? fcategory { get; set; }

        public int? ffrompalce { get; set; }

        public int? ftopalce { get; set; }

        public int? ftype { get; set; }

        [StringLength(255)]
        public string fremark { get; set; }

        [StringLength(64)]
        public string fcreater { get; set; }

        public DateTime? fcreatedate { get; set; }

        public int? fitemid { get; set; }

        public int? fdaily_count { get; set; }

        public int? fset_count { get; set; }

        public int? fblank_batch { get; set; }

        public int? ftransfer_batch { get; set; }

        public int? fmin_count { get; set; }

        public int? fpacking_count { get; set; }

        public int? fsafety_count { get; set; }

        [StringLength(128)]
        public string fcardno { get; set; }

        [StringLength(128)]
        public string fproductline { get; set; }

        [StringLength(128)]
        public string fthickness { get; set; }

        public int? fexec_status { get; set; }

        public int? fstatus { get; set; }
    }
}
