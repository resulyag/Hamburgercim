
namespace Hamburgercim
{
    partial class SiparisOlustur
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
            this.cmBoxMenu = new System.Windows.Forms.ComboBox();
            this.groupBoxBoyut = new System.Windows.Forms.GroupBox();
            this.radioButtonBuyuk = new System.Windows.Forms.RadioButton();
            this.radioButtonOrta = new System.Windows.Forms.RadioButton();
            this.radioButtonKucuk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.listBoxSepet = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSiparisOK = new System.Windows.Forms.Button();
            this.groupBoxBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Seçin";
            // 
            // cmBoxMenu
            // 
            this.cmBoxMenu.FormattingEnabled = true;
            this.cmBoxMenu.Location = new System.Drawing.Point(16, 52);
            this.cmBoxMenu.Name = "cmBoxMenu";
            this.cmBoxMenu.Size = new System.Drawing.Size(251, 29);
            this.cmBoxMenu.TabIndex = 1;
            // 
            // groupBoxBoyut
            // 
            this.groupBoxBoyut.Controls.Add(this.radioButtonBuyuk);
            this.groupBoxBoyut.Controls.Add(this.radioButtonOrta);
            this.groupBoxBoyut.Controls.Add(this.radioButtonKucuk);
            this.groupBoxBoyut.Location = new System.Drawing.Point(16, 87);
            this.groupBoxBoyut.Name = "groupBoxBoyut";
            this.groupBoxBoyut.Size = new System.Drawing.Size(251, 75);
            this.groupBoxBoyut.TabIndex = 2;
            this.groupBoxBoyut.TabStop = false;
            this.groupBoxBoyut.Text = "Boyut Seçin";
            // 
            // radioButtonBuyuk
            // 
            this.radioButtonBuyuk.AutoSize = true;
            this.radioButtonBuyuk.Location = new System.Drawing.Point(168, 29);
            this.radioButtonBuyuk.Name = "radioButtonBuyuk";
            this.radioButtonBuyuk.Size = new System.Drawing.Size(71, 25);
            this.radioButtonBuyuk.TabIndex = 2;
            this.radioButtonBuyuk.Text = "Büyük";
            this.radioButtonBuyuk.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrta
            // 
            this.radioButtonOrta.AutoSize = true;
            this.radioButtonOrta.Location = new System.Drawing.Point(95, 29);
            this.radioButtonOrta.Name = "radioButtonOrta";
            this.radioButtonOrta.Size = new System.Drawing.Size(59, 25);
            this.radioButtonOrta.TabIndex = 1;
            this.radioButtonOrta.Text = "Orta";
            this.radioButtonOrta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKucuk
            // 
            this.radioButtonKucuk.AutoSize = true;
            this.radioButtonKucuk.Checked = true;
            this.radioButtonKucuk.Location = new System.Drawing.Point(13, 29);
            this.radioButtonKucuk.Name = "radioButtonKucuk";
            this.radioButtonKucuk.Size = new System.Drawing.Size(70, 25);
            this.radioButtonKucuk.TabIndex = 0;
            this.radioButtonKucuk.TabStop = true;
            this.radioButtonKucuk.Text = "Küçük";
            this.radioButtonKucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet : ";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(71, 387);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(113, 29);
            this.numericUpDownAdet.TabIndex = 6;
            this.numericUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(16, 422);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(251, 39);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // listBoxSepet
            // 
            this.listBoxSepet.FormattingEnabled = true;
            this.listBoxSepet.ItemHeight = 21;
            this.listBoxSepet.Location = new System.Drawing.Point(298, 33);
            this.listBoxSepet.Name = "listBoxSepet";
            this.listBoxSepet.Size = new System.Drawing.Size(612, 319);
            this.listBoxSepet.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplam Fiyat : ";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(408, 428);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 29);
            this.txtToplamFiyat.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 202);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Extra Malzemeler";
            // 
            // btnSiparisOK
            // 
            this.btnSiparisOK.Location = new System.Drawing.Point(659, 422);
            this.btnSiparisOK.Name = "btnSiparisOK";
            this.btnSiparisOK.Size = new System.Drawing.Size(251, 39);
            this.btnSiparisOK.TabIndex = 12;
            this.btnSiparisOK.Text = "Siparişi Tamamla";
            this.btnSiparisOK.UseVisualStyleBackColor = true;
            this.btnSiparisOK.Click += new System.EventHandler(this.btnSiparisOK_Click);
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 473);
            this.Controls.Add(this.btnSiparisOK);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSepet);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxBoyut);
            this.Controls.Add(this.cmBoxMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisOlustur";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            this.groupBoxBoyut.ResumeLayout(false);
            this.groupBoxBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxBoyut;
        private System.Windows.Forms.RadioButton radioButtonBuyuk;
        private System.Windows.Forms.RadioButton radioButtonOrta;
        private System.Windows.Forms.RadioButton radioButtonKucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox listBoxSepet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSiparisOK;
    }
}