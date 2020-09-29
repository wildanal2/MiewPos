namespace MiewPos
{
    partial class RestockForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comboport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveRestock = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbHargaTotalBarang = new System.Windows.Forms.TextBox();
            this.dateKulakan = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbNamaToko = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.comboport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(98, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 43);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // comboport
            // 
            this.comboport.FormattingEnabled = true;
            this.comboport.Location = new System.Drawing.Point(13, 39);
            this.comboport.Name = "comboport";
            this.comboport.Size = new System.Drawing.Size(74, 21);
            this.comboport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.labelCode);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bar-Code";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(176, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 47);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // labelCode
            // 
            this.labelCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(6, 19);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(207, 46);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "____________";
            this.labelCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 354);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSaveRestock
            // 
            this.btnSaveRestock.Location = new System.Drawing.Point(679, 414);
            this.btnSaveRestock.Name = "btnSaveRestock";
            this.btnSaveRestock.Size = new System.Drawing.Size(217, 43);
            this.btnSaveRestock.TabIndex = 3;
            this.btnSaveRestock.Text = "Simpan";
            this.btnSaveRestock.UseVisualStyleBackColor = true;
            this.btnSaveRestock.Click += new System.EventHandler(this.btnSaveRestock_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbHargaTotalBarang);
            this.groupBox3.Location = new System.Drawing.Point(669, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Harga";
            // 
            // lbHargaTotalBarang
            // 
            this.lbHargaTotalBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHargaTotalBarang.Location = new System.Drawing.Point(10, 19);
            this.lbHargaTotalBarang.Multiline = true;
            this.lbHargaTotalBarang.Name = "lbHargaTotalBarang";
            this.lbHargaTotalBarang.ReadOnly = true;
            this.lbHargaTotalBarang.Size = new System.Drawing.Size(217, 42);
            this.lbHargaTotalBarang.TabIndex = 0;
            this.lbHargaTotalBarang.Text = "Rp 10.000.000";
            this.lbHargaTotalBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateKulakan
            // 
            this.dateKulakan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKulakan.CustomFormat = "yyyy-MM-dd H:m:s";
            this.dateKulakan.Location = new System.Drawing.Point(6, 24);
            this.dateKulakan.Name = "dateKulakan";
            this.dateKulakan.Size = new System.Drawing.Size(244, 20);
            this.dateKulakan.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateKulakan);
            this.groupBox4.Location = new System.Drawing.Point(640, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 61);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tanggal Kulakan";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbNamaToko);
            this.groupBox5.Location = new System.Drawing.Point(669, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 63);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nama Toko Kulakan";
            // 
            // tbNamaToko
            // 
            this.tbNamaToko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaToko.Location = new System.Drawing.Point(10, 21);
            this.tbNamaToko.Multiline = true;
            this.tbNamaToko.Name = "tbNamaToko";
            this.tbNamaToko.Size = new System.Drawing.Size(217, 33);
            this.tbNamaToko.TabIndex = 0;
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 469);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveRestock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "RestockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestockForm";
            this.Activated += new System.EventHandler(this.RestockForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RestockForm_FormClosing);
            this.Load += new System.EventHandler(this.RestockForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveRestock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox lbHargaTotalBarang;
        private System.Windows.Forms.DateTimePicker dateKulakan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbNamaToko;
    }
}