using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerNaut.VarlikKatmani;

namespace BurgerNaut.Sunum.IcecekViews
{
    public partial class FrmIcecek : Form
    {
        public Icecek Icecek { get; set; }

        public FrmIcecek() : this(new Icecek()) { }
        

        public FrmIcecek(Icecek icecek)
        {
            InitializeComponent();
            Icecek = icecek;
            txticecekAd.Text = Icecek.Ad;
            txticecekFiyat.Text = Icecek.Fiyat.ToString("C2");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

            var YeniFiyat = txticecekFiyat.Text.Replace("₺", "").Replace(" ", "");
            if (decimal.TryParse(YeniFiyat, out decimal fiyat))
            {
                Icecek = new Icecek
                {
                    Ad = txticecekAd.Text,
                    Fiyat = fiyat,
                    Id = Icecek.Id,
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

    }
}
