namespace Taksit
{
    partial class Form1
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
            this.lblTutar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rb2Taksit = new System.Windows.Forms.RadioButton();
            this.rb3Taksit = new System.Windows.Forms.RadioButton();
            this.rb4Taksit = new System.Windows.Forms.RadioButton();
            this.rb5Taksit = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rb5Taksit);
            this.groupBox1.Controls.Add(this.rb4Taksit);
            this.groupBox1.Controls.Add(this.rb3Taksit);
            this.groupBox1.Controls.Add(this.rb2Taksit);
            this.groupBox1.Controls.Add(this.rbTek);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(9, 47);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(76, 13);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Toplam Tutar :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnOde
            // 
            this.btnOde.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOde.Location = new System.Drawing.Point(48, 347);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(143, 33);
            this.btnOde.TabIndex = 3;
            this.btnOde.Text = "Ödeme Yap ";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbTek.Location = new System.Drawing.Point(7, 45);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(76, 17);
            this.rbTek.TabIndex = 0;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "Tek Çekim";
            this.rbTek.UseVisualStyleBackColor = false;
            // 
            // rb2Taksit
            // 
            this.rb2Taksit.AutoSize = true;
            this.rb2Taksit.Location = new System.Drawing.Point(7, 77);
            this.rb2Taksit.Name = "rb2Taksit";
            this.rb2Taksit.Size = new System.Drawing.Size(120, 17);
            this.rb2Taksit.TabIndex = 1;
            this.rb2Taksit.TabStop = true;
            this.rb2Taksit.Text = "2 Taksit(%5 ek fiyat)";
            this.rb2Taksit.UseVisualStyleBackColor = true;
            // 
            // rb3Taksit
            // 
            this.rb3Taksit.AutoSize = true;
            this.rb3Taksit.Location = new System.Drawing.Point(7, 112);
            this.rb3Taksit.Name = "rb3Taksit";
            this.rb3Taksit.Size = new System.Drawing.Size(120, 17);
            this.rb3Taksit.TabIndex = 2;
            this.rb3Taksit.TabStop = true;
            this.rb3Taksit.Text = "3 Taksit(%5 ek fiyat)";
            this.rb3Taksit.UseVisualStyleBackColor = true;
            // 
            // rb4Taksit
            // 
            this.rb4Taksit.AutoSize = true;
            this.rb4Taksit.Location = new System.Drawing.Point(7, 151);
            this.rb4Taksit.Name = "rb4Taksit";
            this.rb4Taksit.Size = new System.Drawing.Size(126, 17);
            this.rb4Taksit.TabIndex = 3;
            this.rb4Taksit.TabStop = true;
            this.rb4Taksit.Text = "4 Taksit(%10 ek fiyat)";
            this.rb4Taksit.UseVisualStyleBackColor = true;
            // 
            // rb5Taksit
            // 
            this.rb5Taksit.AutoSize = true;
            this.rb5Taksit.Location = new System.Drawing.Point(7, 185);
            this.rb5Taksit.Name = "rb5Taksit";
            this.rb5Taksit.Size = new System.Drawing.Size(126, 17);
            this.rb5Taksit.TabIndex = 4;
            this.rb5Taksit.TabStop = true;
            this.rb5Taksit.Text = "5 Taksit(%10 ek fiyat)";
            this.rb5Taksit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(251, 408);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb5Taksit;
        private System.Windows.Forms.RadioButton rb4Taksit;
        private System.Windows.Forms.RadioButton rb3Taksit;
        private System.Windows.Forms.RadioButton rb2Taksit;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOde;
    }
}

