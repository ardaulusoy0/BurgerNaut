using BurgerNaut.VarlikKatmani;
using System;
using System.Windows.Forms;

namespace BurgerNaut.Sunum.BurgerViews
{
    public partial class FrmBurger : Form
    {
        public Burger Burger { get; set; }

        public FrmBurger() : this(new Burger()) { }
        
        public FrmBurger(Burger burger)
        {
            InitializeComponent();
            Burger = burger;
            txtburgerAd.Text = Burger.Ad;
            txtburgerFiyat.Text = Burger.Fiyat.ToString("C2");
        }
                

        private void button2_Click(object sender, EventArgs e)
        {
            /*fiyatı decimal olarak parse edemediği için yeni değerleri almıyordu, şimdi karakterleri
             falan silip gönderince parse edebilir sorun olmaz*/

            var YeniFiyat = txtburgerFiyat.Text.Replace("₺", "").Replace(" ", "");
            if (decimal.TryParse(YeniFiyat, out decimal fiyat))
            {
                Burger = new Burger
                {
                    Ad = txtburgerAd.Text,
                    Fiyat = fiyat,
                    Id = Burger.Id,
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        
    }
}
