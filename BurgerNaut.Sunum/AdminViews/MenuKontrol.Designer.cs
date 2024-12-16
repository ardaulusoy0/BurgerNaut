namespace BurgerNaut.Sunum.AdminViews
{
    partial class MenuKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuKontrol));
            this.showBurgers = new System.Windows.Forms.Button();
            this.showDrinks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showBurgers
            // 
            this.showBurgers.Location = new System.Drawing.Point(12, 42);
            this.showBurgers.Name = "showBurgers";
            this.showBurgers.Size = new System.Drawing.Size(256, 44);
            this.showBurgers.TabIndex = 0;
            this.showBurgers.Text = "Burgerleri Yönet";
            this.showBurgers.UseVisualStyleBackColor = true;
            this.showBurgers.Click += new System.EventHandler(this.showBurgers_Click);
            // 
            // showDrinks
            // 
            this.showDrinks.Location = new System.Drawing.Point(12, 92);
            this.showDrinks.Name = "showDrinks";
            this.showDrinks.Size = new System.Drawing.Size(256, 44);
            this.showDrinks.TabIndex = 1;
            this.showDrinks.Text = "İçececekleri Yönet";
            this.showDrinks.UseVisualStyleBackColor = true;
            this.showDrinks.Click += new System.EventHandler(this.showDrinks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoşgeldin Admin!";
            // 
            // MenuKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(280, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDrinks);
            this.Controls.Add(this.showBurgers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Kontrol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBurgers;
        private System.Windows.Forms.Button showDrinks;
        private System.Windows.Forms.Label label1;
    }
}