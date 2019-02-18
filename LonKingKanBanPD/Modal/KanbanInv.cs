using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LonKingKanBanPD
{
  public  class KanbanInv
    {
              public int ID { get; set; }
              public string   料号 {get;set;}
              public string   品名 {get;set;}
              public string   型号 {get;set;}
              public string 工序 { get; set; }
              public decimal 系统数量 { get; set; }
              public decimal 盘点数量 { get; set; }
    }
}
