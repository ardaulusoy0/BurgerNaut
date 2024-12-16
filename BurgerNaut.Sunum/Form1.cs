using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerNaut.VarlikKatmani;
using BurgerNaut.Veritabani;
using BurgerNaut.Veritabani.Repos;
using BurgerNaut.Sunum.AdminViews;

namespace BurgerNaut.Sunum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BurgerGoster()
        {
            BurgerRepository burgerRepo = new BurgerRepository();
            List<Burger> burgerList = burgerRepo.GetBurgers();

            burgerlerBox.Items.Clear();
            burgerlerBox.Items.Add("Burger Seçiniz.");
            foreach (var burger in burgerList)
            {
                burgerlerBox.Items.Add($"{burger.Ad} - {burger.Fiyat:C2}");
            }

            if (burgerlerBox.Items.Count > 0)
            {
                burgerlerBox.SelectedIndex = 0;
            }
        }

        private void IcecekGoster()
        {

            IcecekRepository icecekRepo = new IcecekRepository();
            List<Icecek> icecekList = icecekRepo.GetIceceks();

            iceceklerBox.Items.Clear();
            iceceklerBox.Items.Add("İçecek Seçiniz.");
            foreach (var icecek in icecekList)
            {
                iceceklerBox.Items.Add($"{icecek.Ad} - {icecek.Fiyat:C2}");
            }

            if (iceceklerBox.Items.Count > 0)
            {
                iceceklerBox.SelectedIndex = 0;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açıldığında tarih ve saati al.
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            // Her saniye güncellesin.
            timer1.Start();
            BurgerGoster();
            IcecekGoster();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminGiris admin = new AdminGiris();
            
            admin.parentBurgerlerBox = burgerlerBox;
            admin.parentDrinksBox = iceceklerBox;
            admin.Show();
        }

       

    }
}
