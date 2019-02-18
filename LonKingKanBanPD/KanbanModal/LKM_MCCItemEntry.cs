namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LKM_MCCItemEntry
    {
        [Key]
        public long fInterID { get; set; }

        public long? fConfigID { get; set; }

        public long? fItemID { get; set; }

        [StringLength(50)]
        public string fItemCode { get; set; }

        [StringLength(128)]
        public string fItemName { get; set; }
    }
}
