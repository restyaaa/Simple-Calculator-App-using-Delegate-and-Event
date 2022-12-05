
namespace TugasDelegateEvent
{
    partial class HasilOperasi
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
            this.OutputHasil = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutputHasil);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // OutputHasil
            // 
            this.OutputHasil.FormattingEnabled = true;
            this.OutputHasil.ItemHeight = 16;
            this.OutputHasil.Location = new System.Drawing.Point(6, 21);
            this.OutputHasil.Name = "OutputHasil";
            this.OutputHasil.Size = new System.Drawing.Size(579, 260);
            this.OutputHasil.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AccessibleName = "TombolHitung";
            this.button1.Location = new System.Drawing.Point(18, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(579, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Menghitung);
            // 
            // HasilOperasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "HasilOperasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox OutputHasil;
        private System.Windows.Forms.Button button1;
    }
}