namespace PiggyBank
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
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnKir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstParalar = new System.Windows.Forms.ListBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.lblHacim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKagitParaKatla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.Location = new System.Drawing.Point(258, 16);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(103, 37);
            this.btnParaEkle.TabIndex = 0;
            this.btnParaEkle.Text = "Para Ekle";
            this.btnParaEkle.UseVisualStyleBackColor = true;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnKir
            // 
            this.btnKir.Location = new System.Drawing.Point(258, 118);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(103, 39);
            this.btnKir.TabIndex = 2;
            this.btnKir.Text = "Kumbara Kır";
            this.btnKir.UseVisualStyleBackColor = true;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Biriken Tutar:";
            // 
            // lstParalar
            // 
            this.lstParalar.FormattingEnabled = true;
            this.lstParalar.Location = new System.Drawing.Point(12, 132);
            this.lstParalar.Name = "lstParalar";
            this.lstParalar.Size = new System.Drawing.Size(214, 199);
            this.lstParalar.TabIndex = 4;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(92, 81);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(13, 13);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "0";
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(258, 170);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(103, 39);
            this.btnYapistir.TabIndex = 6;
            this.btnYapistir.Text = "Kumbara Yapıştır";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // lblHacim
            // 
            this.lblHacim.AutoSize = true;
            this.lblHacim.Location = new System.Drawing.Point(92, 106);
            this.lblHacim.Name = "lblHacim";
            this.lblHacim.Size = new System.Drawing.Size(13, 13);
            this.lblHacim.TabIndex = 8;
            this.lblHacim.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Biriken Hacim:";
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(258, 67);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(103, 37);
            this.btnSalla.TabIndex = 9;
            this.btnSalla.Text = "Kumbara Salla";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Para Seç";
            // 
            // btnKagitParaKatla
            // 
            this.btnKagitParaKatla.Location = new System.Drawing.Point(376, 16);
            this.btnKagitParaKatla.Name = "btnKagitParaKatla";
            this.btnKagitParaKatla.Size = new System.Drawing.Size(103, 37);
            this.btnKagitParaKatla.TabIndex = 11;
            this.btnKagitParaKatla.Text = "Kağıt Para Katla";
            this.btnKagitParaKatla.UseVisualStyleBackColor = true;
            this.btnKagitParaKatla.Click += new System.EventHandler(this.btnKagitParaKatla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kumbara kapasitesi 250 cm3\' tür. 5x5 taban ve 10 cm yükseklik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKagitParaKatla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.lblHacim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lstParalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnParaEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ListBox lstParalar;
        public System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnYapistir;
        public System.Windows.Forms.Label lblHacim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKagitParaKatla;
        private System.Windows.Forms.Label label3;
    }
}

