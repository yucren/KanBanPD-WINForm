namespace LonKingKanBanPD
{
    partial class Kanbaninvpd
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.kanbanNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fbillnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fItemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fProTecIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bustypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fConfigIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kanbanInvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdBtn = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.Label();
            this.pdUser = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.exitLoginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanInvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(291, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "看板编号:";
            // 
            // kanbanNo
            // 
            this.kanbanNo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kanbanNo.Location = new System.Drawing.Point(435, 31);
            this.kanbanNo.Name = "kanbanNo";
            this.kanbanNo.Size = new System.Drawing.Size(282, 31);
            this.kanbanNo.TabIndex = 1;
            this.kanbanNo.TextChanged += new System.EventHandler(this.kanbanNo_TextChanged);
            this.kanbanNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kanbanNo_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fbillnoDataGridViewTextBoxColumn,
            this.fItemCodeDataGridViewTextBoxColumn,
            this.fItemNameDataGridViewTextBoxColumn,
            this.fModelDataGridViewTextBoxColumn,
            this.fProTecIDDataGridViewTextBoxColumn,
            this.bustypeDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.fConfigIDDataGridViewTextBoxColumn,
            this.fcountDataGridViewTextBoxColumn,
            this.FDCount,
            this.IsPD});
            this.dataGridView1.DataSource = this.kanbanInvBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 187);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged_1);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // fbillnoDataGridViewTextBoxColumn
            // 
            this.fbillnoDataGridViewTextBoxColumn.DataPropertyName = "Fbillno";
            this.fbillnoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.fbillnoDataGridViewTextBoxColumn.HeaderText = "执行看板编号";
            this.fbillnoDataGridViewTextBoxColumn.Name = "fbillnoDataGridViewTextBoxColumn";
            this.fbillnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fbillnoDataGridViewTextBoxColumn.Width = 199;
            // 
            // fItemCodeDataGridViewTextBoxColumn
            // 
            this.fItemCodeDataGridViewTextBoxColumn.DataPropertyName = "FItemCode";
            this.fItemCodeDataGridViewTextBoxColumn.HeaderText = "料号";
            this.fItemCodeDataGridViewTextBoxColumn.Name = "fItemCodeDataGridViewTextBoxColumn";
            this.fItemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fItemCodeDataGridViewTextBoxColumn.Width = 91;
            // 
            // fItemNameDataGridViewTextBoxColumn
            // 
            this.fItemNameDataGridViewTextBoxColumn.DataPropertyName = "FItemName";
            this.fItemNameDataGridViewTextBoxColumn.HeaderText = "品名";
            this.fItemNameDataGridViewTextBoxColumn.Name = "fItemNameDataGridViewTextBoxColumn";
            this.fItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fItemNameDataGridViewTextBoxColumn.Width = 91;
            // 
            // fModelDataGridViewTextBoxColumn
            // 
            this.fModelDataGridViewTextBoxColumn.DataPropertyName = "FModel";
            this.fModelDataGridViewTextBoxColumn.HeaderText = "规格型号";
            this.fModelDataGridViewTextBoxColumn.Name = "fModelDataGridViewTextBoxColumn";
            this.fModelDataGridViewTextBoxColumn.ReadOnly = true;
            this.fModelDataGridViewTextBoxColumn.Width = 145;
            // 
            // fProTecIDDataGridViewTextBoxColumn
            // 
            this.fProTecIDDataGridViewTextBoxColumn.DataPropertyName = "FProTecID";
            this.fProTecIDDataGridViewTextBoxColumn.HeaderText = "FProTecID";
            this.fProTecIDDataGridViewTextBoxColumn.Name = "fProTecIDDataGridViewTextBoxColumn";
            this.fProTecIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fProTecIDDataGridViewTextBoxColumn.Visible = false;
            this.fProTecIDDataGridViewTextBoxColumn.Width = 163;
            // 
            // bustypeDataGridViewTextBoxColumn
            // 
            this.bustypeDataGridViewTextBoxColumn.DataPropertyName = "Bustype";
            this.bustypeDataGridViewTextBoxColumn.HeaderText = "Bustype";
            this.bustypeDataGridViewTextBoxColumn.Name = "bustypeDataGridViewTextBoxColumn";
            this.bustypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bustypeDataGridViewTextBoxColumn.Visible = false;
            this.bustypeDataGridViewTextBoxColumn.Width = 135;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "扫描点";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fNameDataGridViewTextBoxColumn.Width = 118;
            // 
            // fConfigIDDataGridViewTextBoxColumn
            // 
            this.fConfigIDDataGridViewTextBoxColumn.DataPropertyName = "FConfigID";
            this.fConfigIDDataGridViewTextBoxColumn.HeaderText = "FConfigID";
            this.fConfigIDDataGridViewTextBoxColumn.Name = "fConfigIDDataGridViewTextBoxColumn";
            this.fConfigIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fConfigIDDataGridViewTextBoxColumn.Visible = false;
            this.fConfigIDDataGridViewTextBoxColumn.Width = 163;
            // 
            // fcountDataGridViewTextBoxColumn
            // 
            this.fcountDataGridViewTextBoxColumn.DataPropertyName = "Fcount";
            this.fcountDataGridViewTextBoxColumn.HeaderText = "库存数量";
            this.fcountDataGridViewTextBoxColumn.Name = "fcountDataGridViewTextBoxColumn";
            this.fcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.fcountDataGridViewTextBoxColumn.Width = 145;
            // 
            // FDCount
            // 
            this.FDCount.DataPropertyName = "FDCount";
            this.FDCount.HeaderText = "盘点数量";
            this.FDCount.Name = "FDCount";
            this.FDCount.Width = 145;
            // 
            // IsPD
            // 
            this.IsPD.HeaderText = "是否盘点";
            this.IsPD.Name = "IsPD";
            this.IsPD.ReadOnly = true;
            this.IsPD.Width = 126;
            // 
            // kanbanInvBindingSource
            // 
            this.kanbanInvBindingSource.DataSource = typeof(LonKingKanBanPD.KbanBanInv);
            // 
            // pdBtn
            // 
            this.pdBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pdBtn.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pdBtn.Location = new System.Drawing.Point(354, 446);
            this.pdBtn.Name = "pdBtn";
            this.pdBtn.Size = new System.Drawing.Size(487, 60);
            this.pdBtn.TabIndex = 3;
            this.pdBtn.Text = "盘点";
            this.pdBtn.UseVisualStyleBackColor = true;
            this.pdBtn.Click += new System.EventHandler(this.pdBtn_Click);
            // 
            // errMessage
            // 
            this.errMessage.AutoSize = true;
            this.errMessage.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.errMessage.Location = new System.Drawing.Point(734, 37);
            this.errMessage.Name = "errMessage";
            this.errMessage.Size = new System.Drawing.Size(34, 21);
            this.errMessage.TabIndex = 4;
            this.errMessage.Text = "11";
            // 
            // pdUser
            // 
            this.pdUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pdUser.AutoSize = true;
            this.pdUser.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pdUser.Location = new System.Drawing.Point(12, 35);
            this.pdUser.Name = "pdUser";
            this.pdUser.Size = new System.Drawing.Size(82, 21);
            this.pdUser.TabIndex = 5;
            this.pdUser.Text = "label2";
            this.pdUser.Click += new System.EventHandler(this.pdUser_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "后道库存"});
            this.comboBox1.Location = new System.Drawing.Point(176, 452);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logRichTextBox.Location = new System.Drawing.Point(35, 292);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(553, 129);
            this.logRichTextBox.TabIndex = 7;
            this.logRichTextBox.Text = "";
            this.logRichTextBox.Visible = false;
            // 
            // exitLoginBtn
            // 
            this.exitLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitLoginBtn.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitLoginBtn.Location = new System.Drawing.Point(35, 452);
            this.exitLoginBtn.Name = "exitLoginBtn";
            this.exitLoginBtn.Size = new System.Drawing.Size(153, 45);
            this.exitLoginBtn.TabIndex = 8;
            this.exitLoginBtn.Text = "退出登陆";
            this.exitLoginBtn.UseVisualStyleBackColor = true;
            this.exitLoginBtn.Click += new System.EventHandler(this.exitLoginBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(885, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "字体设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kanbaninvpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1076, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitLoginBtn);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pdUser);
            this.Controls.Add(this.errMessage);
            this.Controls.Add(this.pdBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kanbanNo);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Kanbaninvpd";
            this.Text = "上海机械看板盘点";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kanbaninvpd_Load);
            this.Click += new System.EventHandler(this.Kanbaninvpd_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kanbaninvpd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanInvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kanbanNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pdBtn;
        private System.Windows.Forms.Label errMessage;
        private System.Windows.Forms.BindingSource kanbanInvBindingSource;
        internal System.Windows.Forms.Label pdUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Button exitLoginBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fbillnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fItemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fProTecIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bustypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fConfigIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

