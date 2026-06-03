namespace MERVEGÜNDOĞDU
{
    partial class KİTAPLİSTELE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KİTAPLİSTELE));
            combotürü = new ComboBox();
            buttoniptal = new Button();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label10 = new Label();
            buttonkitapguncelle = new Button();
            textrafno = new TextBox();
            textstoksayisi = new TextBox();
            textyayinevi = new TextBox();
            textsayfasayisi = new TextBox();
            textkitapadi = new TextBox();
            textyazar = new TextBox();
            textbarkod = new TextBox();
            label8 = new Label();
            buttonsil = new Button();
            textarabarkod = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // combotürü
            // 
            combotürü.FormattingEnabled = true;
            combotürü.Items.AddRange(new object[] { "AŞK ROMANI", "KLASİK ROMAN", "MACERA ROMANI ", "BİLİM KURGU ROMANI" });
            combotürü.Location = new Point(161, 293);
            combotürü.Name = "combotürü";
            combotürü.Size = new Size(260, 28);
            combotürü.TabIndex = 133;
            // 
            // buttoniptal
            // 
            buttoniptal.BackColor = Color.LemonChiffon;
            buttoniptal.Font = new Font("Century", 12F, FontStyle.Bold);
            buttoniptal.ImeMode = ImeMode.NoControl;
            buttoniptal.Location = new Point(246, 443);
            buttoniptal.Name = "buttoniptal";
            buttoniptal.Size = new Size(90, 29);
            buttoniptal.TabIndex = 132;
            buttoniptal.Text = "İPTAL";
            buttoniptal.UseVisualStyleBackColor = false;
            buttoniptal.Click += buttoniptal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LemonChiffon;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(63, 382);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 131;
            label2.Text = "RAF NO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LemonChiffon;
            label7.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(23, 343);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 130;
            label7.Text = "STOK SAYISI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LemonChiffon;
            label6.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(84, 292);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 129;
            label6.Text = "TÜRÜ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LemonChiffon;
            label5.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(10, 251);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 128;
            label5.Text = "SAYFA SAYISI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LemonChiffon;
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(39, 121);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 127;
            label4.Text = "KİTAP ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LemonChiffon;
            label3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(69, 163);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 126;
            label3.Text = "YAZAR:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(45, 206);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 125;
            label1.Text = "YAYINEVİ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LemonChiffon;
            label10.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(492, 33);
            label10.Name = "label10";
            label10.Size = new Size(129, 25);
            label10.TabIndex = 124;
            label10.Text = "BARKOD ara:";
            // 
            // buttonkitapguncelle
            // 
            buttonkitapguncelle.BackColor = Color.LemonChiffon;
            buttonkitapguncelle.Font = new Font("Century", 12F, FontStyle.Bold);
            buttonkitapguncelle.ImeMode = ImeMode.NoControl;
            buttonkitapguncelle.Location = new Point(86, 443);
            buttonkitapguncelle.Name = "buttonkitapguncelle";
            buttonkitapguncelle.Size = new Size(154, 29);
            buttonkitapguncelle.TabIndex = 123;
            buttonkitapguncelle.Text = "GÜNCELLE";
            buttonkitapguncelle.UseVisualStyleBackColor = false;
            buttonkitapguncelle.Click += buttonkitapguncelle_Click;
            // 
            // textrafno
            // 
            textrafno.BackColor = SystemColors.ButtonHighlight;
            textrafno.ForeColor = Color.Black;
            textrafno.Location = new Point(161, 383);
            textrafno.Name = "textrafno";
            textrafno.Size = new Size(260, 27);
            textrafno.TabIndex = 122;
            // 
            // textstoksayisi
            // 
            textstoksayisi.BackColor = SystemColors.ButtonHighlight;
            textstoksayisi.ForeColor = Color.Black;
            textstoksayisi.Location = new Point(161, 341);
            textstoksayisi.Name = "textstoksayisi";
            textstoksayisi.Size = new Size(260, 27);
            textstoksayisi.TabIndex = 121;
            // 
            // textyayinevi
            // 
            textyayinevi.BackColor = SystemColors.ButtonHighlight;
            textyayinevi.ForeColor = Color.Black;
            textyayinevi.Location = new Point(161, 207);
            textyayinevi.Name = "textyayinevi";
            textyayinevi.Size = new Size(260, 27);
            textyayinevi.TabIndex = 120;
            // 
            // textsayfasayisi
            // 
            textsayfasayisi.BackColor = SystemColors.ButtonHighlight;
            textsayfasayisi.ForeColor = Color.Black;
            textsayfasayisi.Location = new Point(161, 249);
            textsayfasayisi.Name = "textsayfasayisi";
            textsayfasayisi.Size = new Size(260, 27);
            textsayfasayisi.TabIndex = 119;
            // 
            // textkitapadi
            // 
            textkitapadi.BackColor = SystemColors.ButtonHighlight;
            textkitapadi.ForeColor = Color.Black;
            textkitapadi.Location = new Point(161, 119);
            textkitapadi.Name = "textkitapadi";
            textkitapadi.Size = new Size(260, 27);
            textkitapadi.TabIndex = 118;
            // 
            // textyazar
            // 
            textyazar.BackColor = SystemColors.ButtonHighlight;
            textyazar.ForeColor = Color.Black;
            textyazar.Location = new Point(161, 163);
            textyazar.Name = "textyazar";
            textyazar.Size = new Size(260, 27);
            textyazar.TabIndex = 117;
            // 
            // textbarkod
            // 
            textbarkod.BackColor = SystemColors.ButtonHighlight;
            textbarkod.ForeColor = Color.Black;
            textbarkod.Location = new Point(627, 31);
            textbarkod.Name = "textbarkod";
            textbarkod.Size = new Size(260, 27);
            textbarkod.TabIndex = 116;
            textbarkod.TextChanged += textbarkod_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(617, 33);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 115;
            // 
            // buttonsil
            // 
            buttonsil.BackColor = Color.LemonChiffon;
            buttonsil.Font = new Font("Century", 12F, FontStyle.Bold);
            buttonsil.ImeMode = ImeMode.NoControl;
            buttonsil.Location = new Point(492, 443);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(90, 29);
            buttonsil.TabIndex = 114;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = false;
            buttonsil.Click += buttonsil_Click;
            // 
            // textarabarkod
            // 
            textarabarkod.BackColor = SystemColors.Info;
            textarabarkod.ForeColor = Color.Black;
            textarabarkod.Location = new Point(1002, 122);
            textarabarkod.Name = "textarabarkod";
            textarabarkod.Size = new Size(10, 27);
            textarabarkod.TabIndex = 113;
            textarabarkod.TextChanged += textarabarkod_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(490, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(506, 331);
            dataGridView1.TabIndex = 111;
            // 
            // KİTAPLİSTELE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1010, 546);
            Controls.Add(combotürü);
            Controls.Add(buttoniptal);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(buttonkitapguncelle);
            Controls.Add(textrafno);
            Controls.Add(textstoksayisi);
            Controls.Add(textyayinevi);
            Controls.Add(textsayfasayisi);
            Controls.Add(textkitapadi);
            Controls.Add(textyazar);
            Controls.Add(textbarkod);
            Controls.Add(label8);
            Controls.Add(buttonsil);
            Controls.Add(textarabarkod);
            Controls.Add(dataGridView1);
            Name = "KİTAPLİSTELE";
            Text = "KİTAPLİSTELE";
            Load += KİTAPLİSTELE_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combotürü;
        private Button buttoniptal;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label10;
        private Button buttonkitapguncelle;
        private TextBox textrafno;
        private TextBox textstoksayisi;
        private TextBox textyayinevi;
        private TextBox textsayfasayisi;
        private TextBox textkitapadi;
        private TextBox textyazar;
        private TextBox textbarkod;
        private Label label8;
        private Button buttonsil;
        private TextBox textarabarkod;
        private Label label9;
        private DataGridView dataGridView1;
    }
}