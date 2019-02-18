namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkm_exec_kanban_entry
    {
        [Key]
        public int finterid { get; set; }

        [StringLength(64)]
        public string fbasic_billno { get; set; }

        public int? fmainid { get; set; }

        [StringLength(64)]
        public string fbillno { get; set; }

        public int? fstatus { get; set; }

        public int? fuse_status { get; set; }

        public int? fprint { get; set; }

        [StringLength(64)]
        public string fstatuName { get; set; }

        public long? fCurScanID { get; set; }

        [StringLength(50)]
        public string fCurScanNo { get; set; }
    }
}
