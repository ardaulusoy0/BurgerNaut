using BurgerNaut.VarlikKatmani;
using BurgerNaut.Veritabani.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BurgerNaut.Sunum.SatisViews
{
    public partial class FrmSatisList : Form
    {
        SatisRepository satisRepo = new SatisRepository();

        public FrmSatisList()
        {
            InitializeComponent();

        }

     

        private void LoadSatislar()
        {
            SatisRepository satisRepo = new SatisRepository();
            List<Satis> satislar = satisRepo.GetSatis();
            lstSatislar.DataSource = satislar;
            lstSatislar.DisplayMember = "DispName"; 
            lstSatislar.ValueMember = "Id"; 

        }

        private void lstSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSatislar.SelectedItem != null)
            {


                Satis selectedSatis = lstSatislar.SelectedItem as Satis;
                if (selectedSatis != null)
                {
                    satisDetay.Items.Clear();

                    string menuDetay = selectedSatis.MenuDetay;  
                    string tutar = selectedSatis.Tutar.ToString("C2");
                    string tarih = selectedSatis.Tarih.ToString("dd/MM/yyyy"); 

                

                    string listele = $"Menu: {menuDetay} | Tutar: {tutar} | Tarih: {tarih}";
                    satisDetay.Items.Add(listele);
                    satisDetay.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Seçilen öğe bir Satis nesnesi değil.");
                }

                

            }
        }


        private void FrmSatisList_Load(object sender, EventArgs e)
        {
            LoadSatislar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstSatislar.SelectedItem != null)
            {
                Satis secSatis = lstSatislar.SelectedItem as Satis;

                if (secSatis != null)
                {
                    DialogResult res = MessageBox.Show(
                        $"{secSatis.Tutar:C2} tutarlı satışı silmek üzeresiniz. Emin misiniz?",
                        "Silme İşlemi",
                        MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        int result = satisRepo.DelSatis(secSatis.Id);
                        if (result > 0)
                        {
                            MessageBox.Show("Satış başarıyla silindi.");
                            LoadSatislar(); // Listeyi güncelle

                        }
                        else
                        {
                            MessageBox.Show("Satış silinirken bir hata oluştu.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen öğe bir Burger değil.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir burger seçiniz.");
            }
        }
    }
}
