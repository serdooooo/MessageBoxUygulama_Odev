
namespace kurs_08122021_86_MessageBoxUygulama
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnYeniKayit = new System.Windows.Forms.Button();
            this.TxtTelefonNo = new System.Windows.Forms.TextBox();
            this.TxtEmailAdres = new System.Windows.Forms.TextBox();
            this.TxtSoyisim = new System.Windows.Forms.TextBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblSoyisim = new System.Windows.Forms.Label();
            this.LblIsim = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstMusteriler = new System.Windows.Forms.ListBox();
            this.BildirimCubugu = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnYeniKayit);
            this.groupBox1.Controls.Add(this.TxtTelefonNo);
            this.groupBox1.Controls.Add(this.TxtEmailAdres);
            this.groupBox1.Controls.Add(this.TxtSoyisim);
            this.groupBox1.Controls.Add(this.TxtIsim);
            this.groupBox1.Controls.Add(this.LblTelefon);
            this.groupBox1.Controls.Add(this.LblEmail);
            this.groupBox1.Controls.Add(this.LblSoyisim);
            this.groupBox1.Controls.Add(this.LblIsim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(58, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Ekleme Formu";
            // 
            // BtnYeniKayit
            // 
            this.BtnYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYeniKayit.Location = new System.Drawing.Point(116, 131);
            this.BtnYeniKayit.Name = "BtnYeniKayit";
            this.BtnYeniKayit.Size = new System.Drawing.Size(100, 38);
            this.BtnYeniKayit.TabIndex = 8;
            this.BtnYeniKayit.Text = "Yeni Kayıt";
            this.BtnYeniKayit.UseVisualStyleBackColor = true;
            this.BtnYeniKayit.Click += new System.EventHandler(this.BtnYeniKayit_Click);
            // 
            // TxtTelefonNo
            // 
            this.TxtTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTelefonNo.Location = new System.Drawing.Point(116, 98);
            this.TxtTelefonNo.Name = "TxtTelefonNo";
            this.TxtTelefonNo.Size = new System.Drawing.Size(100, 26);
            this.TxtTelefonNo.TabIndex = 7;
            // 
            // TxtEmailAdres
            // 
            this.TxtEmailAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmailAdres.Location = new System.Drawing.Point(116, 72);
            this.TxtEmailAdres.Name = "TxtEmailAdres";
            this.TxtEmailAdres.Size = new System.Drawing.Size(100, 26);
            this.TxtEmailAdres.TabIndex = 6;
            // 
            // TxtSoyisim
            // 
            this.TxtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyisim.Location = new System.Drawing.Point(116, 46);
            this.TxtSoyisim.Name = "TxtSoyisim";
            this.TxtSoyisim.Size = new System.Drawing.Size(100, 26);
            this.TxtSoyisim.TabIndex = 5;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIsim.Location = new System.Drawing.Point(116, 20);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 26);
            this.TxtIsim.TabIndex = 4;
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTelefon.Location = new System.Drawing.Point(7, 98);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(96, 18);
            this.LblTelefon.TabIndex = 3;
            this.LblTelefon.Text = "Telefon No:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmail.Location = new System.Drawing.Point(7, 72);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(103, 18);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email Adres:";
            // 
            // LblSoyisim
            // 
            this.LblSoyisim.AutoSize = true;
            this.LblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyisim.Location = new System.Drawing.Point(7, 46);
            this.LblSoyisim.Name = "LblSoyisim";
            this.LblSoyisim.Size = new System.Drawing.Size(73, 18);
            this.LblSoyisim.TabIndex = 1;
            this.LblSoyisim.Text = "Soyisim:";
            // 
            // LblIsim
            // 
            this.LblIsim.AutoSize = true;
            this.LblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIsim.Location = new System.Drawing.Point(7, 20);
            this.LblIsim.Name = "LblIsim";
            this.LblIsim.Size = new System.Drawing.Size(44, 18);
            this.LblIsim.TabIndex = 0;
            this.LblIsim.Text = "İsim:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LstMusteriler);
            this.groupBox2.Location = new System.Drawing.Point(413, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Kayıt Listesi";
            // 
            // LstMusteriler
            // 
            this.LstMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstMusteriler.FormattingEnabled = true;
            this.LstMusteriler.ItemHeight = 18;
            this.LstMusteriler.Location = new System.Drawing.Point(7, 20);
            this.LstMusteriler.Name = "LstMusteriler";
            this.LstMusteriler.Size = new System.Drawing.Size(208, 148);
            this.LstMusteriler.TabIndex = 0;
            this.LstMusteriler.DoubleClick += new System.EventHandler(this.LstMusteriler_DoubleClick);
            // 
            // BildirimCubugu
            // 
            this.BildirimCubugu.Text = "notifyIcon1";
            this.BildirimCubugu.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Message Box Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnYeniKayit;
        private System.Windows.Forms.TextBox TxtTelefonNo;
        private System.Windows.Forms.TextBox TxtEmailAdres;
        private System.Windows.Forms.TextBox TxtSoyisim;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblSoyisim;
        private System.Windows.Forms.Label LblIsim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NotifyIcon BildirimCubugu;
        private System.Windows.Forms.ListBox LstMusteriler;
    }
}

