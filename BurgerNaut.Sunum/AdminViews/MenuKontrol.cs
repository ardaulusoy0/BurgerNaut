using BurgerNaut.Sunum.BurgerViews;
using BurgerNaut.Sunum.IcecekViews;
using BurgerNaut.Sunum.SatisViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerNaut.Sunum.AdminViews
{
    public partial class MenuKontrol : Form
    {
        public ComboBox parentBurgerlerBox;
        public ComboBox parentDrinksBox;

        public MenuKontrol()
        {
            InitializeComponent();
        }

        private void showBurgers_Click(object sender, EventArgs e)
        {
            FrmBurgerList burger = new FrmBurgerList();
            burger.parentBurgerlerBox = parentBurgerlerBox;
            burger.Show();
            this.Close();
            
        }

        private void showDrinks_Click(object sender, EventArgs e)
        {
            FrmIcecekList icecek = new FrmIcecekList();
            icecek.parentDrinksBox = parentDrinksBox;
            icecek.Show();
            this.Close();

        }

        private void showSatis_Click(object sender, EventArgs e)
        {
            FrmSatisList satis = new FrmSatisList();
            satis.Show();
            this.Close();
        }
    }
}
