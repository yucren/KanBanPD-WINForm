using System;

namespace LonKingKanBanPD
{
    [Serializable]
    internal class KbanBanInv
    {             
            
        public string Fbillno { get; set; }
        public string FItemCode { get; set; }
        public string FItemName { get; set; }
        public string FModel { get; set; }
        public long? FProTecID { get; set; }
        public int Bustype { get; set; }
        public string FName { get; set; }
        public long? FConfigID { get; set; }
        public int? Fcount { get; set; }
        public int? FDCount { get;  set; }
        public string ID { get; internal set; }
        public int? FitemInterID { get; internal set; }
    }
}