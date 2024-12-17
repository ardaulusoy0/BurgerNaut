namespace BurgerNaut.Sunum
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFiyat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.boxAdet = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buyukBoy = new System.Windows.Forms.RadioButton();
            this.ortaBoy = new System.Windows.Forms.RadioButton();
            this.kucukBoy = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.burgerlerBox = new System.Windows.Forms.ComboBox();
            this.iceceklerBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.sepetList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(157, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 16);
            this.label13.TabIndex = 68;
            this.label13.Text = "Orta Boy: +10₺ | Büyük Boy: +15₺";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(698, 399);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(315, 46);
            this.button4.TabIndex = 66;
            this.button4.Text = "Sepeti Temizle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(362, 399);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(325, 46);
            this.button3.TabIndex = 65;
            this.button3.Text = "Seçili Ürünü Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(359, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Sepet:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFiyat.Location = new System.Drawing.Point(254, 314);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(76, 15);
            this.lblFiyat.TabIndex = 60;
            this.lblFiyat.Text = "Sepet Tutarı:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(154, 399);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 46);
            this.button2.TabIndex = 59;
            this.button2.Text = "Siparişi Tamamla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(154, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 36);
            this.button1.TabIndex = 58;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(154, 297);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "Adet:";
            // 
            // boxAdet
            // 
            this.boxAdet.Location = new System.Drawing.Point(157, 313);
            this.boxAdet.Margin = new System.Windows.Forms.Padding(2);
            this.boxAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxAdet.Name = "boxAdet";
            this.boxAdet.Size = new System.Drawing.Size(90, 20);
            this.boxAdet.TabIndex = 56;
            this.boxAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(154, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Tüm malzemeler ekstra 5₺\'dir.";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox5.Location = new System.Drawing.Point(264, 269);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(61, 19);
            this.checkBox5.TabIndex = 54;
            this.checkBox5.Text = "Marul";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buyukBoy);
            this.groupBox1.Controls.Add(this.ortaBoy);
            this.groupBox1.Controls.Add(this.kucukBoy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(154, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(203, 45);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seçimi";
            // 
            // buyukBoy
            // 
            this.buyukBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buyukBoy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buyukBoy.Location = new System.Drawing.Point(142, 17);
            this.buyukBoy.Margin = new System.Windows.Forms.Padding(2);
            this.buyukBoy.Name = "buyukBoy";
            this.buyukBoy.Size = new System.Drawing.Size(56, 16);
            this.buyukBoy.TabIndex = 2;
            this.buyukBoy.TabStop = true;
            this.buyukBoy.Text = "Büyük";
            this.buyukBoy.UseVisualStyleBackColor = true;
            // 
            // ortaBoy
            // 
            this.ortaBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ortaBoy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ortaBoy.Location = new System.Drawing.Point(74, 17);
            this.ortaBoy.Margin = new System.Windows.Forms.Padding(2);
            this.ortaBoy.Name = "ortaBoy";
            this.ortaBoy.Size = new System.Drawing.Size(56, 16);
            this.ortaBoy.TabIndex = 1;
            this.ortaBoy.TabStop = true;
            this.ortaBoy.Text = "Orta";
            this.ortaBoy.UseVisualStyleBackColor = true;
            // 
            // kucukBoy
            // 
            this.kucukBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.kucukBoy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucukBoy.Location = new System.Drawing.Point(4, 17);
            this.kucukBoy.Margin = new System.Windows.Forms.Padding(2);
            this.kucukBoy.Name = "kucukBoy";
            this.kucukBoy.Size = new System.Drawing.Size(56, 16);
            this.kucukBoy.TabIndex = 0;
            this.kucukBoy.TabStop = true;
            this.kucukBoy.Text = "Küçük";
            this.kucukBoy.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(152, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Hamburger Seçimi:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(149, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 435);
            this.label5.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "BurgerNaut Sipariş Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::BurgerNaut.Sunum.Properties.Resources.BURGERNAUT;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox2.Location = new System.Drawing.Point(264, 205);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 19);
            this.checkBox2.TabIndex = 50;
            this.checkBox2.Text = "Turşu";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox6.Location = new System.Drawing.Point(157, 269);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(90, 19);
            this.checkBox6.TabIndex = 53;
            this.checkBox6.Text = "Burger Sos";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox3.Location = new System.Drawing.Point(264, 237);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 19);
            this.checkBox3.TabIndex = 52;
            this.checkBox3.Text = "Domates";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox4.Location = new System.Drawing.Point(157, 237);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 19);
            this.checkBox4.TabIndex = 51;
            this.checkBox4.Text = "Ranch Sos";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(157, 205);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 19);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Cheddar Peyniri";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(154, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Ekstra Malzemeler:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(152, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "İçecek Seçimi:";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSaat.Location = new System.Drawing.Point(6, 220);
            this.lblSaat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(63, 15);
            this.lblSaat.TabIndex = 40;
            this.lblSaat.Text = "Tarih Saat";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTarih.Location = new System.Drawing.Point(6, 200);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(63, 15);
            this.lblTarih.TabIndex = 39;
            this.lblTarih.Text = "Tarih Saat";
            // 
            // burgerlerBox
            // 
            this.burgerlerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.burgerlerBox.FormattingEnabled = true;
            this.burgerlerBox.Items.AddRange(new object[] {
            "arda"});
            this.burgerlerBox.Location = new System.Drawing.Point(154, 24);
            this.burgerlerBox.Margin = new System.Windows.Forms.Padding(2);
            this.burgerlerBox.Name = "burgerlerBox";
            this.burgerlerBox.Size = new System.Drawing.Size(200, 21);
            this.burgerlerBox.TabIndex = 69;
            // 
            // iceceklerBox
            // 
            this.iceceklerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iceceklerBox.FormattingEnabled = true;
            this.iceceklerBox.Location = new System.Drawing.Point(154, 66);
            this.iceceklerBox.Margin = new System.Windows.Forms.Padding(2);
            this.iceceklerBox.Name = "iceceklerBox";
            this.iceceklerBox.Size = new System.Drawing.Size(200, 21);
            this.iceceklerBox.TabIndex = 70;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 407);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 31);
            this.button6.TabIndex = 71;
            this.button6.Text = "Yönetici Girişi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sepetList
            // 
            this.sepetList.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sepetList.FormattingEnabled = true;
            this.sepetList.ItemHeight = 20;
            this.sepetList.Location = new System.Drawing.Point(361, 24);
            this.sepetList.Margin = new System.Windows.Forms.Padding(2);
            this.sepetList.Name = "sepetList";
            this.sepetList.Size = new System.Drawing.Size(652, 364);
            this.sepetList.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 456);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.iceceklerBox);
            this.Controls.Add(this.burgerlerBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sepetList);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boxAdet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown boxAdet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton buyukBoy;
        private System.Windows.Forms.RadioButton ortaBoy;
        private System.Windows.Forms.RadioButton kucukBoy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ComboBox burgerlerBox;
        private System.Windows.Forms.ComboBox iceceklerBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox sepetList;
    }
}

