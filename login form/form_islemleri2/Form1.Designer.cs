namespace form_islemleri2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            KullaniciAd = new TextBox();
            checkBox1 = new CheckBox();
            btnGirisYap = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 172);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adınız";
            label1.Click += label1_Click;
            // 
            // KullaniciAd
            // 
            KullaniciAd.Location = new Point(235, 169);
            KullaniciAd.Name = "KullaniciAd";
            KullaniciAd.Size = new Size(237, 27);
            KullaniciAd.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(235, 383);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.ButtonShadow;
            btnGirisYap.Location = new Point(235, 330);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(109, 37);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 222);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Sifreniz";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(0, 0, 192);
            linkLabel1.LinkColor = Color.Purple;
            linkLabel1.Location = new Point(370, 347);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "şifremi unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ravie", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(151, 41);
            label3.Name = "label3";
            label3.Size = new Size(369, 38);
            label3.TabIndex = 7;
            label3.Text = "Admin Login Form";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(235, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(92, 27);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 272);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 9;
            label4.Text = "Kodu Giriniz";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(380, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(92, 27);
            textBox4.TabIndex = 10;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(681, 509);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(btnGirisYap);
            Controls.Add(checkBox1);
            Controls.Add(KullaniciAd);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox KullaniciAd;
        private CheckBox checkBox1;
        private Button btnGirisYap;
        private Label label2;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private System.Windows.Forms.Timer timer1;
    }
}