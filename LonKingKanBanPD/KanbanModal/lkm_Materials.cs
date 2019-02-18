namespace LonKingKanBanPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkm_Materials
    {
        [Key]
        public long fInterID { get; set; }

        public long? fItemID { get; set; }

        [StringLength(64)]
        public string fItemCode { get; set; }

        [StringLength(256)]
        public string fItemName { get; set; }

        [StringLength(256)]
        public string fAlias_Name { get; set; }

        [StringLength(256)]
        public string fModel { get; set; }

        [StringLength(64)]
        public string fAttribute { get; set; }

        [StringLength(32)]
        public string fUnit { get; set; }

        public int? fIsValid { get; set; }

        public int? fIsKeyPart { get; set; }

        [StringLength(128)]
        public string fProDpt { get; set; }

        [StringLength(50)]
        public string fMaterial_Class { get; set; }

        [StringLength(50)]
        public string fOrg { get; set; }

        public string fConfig { get; set; }

        [StringLength(50)]
        public string fZorP { get; set; }

        [StringLength(50)]
        public string fTransmission { get; set; }

        [StringLength(50)]
        public string fTon { get; set; }

        [StringLength(50)]
        public string fSupplyCode { get; set; }

        [StringLength(150)]
        public string fenname { get; set; }

        [StringLength(255)]
        public string fMDS { get; set; }

        [StringLength(255)]
        public string fSaleModel { get; set; }

        public DateTime? fCreateDate { get; set; }

        [StringLength(64)]
        public string fkbtype { get; set; }
    }
}
