namespace BIS_DeviceTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_On = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Off = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsTxt_CommandName = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtn_Copy = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Cut = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Paste = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Delete = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Edit = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_SN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ModelName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Off = new System.Windows.Forms.Button();
            this.btn_On = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsCmb_Area = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsCmb_IP = new System.Windows.Forms.ToolStripComboBox();
            this.tsBtn_AppendArea = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_On)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Off)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.95951F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 494);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 389);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 362);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_On);
            this.tabPage1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "On";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_On
            // 
            this.dgv_On.AllowUserToResizeRows = false;
            this.dgv_On.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_On.BackgroundColor = System.Drawing.Color.White;
            this.dgv_On.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_On.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_On.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_On.Location = new System.Drawing.Point(3, 3);
            this.dgv_On.Name = "dgv_On";
            this.dgv_On.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_On.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_On.RowTemplate.Height = 24;
            this.dgv_On.Size = new System.Drawing.Size(485, 325);
            this.dgv_On.TabIndex = 2;
            this.dgv_On.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_On_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = true;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Command";
            this.Column2.Name = "Column2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_Off);
            this.tabPage2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Off";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_Off
            // 
            this.dgv_Off.AllowUserToDeleteRows = false;
            this.dgv_Off.AllowUserToResizeRows = false;
            this.dgv_Off.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Off.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Off.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Off.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgv_Off.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Off.Location = new System.Drawing.Point(3, 3);
            this.dgv_Off.Name = "dgv_Off";
            this.dgv_Off.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Off.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Off.RowTemplate.Height = 24;
            this.dgv_Off.Size = new System.Drawing.Size(485, 325);
            this.dgv_Off.TabIndex = 3;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = true;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCheckBoxColumn1.FillWeight = 10F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Command";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxt_CommandName,
            this.tsBtn_Copy,
            this.tsBtn_Cut,
            this.tsBtn_Paste,
            this.tsBtn_Delete,
            this.tsBtn_Edit,
            this.tsBtn_Save,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(499, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsTxt_CommandName
            // 
            this.tsTxt_CommandName.Name = "tsTxt_CommandName";
            this.tsTxt_CommandName.Size = new System.Drawing.Size(100, 25);
            this.tsTxt_CommandName.TextChanged += new System.EventHandler(this.TsTxtCmdName_TextChanged);
            // 
            // tsBtn_Copy
            // 
            this.tsBtn_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Copy.Image")));
            this.tsBtn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Copy.Name = "tsBtn_Copy";
            this.tsBtn_Copy.Size = new System.Drawing.Size(57, 22);
            this.tsBtn_Copy.Text = "Copy";
            this.tsBtn_Copy.Click += new System.EventHandler(this.TsBtn_Copy_Click);
            // 
            // tsBtn_Cut
            // 
            this.tsBtn_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Cut.Image")));
            this.tsBtn_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Cut.Name = "tsBtn_Cut";
            this.tsBtn_Cut.Size = new System.Drawing.Size(46, 22);
            this.tsBtn_Cut.Text = "Cut";
            this.tsBtn_Cut.Click += new System.EventHandler(this.TsBtn_Cut_Click);
            // 
            // tsBtn_Paste
            // 
            this.tsBtn_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Paste.Image")));
            this.tsBtn_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Paste.Name = "tsBtn_Paste";
            this.tsBtn_Paste.Size = new System.Drawing.Size(57, 22);
            this.tsBtn_Paste.Text = "Paste";
            this.tsBtn_Paste.Click += new System.EventHandler(this.TsBtn_Paste_Click);
            // 
            // tsBtn_Delete
            // 
            this.tsBtn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Delete.Image")));
            this.tsBtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Delete.Name = "tsBtn_Delete";
            this.tsBtn_Delete.Size = new System.Drawing.Size(64, 22);
            this.tsBtn_Delete.Text = "Delete";
            this.tsBtn_Delete.Click += new System.EventHandler(this.TsBtn_Delete_Click);
            // 
            // tsBtn_Edit
            // 
            this.tsBtn_Edit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Edit.Image")));
            this.tsBtn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Edit.Name = "tsBtn_Edit";
            this.tsBtn_Edit.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_Edit.Text = "Edit";
            this.tsBtn_Edit.Click += new System.EventHandler(this.TsBtn_Edit_Click);
            // 
            // tsBtn_Save
            // 
            this.tsBtn_Save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Save.Image")));
            this.tsBtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Save.Name = "tsBtn_Save";
            this.tsBtn_Save.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_Save.Text = "Save";
            this.tsBtn_Save.Click += new System.EventHandler(this.TsBtn_Save_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Clear";
            this.toolStripButton1.Click += new System.EventHandler(this.BtnClear1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 93);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.56731F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.43269F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.49383F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.50617F));
            this.tableLayoutPanel3.Controls.Add(this.txt_SN, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_ModelName, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(392, 62);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txt_SN
            // 
            this.txt_SN.BackColor = System.Drawing.Color.White;
            this.txt_SN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SN.Enabled = false;
            this.txt_SN.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_SN.Location = new System.Drawing.Point(142, 34);
            this.txt_SN.Name = "txt_SN";
            this.txt_SN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SN.Size = new System.Drawing.Size(247, 25);
            this.txt_SN.TabIndex = 3;
            this.txt_SN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "S/N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ModelName
            // 
            this.txt_ModelName.BackColor = System.Drawing.Color.White;
            this.txt_ModelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ModelName.Enabled = false;
            this.txt_ModelName.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ModelName.Location = new System.Drawing.Point(142, 3);
            this.txt_ModelName.Name = "txt_ModelName";
            this.txt_ModelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ModelName.Size = new System.Drawing.Size(247, 25);
            this.txt_ModelName.TabIndex = 1;
            this.txt_ModelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Off, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_On, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(401, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(80, 61);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_Off
            // 
            this.btn_Off.BackColor = System.Drawing.Color.Red;
            this.btn_Off.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Off.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Off.ForeColor = System.Drawing.Color.White;
            this.btn_Off.Location = new System.Drawing.Point(3, 33);
            this.btn_Off.Name = "btn_Off";
            this.btn_Off.Size = new System.Drawing.Size(74, 25);
            this.btn_Off.TabIndex = 1;
            this.btn_Off.Text = "Off";
            this.btn_Off.UseVisualStyleBackColor = false;
            this.btn_Off.Click += new System.EventHandler(this.Btn_Off_Click);
            // 
            // btn_On
            // 
            this.btn_On.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_On.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_On.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_On.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_On.ForeColor = System.Drawing.Color.White;
            this.btn_On.Location = new System.Drawing.Point(3, 3);
            this.btn_On.Name = "btn_On";
            this.btn_On.Size = new System.Drawing.Size(74, 24);
            this.btn_On.TabIndex = 0;
            this.btn_On.Text = "On";
            this.btn_On.UseVisualStyleBackColor = false;
            this.btn_On.Click += new System.EventHandler(this.Btn_On_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsCmb_Area,
            this.toolStripLabel2,
            this.tsCmb_IP,
            this.tsBtn_AppendArea});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(501, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Area";
            // 
            // tsCmb_Area
            // 
            this.tsCmb_Area.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsCmb_Area.Name = "tsCmb_Area";
            this.tsCmb_Area.Size = new System.Drawing.Size(75, 25);
            this.tsCmb_Area.SelectedIndexChanged += new System.EventHandler(this.TsCmbArea_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel2.Text = "  IP";
            // 
            // tsCmb_IP
            // 
            this.tsCmb_IP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsCmb_IP.Name = "tsCmb_IP";
            this.tsCmb_IP.Size = new System.Drawing.Size(121, 25);
            this.tsCmb_IP.SelectedIndexChanged += new System.EventHandler(this.TsCmbIP_SelectedIndexChanged);
            // 
            // tsBtn_AppendArea
            // 
            this.tsBtn_AppendArea.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtn_AppendArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_AppendArea.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_AppendArea.Image")));
            this.tsBtn_AppendArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_AppendArea.Name = "tsBtn_AppendArea";
            this.tsBtn_AppendArea.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_AppendArea.Text = "Append Area";
            this.tsBtn_AppendArea.Click += new System.EventHandler(this.TsBtn_AppendArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上層設備控制工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_On)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Off)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tsCmb_Area;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tsCmb_IP;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBtn_Copy;
        private System.Windows.Forms.ToolStripButton tsBtn_Paste;
        private System.Windows.Forms.ToolStripButton tsBtn_Delete;
        private System.Windows.Forms.ToolStripButton tsBtn_Edit;
        private System.Windows.Forms.ToolStripButton tsBtn_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_SN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ModelName;
        private System.Windows.Forms.ToolStripButton tsBtn_Cut;
        private System.Windows.Forms.ToolStripButton tsBtn_AppendArea;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_On;
        private System.Windows.Forms.Button btn_Off;
        private System.Windows.Forms.ToolStripTextBox tsTxt_CommandName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_On;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Off;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

