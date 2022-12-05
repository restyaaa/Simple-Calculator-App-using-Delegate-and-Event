
namespace TugasDelegateEvent
{
    partial class Kalkulator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OperasiPilihan = new System.Windows.Forms.ComboBox();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.ProsesNilai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // OperasiPilihan
            // 
            this.OperasiPilihan.FormattingEnabled = true;
            this.OperasiPilihan.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.OperasiPilihan.Location = new System.Drawing.Point(87, 36);
            this.OperasiPilihan.Name = "OperasiPilihan";
            this.OperasiPilihan.Size = new System.Drawing.Size(215, 24);
            this.OperasiPilihan.TabIndex = 3;
            // 
            // NilaiA
            // 
            this.NilaiA.AccessibleName = "NilaiA";
            this.NilaiA.Location = new System.Drawing.Point(87, 68);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(215, 22);
            this.NilaiA.TabIndex = 4;
            // 
            // NilaiB
            // 
            this.NilaiB.AccessibleName = "NilaiB";
            this.NilaiB.Location = new System.Drawing.Point(87, 96);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(215, 22);
            this.NilaiB.TabIndex = 5;
            // 
            // ProsesNilai
            // 
            this.ProsesNilai.AccessibleName = "ProsesNilai";
            this.ProsesNilai.Location = new System.Drawing.Point(224, 137);
            this.ProsesNilai.Name = "ProsesNilai";
            this.ProsesNilai.Size = new System.Drawing.Size(78, 39);
            this.ProsesNilai.TabIndex = 6;
            this.ProsesNilai.Text = "Proses";
            this.ProsesNilai.UseVisualStyleBackColor = true;
            this.ProsesNilai.Click += new System.EventHandler(this.Click_Proses);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 188);
            this.Controls.Add(this.ProsesNilai);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.OperasiPilihan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kalkulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OperasiPilihan;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.Button ProsesNilai;
    }
}