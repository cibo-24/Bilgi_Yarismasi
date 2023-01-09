namespace Project_5_Bilgi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.labeldogru = new System.Windows.Forms.Label();
            this.labelyanlis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttona = new System.Windows.Forms.Button();
            this.buttonb = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.buttond = new System.Windows.Forms.Button();
            this.buttone = new System.Windows.Forms.Button();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.labelcevap = new System.Windows.Forms.Label();
            this.labelkullanıcıverisi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(431, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru No:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 140);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(431, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğru: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(431, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yanlış:";
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoruno.Location = new System.Drawing.Point(540, 31);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(26, 30);
            this.lblsoruno.TabIndex = 4;
            this.lblsoruno.Text = "0";
            // 
            // labeldogru
            // 
            this.labeldogru.AutoSize = true;
            this.labeldogru.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldogru.Location = new System.Drawing.Point(540, 61);
            this.labeldogru.Name = "labeldogru";
            this.labeldogru.Size = new System.Drawing.Size(26, 30);
            this.labeldogru.TabIndex = 5;
            this.labeldogru.Text = "0";
            // 
            // labelyanlis
            // 
            this.labelyanlis.AutoSize = true;
            this.labelyanlis.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyanlis.Location = new System.Drawing.Point(540, 91);
            this.labelyanlis.Name = "labelyanlis";
            this.labelyanlis.Size = new System.Drawing.Size(26, 30);
            this.labelyanlis.TabIndex = 6;
            this.labelyanlis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "SORULAR";
            // 
            // buttona
            // 
            this.buttona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttona.Location = new System.Drawing.Point(21, 177);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(212, 36);
            this.buttona.TabIndex = 9;
            this.buttona.Text = "A";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.buttona_Click);
            // 
            // buttonb
            // 
            this.buttonb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonb.Location = new System.Drawing.Point(239, 177);
            this.buttonb.Name = "buttonb";
            this.buttonb.Size = new System.Drawing.Size(186, 36);
            this.buttonb.TabIndex = 10;
            this.buttonb.Text = "B";
            this.buttonb.UseVisualStyleBackColor = true;
            this.buttonb.Click += new System.EventHandler(this.buttonb_Click);
            // 
            // buttonc
            // 
            this.buttonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonc.Location = new System.Drawing.Point(21, 219);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(212, 36);
            this.buttonc.TabIndex = 11;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // buttond
            // 
            this.buttond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttond.Location = new System.Drawing.Point(239, 219);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(186, 36);
            this.buttond.TabIndex = 12;
            this.buttond.Text = "D";
            this.buttond.UseVisualStyleBackColor = true;
            this.buttond.Click += new System.EventHandler(this.buttond_Click);
            // 
            // buttone
            // 
            this.buttone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttone.Location = new System.Drawing.Point(145, 261);
            this.buttone.Name = "buttone";
            this.buttone.Size = new System.Drawing.Size(186, 36);
            this.buttone.TabIndex = 13;
            this.buttone.Text = "E";
            this.buttone.UseVisualStyleBackColor = true;
            this.buttone.Click += new System.EventHandler(this.buttone_Click);
            // 
            // btnsonraki
            // 
            this.btnsonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsonraki.Location = new System.Drawing.Point(436, 135);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(122, 36);
            this.btnsonraki.TabIndex = 15;
            this.btnsonraki.Text = "Sonraki";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // labelcevap
            // 
            this.labelcevap.AutoSize = true;
            this.labelcevap.Location = new System.Drawing.Point(18, 371);
            this.labelcevap.Name = "labelcevap";
            this.labelcevap.Size = new System.Drawing.Size(80, 13);
            this.labelcevap.TabIndex = 16;
            this.labelcevap.Text = "Doğruları Tutan";
            this.labelcevap.Visible = false;
            // 
            // labelkullanıcıverisi
            // 
            this.labelkullanıcıverisi.AutoSize = true;
            this.labelkullanıcıverisi.Location = new System.Drawing.Point(161, 371);
            this.labelkullanıcıverisi.Name = "labelkullanıcıverisi";
            this.labelkullanıcıverisi.Size = new System.Drawing.Size(149, 13);
            this.labelkullanıcıverisi.TabIndex = 17;
            this.labelkullanıcıverisi.Text = "Kullanıcıdan alınan veriyi tutan";
            this.labelkullanıcıverisi.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(596, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelkullanıcıverisi);
            this.Controls.Add(this.labelcevap);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.buttone);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonb);
            this.Controls.Add(this.buttona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelyanlis);
            this.Controls.Add(this.labeldogru);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label labeldogru;
        private System.Windows.Forms.Label labelyanlis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.Button buttonb;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.Button buttone;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Label labelcevap;
        private System.Windows.Forms.Label labelkullanıcıverisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

