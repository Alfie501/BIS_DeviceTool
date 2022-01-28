namespace BIS_DeviceTool
{
    partial class DlgAreaEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAreaEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_Area = new System.Windows.Forms.GroupBox();
            this.dgv_Area = new System.Windows.Forms.DataGridView();
            this.grp_Device = new System.Windows.Forms.GroupBox();
            this.dgv_Device = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_NewArea = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtn_Save = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Clear = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_NewDevice = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_CommandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_Area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area)).BeginInit();
            this.grp_Device.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Device)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 281);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_Area);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grp_Device);
            this.splitContainer1.Size = new System.Drawing.Size(712, 281);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_Area
            // 
            this.grp_Area.Controls.Add(this.dgv_Area);
            this.grp_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Area.Location = new System.Drawing.Point(0, 0);
            this.grp_Area.Name = "grp_Area";
            this.grp_Area.Size = new System.Drawing.Size(334, 281);
            this.grp_Area.TabIndex = 2;
            this.grp_Area.TabStop = false;
            this.grp_Area.Text = "Area";
            // 
            // dgv_Area
            // 
            this.dgv_Area.AllowUserToAddRows = false;
            this.dgv_Area.AllowUserToDeleteRows = false;
            this.dgv_Area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Area.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.area_CommandName});
            this.dgv_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Area.Location = new System.Drawing.Point(3, 18);
            this.dgv_Area.Name = "dgv_Area";
            this.dgv_Area.RowHeadersVisible = false;
            this.dgv_Area.RowTemplate.Height = 24;
            this.dgv_Area.ShowCellErrors = false;
            this.dgv_Area.ShowRowErrors = false;
            this.dgv_Area.Size = new System.Drawing.Size(328, 260);
            this.dgv_Area.TabIndex = 0;
            this.dgv_Area.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Area_CellDoubleClick);
            this.dgv_Area.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Area_CellValueChanged);
            // 
            // grp_Device
            // 
            this.grp_Device.Controls.Add(this.dgv_Device);
            this.grp_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Device.Location = new System.Drawing.Point(0, 0);
            this.grp_Device.Name = "grp_Device";
            this.grp_Device.Size = new System.Drawing.Size(374, 281);
            this.grp_Device.TabIndex = 2;
            this.grp_Device.TabStop = false;
            this.grp_Device.Text = "Device";
            // 
            // dgv_Device
            // 
            this.dgv_Device.AllowUserToAddRows = false;
            this.dgv_Device.AllowUserToDeleteRows = false;
            this.dgv_Device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Device.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Device.Location = new System.Drawing.Point(3, 18);
            this.dgv_Device.Name = "dgv_Device";
            this.dgv_Device.RowHeadersVisible = false;
            this.dgv_Device.RowTemplate.Height = 24;
            this.dgv_Device.Size = new System.Drawing.Size(368, 260);
            this.dgv_Device.TabIndex = 0;
            this.dgv_Device.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Device_CellClick);
            this.dgv_Device.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Device_CellValueChanged);
            this.dgv_Device.Leave += new System.EventHandler(this.dgv_Device_Leave);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = true;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCheckBoxColumn1.FillWeight = 25F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Model Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_NewArea,
            this.tsBtn_Delete,
            this.toolStripSeparator1,
            this.tsBtn_Save,
            this.tsBtn_Clear,
            this.tsBtn_NewDevice});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(712, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsBtn_NewArea
            // 
            this.tsBtn_NewArea.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_NewArea.Image")));
            this.tsBtn_NewArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_NewArea.Name = "tsBtn_NewArea";
            this.tsBtn_NewArea.Size = new System.Drawing.Size(79, 22);
            this.tsBtn_NewArea.Text = "NewArea";
            this.tsBtn_NewArea.Click += new System.EventHandler(this.Btn_NewArea_Click);
            // 
            // tsBtn_Delete
            // 
            this.tsBtn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Delete.Image")));
            this.tsBtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Delete.Name = "tsBtn_Delete";
            this.tsBtn_Delete.Size = new System.Drawing.Size(64, 22);
            this.tsBtn_Delete.Text = "Delete";
            this.tsBtn_Delete.Click += new System.EventHandler(this.tsBtn_Delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtn_Save
            // 
            this.tsBtn_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Save.Image")));
            this.tsBtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Save.Name = "tsBtn_Save";
            this.tsBtn_Save.Size = new System.Drawing.Size(54, 22);
            this.tsBtn_Save.Text = "Save";
            this.tsBtn_Save.Click += new System.EventHandler(this.tsBtn_Save_Click);
            // 
            // tsBtn_Clear
            // 
            this.tsBtn_Clear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Clear.Image")));
            this.tsBtn_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Clear.Name = "tsBtn_Clear";
            this.tsBtn_Clear.Size = new System.Drawing.Size(56, 22);
            this.tsBtn_Clear.Text = "Clear";
            this.tsBtn_Clear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tsBtn_NewDevice
            // 
            this.tsBtn_NewDevice.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtn_NewDevice.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_NewDevice.Image")));
            this.tsBtn_NewDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_NewDevice.Name = "tsBtn_NewDevice";
            this.tsBtn_NewDevice.Size = new System.Drawing.Size(91, 22);
            this.tsBtn_NewDevice.Text = "NewDevice";
            this.tsBtn_NewDevice.Click += new System.EventHandler(this.tsBtn_NewDevice_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = true;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.FillWeight = 25F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area Name";
            this.Column2.Name = "Column2";
            // 
            // area_CommandName
            // 
            this.area_CommandName.HeaderText = "Command Name";
            this.area_CommandName.Name = "area_CommandName";
            this.area_CommandName.ReadOnly = true;
            this.area_CommandName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.area_CommandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DlgAreaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 308);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgAreaEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grp_Area.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area)).EndInit();
            this.grp_Device.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Device)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grp_Area;
        private System.Windows.Forms.DataGridView dgv_Area;
        private System.Windows.Forms.GroupBox grp_Device;
        private System.Windows.Forms.DataGridView dgv_Device;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBtn_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtn_Save;
        private System.Windows.Forms.ToolStripButton tsBtn_Clear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton tsBtn_NewArea;
        private System.Windows.Forms.ToolStripButton tsBtn_NewDevice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_CommandName;
    }
}