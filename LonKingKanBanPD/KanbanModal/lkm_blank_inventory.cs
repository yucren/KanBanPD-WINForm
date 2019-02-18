namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkm_blank_inventory
    {
        [Key]
        public int finterid { get; set; }

        public int? fitemid { get; set; }

        public int? fcount { get; set; }

        [StringLength(255)]
        public string fremark { get; set; }

        public int? flineid { get; set; }

        public int? fproid { get; set; }
    }
}
