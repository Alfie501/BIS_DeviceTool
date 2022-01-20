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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_Area = new System.Windows.Forms.GroupBox();
            this.dgv_Area = new System.Windows.Forms.DataGridView();
            this.grp_Device = new System.Windows.Forms.GroupBox();
            this.dgv_Device = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_Area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area)).BeginInit();
            this.grp_Device.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Device)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 309);
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
            this.splitContainer1.Size = new System.Drawing.Size(487, 309);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_Area
            // 
            this.grp_Area.Controls.Add(this.dgv_Area);
            this.grp_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Area.Location = new System.Drawing.Point(0, 0);
            this.grp_Area.Name = "grp_Area";
            this.grp_Area.Size = new System.Drawing.Size(162, 309);
            this.grp_Area.TabIndex = 2;
            this.grp_Area.TabStop = false;
            this.grp_Area.Text = "Area";
            // 
            // dgv_Area
            // 
            this.dgv_Area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Area.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgv_Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Area.Location = new System.Drawing.Point(3, 18);
            this.dgv_Area.Name = "dgv_Area";
            this.dgv_Area.RowHeadersVisible = false;
            this.dgv_Area.RowTemplate.Height = 24;
            this.dgv_Area.Size = new System.Drawing.Size(156, 288);
            this.dgv_Area.TabIndex = 0;
            // 
            // grp_Device
            // 
            this.grp_Device.Controls.Add(this.dgv_Device);
            this.grp_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Device.Location = new System.Drawing.Point(0, 0);
            this.grp_Device.Name = "grp_Device";
            this.grp_Device.Size = new System.Drawing.Size(321, 309);
            this.grp_Device.TabIndex = 2;
            this.grp_Device.TabStop = false;
            this.grp_Device.Text = "Device";
            // 
            // dgv_Device
            // 
            this.dgv_Device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Device.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1});
            this.dgv_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Device.Location = new System.Drawing.Point(3, 18);
            this.dgv_Device.Name = "dgv_Device";
            this.dgv_Device.RowHeadersVisible = false;
            this.dgv_Device.RowTemplate.Height = 24;
            this.dgv_Device.Size = new System.Drawing.Size(315, 288);
            this.dgv_Device.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn1
            // 
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
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FillWeight = 25F;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 25F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area Name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 25F;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            // 
            // DlgAreaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 309);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grp_Area;
        private System.Windows.Forms.DataGridView dgv_Area;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.GroupBox grp_Device;
        private System.Windows.Forms.DataGridView dgv_Device;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}