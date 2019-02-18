using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Configuration;
using Microsoft.VisualBasic;

namespace LonKingKanBanPD
{
    public partial class LoginForm : Form
    {
        private const int SW_HIDE = 0;  //隐藏任务栏
        private const int SW_RESTORE = 9;//显示任务栏
        private string name;
        private string Userno;
        private string Role;
        private string UserDpt;
        private string UserDptName;
        private string UserDptType;
        public const int SM_CXSCREEN = 0;
        public const int SM_CYSCREEN = 1;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int nIndex);
       
        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: 这行代码将数据加载到表“lonKing_MES_JXDataSet.LKM_Depart”中。您可以根据需要移动或删除它。
                
                ShowWindow(FindWindow("Shell_TrayWnd", null), SW_HIDE);
                this.FormBorderStyle = FormBorderStyle.None;
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;
                this.Width = GetSystemMetrics(SM_CXSCREEN);
                this.Height = GetSystemMetrics(SM_CYSCREEN);
                label4.Text = ConfigurationManager.AppSettings["PDDepart"];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Close();
            //Kanbaninvpd.kanbaninvpd.Show();
        }

        private void logTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {


                    using (SqlConnection sqlconn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KanbanModal"].ToString()))
                    {
                        string[] array = this.logTextbox.Text.Replace('，', ',').Split(new char[]
              {
                ','
              });
                        if (array.Length > 1)
                        {
                            string sql = string.Concat(new string[]
                            {
                    "SELECT b.RoleName  ,a.Number ,d.DepartCode ,d.DepartName ,d.fAdmin FROM LKM_SysUser a  inner join LKM_Member c  on a.Number=c.Number  inner join LKM_Depart d  on c.DepartID=d.id  left JOIN LKM_UserInRole b ON a.UserInRole_id = b.id  where a.number='",
                    array[0],
                    "' and a.status=1 and a.pwd='",
                    array[1],
                    "'"
                            });
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlconn);
                            DataTable dataTable = new DataTable();
                            sqlconn.Open();
                            sqlDataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                //  base.DialogResult =  DialogResult.Yes;
                                this.name = Kanbaninvpd.kanbaninvpd.name = array[2];
                                this.Userno = Kanbaninvpd.kanbaninvpd.Userno = array[0];
                                this.Role = Kanbaninvpd.kanbaninvpd.Role = dataTable.Rows[0]["RoleName"].ToString();
                                this.UserDpt = Kanbaninvpd.kanbaninvpd.UserDpt = dataTable.Rows[0]["DepartCode"].ToString();
                                this.UserDptName = Kanbaninvpd.kanbaninvpd.UserDptName = dataTable.Rows[0]["DepartName"].ToString();
                                this.UserDptType = Kanbaninvpd.kanbaninvpd.UserDptType = ((this.UserDpt == "01.07.04") ? "B" : "C");
                                this.UserDptType = Kanbaninvpd.kanbaninvpd.UserDptType = ((this.UserDpt == "00001") ? "A" : this.UserDptType);
                                if (this.UserDptName == this.label4.Text)
                                {
                                    Kanbaninvpd.kanbaninvpd.Show();
                                    Kanbaninvpd.kanbaninvpd.Visible = true;
                                    Kanbaninvpd.kanbaninvpd.pdUser.Text = this.UserDptName + this.name + "欢迎您";
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("当前扫描工序为:" + this.label4.Text + ",试图登陆用户的部门:" + this.UserDptName + ",不允许登陆","警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    logTextbox.Text = "";
                                }
                               

                            }
                            
                            else
                            {
                                
                                    this.logTextbox.Text = "";
                                    MessageBox.Show("登录信息不正确!");
                                
                               
                            }
                        }
                        else
                        {
                            this.logTextbox.Text = "";
                        }
                    }
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
             
            }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var pass =  Interaction.InputBox("请输入密码", "密码框");
            if (pass=="lonking37602000")
            {
                DepartForm departForm = new DepartForm();
                departForm.TopMost = true;
                departForm.loginForm = this;
                departForm.Show();
                
                
                
              
            }
            else
            {
                MessageBox.Show("密码错误");
                this.Show();
                
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

