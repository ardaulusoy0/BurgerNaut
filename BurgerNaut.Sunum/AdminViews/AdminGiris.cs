using BurgerNaut.Sunum.BurgerViews;
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

namespace BurgerNaut.Sunum.AdminViews
{
    public partial class AdminGiris : Form
    {
        public ComboBox parentBurgerlerBox;
        public ComboBox parentDrinksBox;

        public AdminGiris()
        {
            InitializeComponent();
            txtKadi.Text = "user1";
            txtPass.Text = "1234";
        }

        private void vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text.Equals("user1") && txtPass.Text.Equals("1234"))
            {
                this.DialogResult = DialogResult.OK;
                MenuKontrol menu = new MenuKontrol();
                menu.parentBurgerlerBox = parentBurgerlerBox;
                menu.parentDrinksBox = parentDrinksBox;
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
    }
}
