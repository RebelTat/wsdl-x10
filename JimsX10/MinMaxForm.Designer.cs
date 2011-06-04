namespace JimsX10
{
    partial class MinMaxForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WCMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sensor,
            this.TMin,
            this.Tmax,
            this.ATMin,
            this.ATMax,
            this.DPMin,
            this.DPMax,
            this.RelMin,
            this.RelMax,
            this.WCMin,
            this.HIMax});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(602, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sensor
            // 
            this.Sensor.HeaderText = "Sensor";
            this.Sensor.Name = "Sensor";
            this.Sensor.Width = 50;
            // 
            // TMin
            // 
            this.TMin.HeaderText = "TMin";
            this.TMin.Name = "TMin";
            this.TMin.Width = 50;
            // 
            // Tmax
            // 
            this.Tmax.HeaderText = "Tmax";
            this.Tmax.Name = "Tmax";
            this.Tmax.Width = 50;
            // 
            // ATMin
            // 
            this.ATMin.HeaderText = "ATMin";
            this.ATMin.Name = "ATMin";
            this.ATMin.Width = 50;
            // 
            // ATMax
            // 
            this.ATMax.HeaderText = "ATMax";
            this.ATMax.Name = "ATMax";
            this.ATMax.Width = 50;
            // 
            // DPMin
            // 
            this.DPMin.HeaderText = "DPMin";
            this.DPMin.Name = "DPMin";
            this.DPMin.Width = 50;
            // 
            // DPMax
            // 
            this.DPMax.HeaderText = "DPMax";
            this.DPMax.Name = "DPMax";
            this.DPMax.Width = 50;
            // 
            // RelMin
            // 
            this.RelMin.HeaderText = "RelMin";
            this.RelMin.Name = "RelMin";
            this.RelMin.Width = 50;
            // 
            // RelMax
            // 
            this.RelMax.HeaderText = "RelMax";
            this.RelMax.Name = "RelMax";
            this.RelMax.Width = 50;
            // 
            // WCMin
            // 
            this.WCMin.HeaderText = "WCMin";
            this.WCMin.Name = "WCMin";
            this.WCMin.Width = 50;
            // 
            // HIMax
            // 
            this.HIMax.HeaderText = "HIMax";
            this.HIMax.Name = "HIMax";
            this.HIMax.Width = 50;
            // 
            // MinMaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 259);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MinMaxForm";
            this.Text = "MinMaxForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn WCMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIMax;
    }
}