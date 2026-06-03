namespace MERVEGÜNDOĞDU
{
    partial class KİTAPEKLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KİTAPEKLE));
            combotürü = new ComboBox();
            buttoniptal = new Button();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            buttonekle = new Button();
            textrafno = new TextBox();
            textstoksayisi = new TextBox();
            textyayinevi = new TextBox();
            textsayfasayisi = new TextBox();
            textkitapadi = new TextBox();
            textyazar = new TextBox();
            textbarkod = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // combotürü
            // 
            combotürü.FormattingEnabled = true;
            combotürü.Items.AddRange(new object[] { "KLASİK ROMAN", "AŞK ROMANI ", "BİLİM KURGU ROMANI ", "MACERA ROMANI" });
            combotürü.Location = new Point(163, 239);
            combotürü.Name = "combotürü";
            combotürü.Size = new Size(260, 28);
            combotürü.TabIndex = 110;
            // 
            // buttoniptal
            // 
            buttoniptal.BackColor = Color.LemonChiffon;
            buttoniptal.Font = new Font("Century", 12F, FontStyle.Bold);
            buttoniptal.ImeMode = ImeMode.NoControl;
            buttoniptal.Location = new Point(209, 393);
            buttoniptal.Name = "buttoniptal";
            buttoniptal.Size = new Size(90, 29);
            buttoniptal.TabIndex = 109;
            buttoniptal.Text = "İPTAL";
            buttoniptal.UseVisualStyleBackColor = false;
            buttoniptal.Click += buttoniptal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LemonChiffon;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(65, 328);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 108;
            label2.Text = "RAF NO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LemonChiffon;
            label7.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(25, 289);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 107;
            label7.Text = "STOK SAYISI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LemonChiffon;
            label6.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(86, 238);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 106;
            label6.Text = "TÜRÜ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LemonChiffon;
            label5.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 105;
            label5.Text = "SAYFA SAYISI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LemonChiffon;
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(41, 67);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 104;
            label4.Text = "KİTAP ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LemonChiffon;
            label3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(71, 109);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 103;
            label3.Text = "YAZAR:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LemonChiffon;
            label9.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(47, 152);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 102;
            label9.Text = "YAYINEVİ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LemonChiffon;
            label10.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Black;
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(57, 25);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 101;
            label10.Text = "BARKOD:";
            // 
            // buttonekle
            // 
            buttonekle.BackColor = Color.LemonChiffon;
            buttonekle.Font = new Font("Century", 12F, FontStyle.Bold);
            buttonekle.ImeMode = ImeMode.NoControl;
            buttonekle.Location = new Point(86, 393);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(90, 29);
            buttonekle.TabIndex = 100;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = false;
            buttonekle.Click += buttonekle_Click;
            // 
            // textrafno
            // 
            textrafno.BackColor = SystemColors.ButtonHighlight;
            textrafno.ForeColor = Color.Black;
            textrafno.Location = new Point(163, 329);
            textrafno.Name = "textrafno";
            textrafno.Size = new Size(260, 27);
            textrafno.TabIndex = 99;
            // 
            // textstoksayisi
            // 
            textstoksayisi.BackColor = SystemColors.ButtonHighlight;
            textstoksayisi.ForeColor = Color.Black;
            textstoksayisi.Location = new Point(163, 287);
            textstoksayisi.Name = "textstoksayisi";
            textstoksayisi.Size = new Size(260, 27);
            textstoksayisi.TabIndex = 98;
            // 
            // textyayinevi
            // 
            textyayinevi.BackColor = SystemColors.ButtonHighlight;
            textyayinevi.ForeColor = Color.Black;
            textyayinevi.Location = new Point(163, 153);
            textyayinevi.Name = "textyayinevi";
            textyayinevi.Size = new Size(260, 27);
            textyayinevi.TabIndex = 97;
            // 
            // textsayfasayisi
            // 
            textsayfasayisi.BackColor = SystemColors.ButtonHighlight;
            textsayfasayisi.ForeColor = Color.Black;
            textsayfasayisi.Location = new Point(163, 195);
            textsayfasayisi.Name = "textsayfasayisi";
            textsayfasayisi.Size = new Size(260, 27);
            textsayfasayisi.TabIndex = 96;
            // 
            // textkitapadi
            // 
            textkitapadi.BackColor = SystemColors.ButtonHighlight;
            textkitapadi.ForeColor = Color.Black;
            textkitapadi.Location = new Point(163, 65);
            textkitapadi.Name = "textkitapadi";
            textkitapadi.Size = new Size(260, 27);
            textkitapadi.TabIndex = 95;
            // 
            // textyazar
            // 
            textyazar.BackColor = SystemColors.ButtonHighlight;
            textyazar.ForeColor = Color.Black;
            textyazar.Location = new Point(163, 109);
            textyazar.Name = "textyazar";
            textyazar.Size = new Size(260, 27);
            textyazar.TabIndex = 94;
            // 
            // textbarkod
            // 
            textbarkod.BackColor = SystemColors.ButtonHighlight;
            textbarkod.ForeColor = Color.Black;
            textbarkod.Location = new Point(163, 23);
            textbarkod.Name = "textbarkod";
            textbarkod.Size = new Size(260, 27);
            textbarkod.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(153, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 92;
            // 
            // KİTAPEKLE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(combotürü);
            Controls.Add(buttoniptal);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(buttonekle);
            Controls.Add(textrafno);
            Controls.Add(textstoksayisi);
            Controls.Add(textyayinevi);
            Controls.Add(textsayfasayisi);
            Controls.Add(textkitapadi);
            Controls.Add(textyazar);
            Controls.Add(textbarkod);
            Controls.Add(label1);
            Name = "KİTAPEKLE";
            Text = "KİTAPEKLE";
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
        private Label label9;
        private Label label10;
        private Button buttonekle;
        private TextBox textrafno;
        private TextBox textstoksayisi;
        private TextBox textyayinevi;
        private TextBox textsayfasayisi;
        private TextBox textkitapadi;
        private TextBox textyazar;
        private TextBox textbarkod;
        private Label label1;
    }
}