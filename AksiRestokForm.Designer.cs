namespace MiewPos
{
    partial class AksiRestokForm
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
            this.hapus = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUid = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(82, 191);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(101, 36);
            this.hapus.TabIndex = 0;
            this.hapus.Text = "Hapus Barang";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(236, 191);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(101, 36);
            this.edit.TabIndex = 0;
            this.edit.Text = "Edit Barang";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // batal
            // 
            this.batal.Location = new System.Drawing.Point(400, 191);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(101, 36);
            this.batal.TabIndex = 0;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perhatian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uid :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama :";
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUid.Location = new System.Drawing.Point(195, 74);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(129, 20);
            this.lbUid.TabIndex = 2;
            this.lbUid.Text = "XXXXXXXXXX";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(208, 111);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(160, 24);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "XXXXXXXXXX";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(82, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // AksiRestokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbUid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AksiRestokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AksiRestokForm";
            this.Load += new System.EventHandler(this.AksiRestokForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUid;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}