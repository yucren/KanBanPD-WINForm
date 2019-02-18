using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace LonKingKanBanPD
{
    public partial class Kanbaninvpd : Form
    {
        LoginForm loginForm = new LoginForm();
        private const int SW_HIDE = 0;  //隐藏任务栏
        private const int SW_RESTORE = 9;//显示任务栏
        internal string name;
        internal string Userno;
        internal string Role;
        internal string UserDpt;
        internal string UserDptName;
        internal string UserDptType;
        public static  Kanbaninvpd kanbaninvpd;
        decimal orginValue = 0;
     //   decimal modifyValue = 0;
        public const int SM_CXSCREEN = 0;
        public const int SM_CYSCREEN = 1;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int nIndex);
        List<KbanBanInv> kanbanInvsOrigin = new List<KbanBanInv>();
        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        public Kanbaninvpd()
        {
            InitializeComponent();
            kanbaninvpd = this;
      
            Application.ApplicationExit += Application_ApplicationExit;
            this.Shown += Kanbaninvpd_Shown;
            this.VisibleChanged += Kanbaninvpd_VisibleChanged;
            

           
        }

        private void Kanbaninvpd_VisibleChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<KbanBanInv>();
            kanbanNo.Clear();
            kanbanNo.Focus();
            errMessage.Text = "请扫描看板二维码";
        }

        private void Kanbaninvpd_Shown(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<KbanBanInv>();
            kanbanNo.Clear();
            kanbanNo.Focus();
            errMessage.Text = "请扫描看板二维码";
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            ShowWindow(FindWindow("Shell_TrayWnd", null), SW_RESTORE);
        }

        private void Kanbaninvpd_Load(object sender, EventArgs e)
        {
                 
            errMessage.Text = "请扫描看板二维码";
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.Width = GetSystemMetrics(SM_CXSCREEN);
            this.Height = GetSystemMetrics(SM_CYSCREEN);
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            ShowWindow(FindWindow("Shell_TrayWnd", null), SW_HIDE); //隐藏
            loginForm.Show();
            Hide();          
        }
        private void GetStockData(bool isFront )
        {
            try
            {
                using (KanbanModal db = new KanbanModal())
                {
                    db.Database.Log = RecordDBLog;
                    IQueryable<KbanBanInv> result;
                    if (!isFront)
            {

                         result = from lkexek in db.lkm_exec_kanban_entry

                                     join lkanban in db.lkm_kanban on lkexek.fbasic_billno equals lkanban.fbillno
                                     join master in db.lkm_Materials on lkanban.fitemid equals (int)master.fInterID
                                     join lke in db.LKM_MCCItemEntry on master.fItemID equals lke.fItemID
                                     join lmentry in db.LKM_MCCPTEntry on lke.fConfigID equals lmentry.fConfigID
                                     join lc in db.lkm_CommonBill on lmentry.fProTecID equals lc.fInterID
                                     join inv in db.lkm_blank_inventory on
                                      new
                                      {
                                          ID1 = lkanban.fitemid,
                                          ID2 = (int?)lmentry.fProTecID

                                      }
                                      equals new
                                      {
                                          ID1 = inv.fitemid,
                                          ID2 = inv.fproid

                                      } into invleft
                                     from leftinv in invleft.DefaultIfEmpty()

                                     where lkexek.fbillno == kanbanNo.Text && lmentry.fProTecID != 56 && lmentry.fProTecID == 101

                                     select new KbanBanInv
                                     {
                                         ID = master.fItemCode + lmentry.fConfigID + lmentry.fProTecID,
                                         Fbillno = lkexek.fbillno,
                                         FItemCode = master.fItemCode,
                                         FItemName = master.fItemName,
                                         FitemInterID = lkanban.fitemid,
                                         FModel = master.fModel,
                                         FProTecID = lmentry.fInterID,
                                         Bustype = 0,
                                         FName = lc.fName,
                                         FConfigID = lke.fConfigID,
                                         Fcount = leftinv == null ? null : leftinv.fcount,
                                         FDCount = leftinv == null ? null : leftinv.fcount

                                     };
                    }
                    else
                    {

                         result = from lkexek in db.lkm_exec_kanban_entry

                                     join lkanban in db.lkm_kanban on lkexek.fbasic_billno equals lkanban.fbillno
                                     join master in db.lkm_Materials on lkanban.fitemid equals (int)master.fInterID
                                     join lke in db.LKM_MCCItemEntry on master.fItemID equals lke.fItemID
                                     join lmentry in db.LKM_MCCPTEntry on lke.fConfigID equals lmentry.fConfigID
                                     join lc in db.lkm_CommonBill on lmentry.fProTecID equals lc.fInterID
                                     join inv in db.lkm_blank_inventory on
                                      new
                                      {
                                          ID1 = lkanban.fitemid,
                                          ID2 = (int?)lmentry.fProTecID

                                      }
                                      equals new
                                      {
                                          ID1 = inv.fitemid,
                                          ID2 = inv.fproid

                                      } into invleft
                                     from leftinv in invleft.DefaultIfEmpty()

                                     where lkexek.fbillno == kanbanNo.Text && lmentry.fProTecID != 56 && lmentry.fProTecID != 101

                                     select new KbanBanInv
                                     {
                                         ID = master.fItemCode + lmentry.fConfigID + lmentry.fProTecID,
                                         Fbillno = lkexek.fbillno,
                                         FItemCode = master.fItemCode,
                                         FItemName = master.fItemName,
                                         FitemInterID = lkanban.fitemid,
                                         FModel = master.fModel,
                                         FProTecID = lmentry.fInterID,
                                         Bustype = 0,
                                         FName = lc.fName,
                                         FConfigID = lke.fConfigID,
                                         Fcount = leftinv == null ? null : leftinv.fcount,
                                         FDCount = leftinv == null ? null : leftinv.fcount

                                     };
                    }
              

                    var pdSource= result.ToList();
                    dataGridView1.DataSource = pdSource;
                    using (MemoryStream ms =new MemoryStream())
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(ms, pdSource);
                        ms.Seek(0, SeekOrigin.Begin);
                         kanbanInvsOrigin =    formatter.Deserialize(ms) as List<KbanBanInv>;
                    }
                          
                          
                            errMessage.Text = "查找成功";
                           
                        }





            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                errMessage.Text = "发生错误:" + ex.Message;
                throw;
            }





        }

        private void RecordDBLog(string obj)
        {
            logRichTextBox.Text += obj;
        }

        private void kanbanNo_TextChanged(object sender, EventArgs e)
        {
            if (!kanbanNo.Text.ToUpper().StartsWith("L") && kanbanNo.Text.Length !=0)
            {
                MessageBox.Show("请扫描生产看板");
                kanbanNo.Text = "";
                kanbanNo.Focus();
            }

        }

        private void pdBtn_Click(object sender, EventArgs e)
        {

            List<KbanBanInv> kanbanInvs = dataGridView1.DataSource as List<KbanBanInv>;
            var KanbanNotSame = from p in kanbanInvs join po in kanbanInvsOrigin on p.ID equals po.ID where p.FDCount != po.FDCount select p;
            var stockBuilder = new StringBuilder();
            var lineNo = 0;
            foreach (var stock in KanbanNotSame)
            {
                lineNo += 1;
                stockBuilder.AppendFormat("序号:{0},料号:{1},品名:{2},规格型号:{3},工序:{4},盘点库存:{5}\n",lineNo, stock.FItemCode, stock.FItemName,stock.FModel,stock.FName, stock.FDCount);
            }
            var dialogResult =    MessageBox.Show("以下物料需要调整对应扫描点库存,请确认\n" + stockBuilder.ToString(),"库存盘点确认", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                using (pro_ExecKanbanInv_lansqDataContext db = new pro_ExecKanbanInv_lansqDataContext())
                {
                    foreach (var item in KanbanNotSame)
                    {

                       db.pro_ExecKanbanInv_lansq(item.Fbillno, item.Bustype, (int?)item.FConfigID, (int?)item.FProTecID, item.FitemInterID, item.FDCount, this.name);

                    }       
                    
                }
            }
            else
            {
                MessageBox.Show("取消调整", "友情提示");
            }

            dataGridView1.DataSource = new List<KbanBanInv>();
            kanbanNo.Clear();
            kanbanNo.Focus();
            errMessage.Text = "请扫描看板二维码";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
          ;

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(dataGridView1.CurrentCell.Value) != Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = true;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor =Color.Yellow;                   
                }
                else if (Convert.ToDecimal(dataGridView1.CurrentCell.Value) == Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value))
                {

                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = false;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.EndEdit();
        }

        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
             //   MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                

            }
            catch (Exception)
            {


            }
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
          
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
          //  MessageBox.Show("ddd");
        }

        private void Kanbaninvpd_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            orginValue = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void pdUser_Click(object sender, EventArgs e)
        {

        }

        private void kanbanNo_KeyDown(object sender, KeyEventArgs e)
        {
           
            
            
           
        }

        private void Kanbaninvpd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (kanbanNo.Text != "")
                {

                    GetStockData(false);
                    kanbanNo.Text = "";
                }
                else
                {
                    pdBtn.PerformClick();
                }

            }
        }

       

        private void exitLoginBtn_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            loginForm.Show();
            this.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DefaultCellStyle.Font = fontDialog1.Font;
                DataContractSerializer formatter = new DataContractSerializer(typeof(Font));
                using (MemoryStream ms =new MemoryStream())
                {

                    formatter.WriteObject(ms, fontDialog1.Font);
                    byte[] xmlByte = new byte[ms.Length];
                    ms.Seek(0, SeekOrigin.Begin);
                    ms.Read(xmlByte, 0, (int)ms.Length);
                    MessageBox.Show(Convert.ToBase64String(xmlByte));
                    
                }
                
                
               
            }   

        }
    }
}
