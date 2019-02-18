namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkm_CommonBill
    {
        [Key]
        public long fInterID { get; set; }

        [StringLength(32)]
        public string fCode { get; set; }

        [StringLength(128)]
        public string fName { get; set; }

        public int? fStatus { get; set; }

        [StringLength(32)]
        public string fOrg { get; set; }

        public long? fparentID { get; set; }

        [StringLength(32)]
        public string fClass { get; set; }

        [StringLength(255)]
        public string fRemark { get; set; }

        public int? ftype { get; set; }
    }
}
