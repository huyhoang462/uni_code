namespace VD
{
    partial class timSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            this.kqtk = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kqtk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập MSSV/Tên";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(254, 55);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(396, 30);
            this.searchBox.TabIndex = 1;
            // 
            // searchBut
            // 
            this.searchBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBut.Location = new System.Drawing.Point(720, 54);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(104, 32);
            this.searchBut.TabIndex = 2;
            this.searchBut.Text = "Tìm";
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // kqtk
            // 
            this.kqtk.AllowUserToDeleteRows = false;
            this.kqtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kqtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kqtk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.lop,
            this.ms,
            this.name,
            this.dt,
            this.dv,
            this.da,
            this.dtb});
            this.kqtk.Location = new System.Drawing.Point(20, 189);
            this.kqtk.Name = "kqtk";
            this.kqtk.ReadOnly = true;
            this.kqtk.RowHeadersWidth = 51;
            this.kqtk.RowTemplate.Height = 24;
            this.kqtk.Size = new System.Drawing.Size(856, 411);
            this.kqtk.TabIndex = 4;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.ReadOnly = true;
            this.lop.Width = 75;
            // 
            // ms
            // 
            this.ms.HeaderText = "MSSV";
            this.ms.MinimumWidth = 6;
            this.ms.Name = "ms";
            this.ms.ReadOnly = true;
            this.ms.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Họ Tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // dt
            // 
            this.dt.HeaderText = "Toán";
            this.dt.MinimumWidth = 6;
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.Width = 50;
            // 
            // dv
            // 
            this.dv.HeaderText = "Văn";
            this.dv.MinimumWidth = 6;
            this.dv.Name = "dv";
            this.dv.ReadOnly = true;
            this.dv.Width = 50;
            // 
            // da
            // 
            this.da.HeaderText = "Anh";
            this.da.MinimumWidth = 6;
            this.da.Name = "da";
            this.da.ReadOnly = true;
            this.da.Width = 50;
            // 
            // dtb
            // 
            this.dtb.HeaderText = "Trung bình";
            this.dtb.MinimumWidth = 6;
            this.dtb.Name = "dtb";
            this.dtb.ReadOnly = true;
            this.dtb.Width = 50;
            // 
            // timSV
            // 
            this.AcceptButton = this.searchBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 621);
            this.Controls.Add(this.kqtk);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "timSV";
            this.Text = "timSV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.timSV_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kqtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.DataGridView kqtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ms;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn da;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
    }
}