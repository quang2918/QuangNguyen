namespace quanlybanhang.Views
{
    partial class hanghoa
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb1.Controls.Add(this.numUD);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.txtdongia);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.txtten);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.txtma);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gb1.Location = new System.Drawing.Point(3, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(316, 228);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin nhân viên";
            // 
            // numUD
            // 
            this.numUD.Location = new System.Drawing.Point(127, 128);
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(158, 23);
            this.numUD.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng";
            // 
            // txtdongia
            // 
            this.txtdongia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtdongia.Location = new System.Drawing.Point(127, 168);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(158, 21);
            this.txtdongia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(19, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đơn giá";
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtten.Location = new System.Drawing.Point(127, 87);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(158, 21);
            this.txtten.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hàng";
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtma.Location = new System.Drawing.Point(127, 39);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(158, 21);
            this.txtma.TabIndex = 1;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hóa";
            // 
            // gb2
            // 
            this.gb2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb2.Controls.Add(this.dataGridView1);
            this.gb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gb2.Location = new System.Drawing.Point(325, 3);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(432, 353);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // btthem
            // 
            this.btthem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btthem.Location = new System.Drawing.Point(46, 252);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 38);
            this.btthem.TabIndex = 5;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsua.Location = new System.Drawing.Point(178, 252);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 38);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btxoa.Location = new System.Drawing.Point(46, 313);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 41);
            this.btxoa.TabIndex = 7;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btluu
            // 
            this.btluu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btluu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btluu.Location = new System.Drawing.Point(178, 313);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 41);
            this.btluu.TabIndex = 8;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // hanghoa
            // 
            this.AcceptButton = this.btthem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 368);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "hanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hanghoa";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.NumericUpDown numUD;
    }
}