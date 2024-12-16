namespace BurgerNaut.Sunum.SatisViews
{
    partial class FrmSatisList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatisList));
            this.lstSatislar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.satisDetay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSatislar
            // 
            this.lstSatislar.FormattingEnabled = true;
            this.lstSatislar.Location = new System.Drawing.Point(12, 38);
            this.lstSatislar.Name = "lstSatislar";
            this.lstSatislar.Size = new System.Drawing.Size(148, 394);
            this.lstSatislar.TabIndex = 0;
            this.lstSatislar.SelectedIndexChanged += new System.EventHandler(this.lstSatislar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sipariş Detayı";
            // 
            // satisDetay
            // 
            this.satisDetay.FormattingEnabled = true;
            this.satisDetay.Location = new System.Drawing.Point(169, 38);
            this.satisDetay.Name = "satisDetay";
            this.satisDetay.Size = new System.Drawing.Size(681, 43);
            this.satisDetay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Satışlar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(169, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSatisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.satisDetay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSatislar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSatisList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listesi";
            this.Load += new System.EventHandler(this.FrmSatisList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSatislar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox satisDetay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}