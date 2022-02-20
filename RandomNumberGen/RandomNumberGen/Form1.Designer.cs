namespace RandomNumberGen
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.button_random_cisla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_dec = new System.Windows.Forms.ListBox();
            this.listBox_bin = new System.Windows.Forms.ListBox();
            this.listBox_hex = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(15, 25);
            this.textBox_A.Multiline = true;
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.ReadOnly = true;
            this.textBox_A.Size = new System.Drawing.Size(162, 23);
            this.textBox_A.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hodnota A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hodnota B";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(15, 67);
            this.textBox_B.Multiline = true;
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.ReadOnly = true;
            this.textBox_B.Size = new System.Drawing.Size(162, 23);
            this.textBox_B.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hodnota C";
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(15, 109);
            this.textBox_C.Multiline = true;
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.ReadOnly = true;
            this.textBox_C.Size = new System.Drawing.Size(162, 23);
            this.textBox_C.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hodnota D";
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(15, 151);
            this.textBox_D.Multiline = true;
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.ReadOnly = true;
            this.textBox_D.Size = new System.Drawing.Size(162, 23);
            this.textBox_D.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hodnota F";
            // 
            // textBox_F
            // 
            this.textBox_F.Location = new System.Drawing.Point(15, 193);
            this.textBox_F.Multiline = true;
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.ReadOnly = true;
            this.textBox_F.Size = new System.Drawing.Size(162, 23);
            this.textBox_F.TabIndex = 16;
            // 
            // button_random_cisla
            // 
            this.button_random_cisla.Location = new System.Drawing.Point(59, 291);
            this.button_random_cisla.Name = "button_random_cisla";
            this.button_random_cisla.Size = new System.Drawing.Size(75, 22);
            this.button_random_cisla.TabIndex = 18;
            this.button_random_cisla.Text = "GENERUJ";
            this.button_random_cisla.UseVisualStyleBackColor = true;
            this.button_random_cisla.Click += new System.EventHandler(this.button_random_cisla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Začni generovat náhodná číslo";
            // 
            // listBox_dec
            // 
            this.listBox_dec.FormattingEnabled = true;
            this.listBox_dec.Location = new System.Drawing.Point(195, 17);
            this.listBox_dec.Name = "listBox_dec";
            this.listBox_dec.Size = new System.Drawing.Size(204, 472);
            this.listBox_dec.TabIndex = 21;
            // 
            // listBox_bin
            // 
            this.listBox_bin.FormattingEnabled = true;
            this.listBox_bin.Location = new System.Drawing.Point(615, 17);
            this.listBox_bin.Name = "listBox_bin";
            this.listBox_bin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox_bin.Size = new System.Drawing.Size(204, 472);
            this.listBox_bin.TabIndex = 22;
            // 
            // listBox_hex
            // 
            this.listBox_hex.FormattingEnabled = true;
            this.listBox_hex.Location = new System.Drawing.Point(405, 17);
            this.listBox_hex.Name = "listBox_hex";
            this.listBox_hex.Size = new System.Drawing.Size(204, 472);
            this.listBox_hex.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 497);
            this.Controls.Add(this.listBox_hex);
            this.Controls.Add(this.listBox_bin);
            this.Controls.Add(this.listBox_dec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_random_cisla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_F);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_D);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_A);
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.Button button_random_cisla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox_dec;
        private System.Windows.Forms.ListBox listBox_bin;
        private System.Windows.Forms.ListBox listBox_hex;
    }
}

