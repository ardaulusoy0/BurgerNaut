using BurgerNaut.VarlikKatmani;
using BurgerNaut.Veritabani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerNaut.Sunum.IcecekViews
{
    public partial class FrmIcecekList : Form
    {
        public FrmIcecekList()
        {
            InitializeComponent();
        }

        private void GetBurgers()
        {
            DBAccess<Burger> db = new DBAccess<Burger>();

        }
        private void FrmIcecekList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
