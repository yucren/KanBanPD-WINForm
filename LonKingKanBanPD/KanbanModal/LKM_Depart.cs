namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LKM_Depart
    {
        public long id { get; set; }

        [StringLength(50)]
        public string DepartName { get; set; }

        [StringLength(32)]
        public string parentID { get; set; }

        public int? depth { get; set; }

        public int? orders { get; set; }

        [StringLength(2000)]
        public string Memo { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Updated { get; set; }

        [StringLength(50)]
        public string Updator { get; set; }

        [StringLength(50)]
        public string DepartCode { get; set; }

        public int? fPOAuthority { get; set; }

        public int? fAdmin { get; set; }

        public int? fSchePrintAutority { get; set; }
    }
}
