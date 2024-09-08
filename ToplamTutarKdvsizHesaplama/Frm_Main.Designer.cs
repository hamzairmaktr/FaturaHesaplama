namespace ToplamTutarKdvsizHesaplama
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtGenelToplam = new DevExpress.XtraEditors.TextEdit();
            this.txtKdv = new DevExpress.XtraEditors.TextEdit();
            this.txtBirimUcret = new DevExpress.XtraEditors.TextEdit();
            this.txtKdvsizTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.btnHesapla = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimUcret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvsizTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Genel Toplam :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(76, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Kdv (%) :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Birim Ücret  :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Kdvsiz Toplam Tutar :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(87, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Miktar :";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.EditValue = "0";
            this.txtGenelToplam.Location = new System.Drawing.Point(137, 12);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtGenelToplam.Properties.Appearance.Options.UseFont = true;
            this.txtGenelToplam.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGenelToplam.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtGenelToplam.Properties.MaskSettings.Set("mask", "n3");
            this.txtGenelToplam.Properties.UseMaskAsDisplayFormat = true;
            this.txtGenelToplam.Size = new System.Drawing.Size(215, 22);
            this.txtGenelToplam.TabIndex = 0;
            // 
            // txtKdv
            // 
            this.txtKdv.EditValue = "0";
            this.txtKdv.Location = new System.Drawing.Point(137, 38);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtKdv.Properties.Appearance.Options.UseFont = true;
            this.txtKdv.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtKdv.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtKdv.Properties.MaskSettings.Set("mask", "d");
            this.txtKdv.Properties.MaxLength = 2;
            this.txtKdv.Properties.UseMaskAsDisplayFormat = true;
            this.txtKdv.Size = new System.Drawing.Size(215, 22);
            this.txtKdv.TabIndex = 1;
            // 
            // txtBirimUcret
            // 
            this.txtBirimUcret.EditValue = "0";
            this.txtBirimUcret.Location = new System.Drawing.Point(137, 64);
            this.txtBirimUcret.Name = "txtBirimUcret";
            this.txtBirimUcret.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtBirimUcret.Properties.Appearance.Options.UseFont = true;
            this.txtBirimUcret.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtBirimUcret.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtBirimUcret.Properties.MaskSettings.Set("mask", "n3");
            this.txtBirimUcret.Properties.UseMaskAsDisplayFormat = true;
            this.txtBirimUcret.Size = new System.Drawing.Size(215, 22);
            this.txtBirimUcret.TabIndex = 2;
            // 
            // txtKdvsizTutar
            // 
            this.txtKdvsizTutar.EditValue = "0";
            this.txtKdvsizTutar.Location = new System.Drawing.Point(137, 129);
            this.txtKdvsizTutar.Name = "txtKdvsizTutar";
            this.txtKdvsizTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtKdvsizTutar.Properties.Appearance.Options.UseFont = true;
            this.txtKdvsizTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtKdvsizTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtKdvsizTutar.Properties.MaskSettings.Set("mask", "n3");
            this.txtKdvsizTutar.Properties.ReadOnly = true;
            this.txtKdvsizTutar.Properties.UseMaskAsDisplayFormat = true;
            this.txtKdvsizTutar.Size = new System.Drawing.Size(215, 22);
            this.txtKdvsizTutar.TabIndex = 4;
            // 
            // txtMiktar
            // 
            this.txtMiktar.EditValue = "0";
            this.txtMiktar.Location = new System.Drawing.Point(137, 155);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtMiktar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMiktar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMiktar.Properties.MaskSettings.Set("mask", "n3");
            this.txtMiktar.Properties.ReadOnly = true;
            this.txtMiktar.Properties.UseMaskAsDisplayFormat = true;
            this.txtMiktar.Size = new System.Drawing.Size(215, 22);
            this.txtMiktar.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnHesapla.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHesapla.Appearance.Options.UseBackColor = true;
            this.btnHesapla.Appearance.Options.UseFont = true;
            this.btnHesapla.Location = new System.Drawing.Point(137, 91);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(215, 32);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(380, 192);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtKdvsizTutar);
            this.Controls.Add(this.txtBirimUcret);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtGenelToplam);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimUcret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvsizTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtGenelToplam;
        private DevExpress.XtraEditors.TextEdit txtKdv;
        private DevExpress.XtraEditors.TextEdit txtBirimUcret;
        private DevExpress.XtraEditors.TextEdit txtKdvsizTutar;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.SimpleButton btnHesapla;
    }
}