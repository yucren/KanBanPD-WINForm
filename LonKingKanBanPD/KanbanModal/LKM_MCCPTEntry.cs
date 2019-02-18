namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LKM_MCCPTEntry
    {
        [Key]
        public long fInterID { get; set; }

        public long? fConfigID { get; set; }

        public int? fOrders { get; set; }

        public long? fProTecID { get; set; }

        public int? fStatus { get; set; }

        public DateTime? fSWHour { get; set; }

        [StringLength(2000)]
        public string fMemo { get; set; }

        [StringLength(64)]
        public string fPersons { get; set; }

        [StringLength(256)]
        public string fPsnItemInfo { get; set; }

        public int? fStructPin { get; set; }
    }
}
