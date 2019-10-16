namespace WFA191016
{
    partial class FrmMain
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
            this.rbNő = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Nevek = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rblNev = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rblAsztal = new System.Windows.Forms.Label();
            this.rbFérfi = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbVega = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendég neve:";
            // 
            // rbNő
            // 
            this.rbNő.AutoSize = true;
            this.rbNő.Location = new System.Drawing.Point(123, 246);
            this.rbNő.Name = "rbNő";
            this.rbNő.Size = new System.Drawing.Size(37, 17);
            this.rbNő.TabIndex = 3;
            this.rbNő.TabStop = true;
            this.rbNő.Text = "nő";
            this.rbNő.UseVisualStyleBackColor = true;
            this.rbNő.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "RÖGZÍT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Nevek
            // 
            this.Nevek.FormattingEnabled = true;
            this.Nevek.Location = new System.Drawing.Point(92, 30);
            this.Nevek.Name = "Nevek";
            this.Nevek.Size = new System.Drawing.Size(221, 21);
            this.Nevek.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vendég adatai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asztal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kaja";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "###";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "###";
            this.label6.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ÚJ VENDÉG RÖGZÍTÉSE";
            // 
            // rblNev
            // 
            this.rblNev.AutoSize = true;
            this.rblNev.Location = new System.Drawing.Point(12, 208);
            this.rblNev.Name = "rblNev";
            this.rblNev.Size = new System.Drawing.Size(30, 13);
            this.rblNev.TabIndex = 7;
            this.rblNev.Text = "Név:";
            this.rblNev.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nem:";
            this.label9.Click += new System.EventHandler(this.Label8_Click);
            // 
            // rblAsztal
            // 
            this.rblAsztal.AutoSize = true;
            this.rblAsztal.Location = new System.Drawing.Point(12, 287);
            this.rblAsztal.Name = "rblAsztal";
            this.rblAsztal.Size = new System.Drawing.Size(35, 13);
            this.rblAsztal.TabIndex = 7;
            this.rblAsztal.Text = "Asztal";
            // 
            // rbFérfi
            // 
            this.rbFérfi.AutoSize = true;
            this.rbFérfi.Location = new System.Drawing.Point(54, 246);
            this.rbFérfi.Name = "rbFérfi";
            this.rbFérfi.Size = new System.Drawing.Size(45, 17);
            this.rbFérfi.TabIndex = 3;
            this.rbFérfi.TabStop = true;
            this.rbFérfi.Text = "Férfi";
            this.rbFérfi.UseVisualStyleBackColor = true;
            this.rbFérfi.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // rbVega
            // 
            this.rbVega.AutoSize = true;
            this.rbVega.Location = new System.Drawing.Point(172, 285);
            this.rbVega.Name = "rbVega";
            this.rbVega.Size = new System.Drawing.Size(56, 17);
            this.rbVega.TabIndex = 3;
            this.rbVega.TabStop = true;
            this.rbVega.Text = "Vega?";
            this.rbVega.UseVisualStyleBackColor = true;
            this.rbVega.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rblNev);
            this.Controls.Add(this.rblAsztal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nevek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbFérfi);
            this.Controls.Add(this.rbVega);
            this.Controls.Add(this.rbNő);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNő;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Nevek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rblNev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rblAsztal;
        private System.Windows.Forms.RadioButton rbFérfi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbVega;
    }
}

