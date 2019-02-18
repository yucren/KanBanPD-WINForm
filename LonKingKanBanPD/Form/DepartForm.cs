using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace LonKingKanBanPD
{
    public partial class DepartForm : Form
    {
        public LoginForm loginForm;
        public DepartForm()
        {
            InitializeComponent();
            this.FormClosed += DepartForm_FormClosed;
        }

        private void DepartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
            loginForm.label4.Text = comboBox1.SelectedValue.ToString();



        }

        private void DepartForm_Load(object sender, EventArgs e)
        {
           
            using (KanbanModal db =new KanbanModal())
            {
              //  MessageBox.Show(db.Database.Connection.ConnectionString);
                comboBox1.DataSource = db.LKM_Depart.ToList<LKM_Depart>();
                comboBox1.DisplayMember = "DepartName";
                comboBox1.ValueMember = "DepartName";
                comboBox1.SelectedText = loginForm.label4.Text;
                comboBox1.SelectedValue = loginForm.label4.Text;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //   MessageBox.Show(comboBox1.SelectedValue.ToString());
                //  ConfigurationManager.AppSettings["PDDepart"] = comboBox1.SelectedValue.ToString();
                Configuration configuration = ConfigurationManager.OpenExeConfiguration("./LonKingKanBanPD.exe");
                configuration.AppSettings.Settings["PDDepart"].Value = comboBox1.SelectedValue.ToString();
                configuration.Save();
                
                MessageBox.Show("扫描部门更改成功");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
            


        }
    }
}
