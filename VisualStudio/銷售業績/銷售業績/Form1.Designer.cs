namespace 銷售業績
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ballpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allsold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "業務員業績";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ballpen,
            this.pencil,
            this.eraser,
            this.ruler,
            this.RE,
            this.allsold});
            this.dataGridView1.Location = new System.Drawing.Point(45, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(907, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Ballpen
            // 
            this.Ballpen.DataPropertyName = "Ballpen";
            this.Ballpen.HeaderText = "原子筆";
            this.Ballpen.Name = "Ballpen";
            // 
            // pencil
            // 
            this.pencil.DataPropertyName = "pencil";
            this.pencil.HeaderText = "鉛筆";
            this.pencil.Name = "pencil";
            // 
            // eraser
            // 
            this.eraser.DataPropertyName = "eraser";
            this.eraser.HeaderText = "橡皮擦";
            this.eraser.Name = "eraser";
            // 
            // ruler
            // 
            this.ruler.DataPropertyName = "ruler";
            this.ruler.HeaderText = "尺";
            this.ruler.Name = "ruler";
            // 
            // RE
            // 
            this.RE.DataPropertyName = "RE";
            this.RE.HeaderText = "立可白";
            this.RE.Name = "RE";
            // 
            // allsold
            // 
            this.allsold.DataPropertyName = "allsold";
            this.allsold.HeaderText = "銷售總金額";
            this.allsold.Name = "allsold";
            this.allsold.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ballpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn allsold;
    }
}

