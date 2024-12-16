using BurgerNaut.Sunum.BurgerViews;
using BurgerNaut.VarlikKatmani;
using BurgerNaut.Veritabani;
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

namespace BurgerNaut.Sunum.IcecekViews
{
    public partial class FrmIcecekList : Form
    {
        private BindingSource source = new BindingSource();
        private IcecekRepository icecekRepo = new IcecekRepository();
        public ComboBox parentDrinksBox;

        private void LoadDrinks()
        {
            if (icecekRepo == null)
            {
                MessageBox.Show("icecek repository başlatılmadı.");
                return;
            }

            var iceceks = icecekRepo.GetIceceks();
            if (iceceks == null || iceceks.Count == 0)
            {
                MessageBox.Show("Veritabanında icecek bulunamadı.");
                return;
            }

            source.DataSource = iceceks;
            icecekBox.DataSource = null;
            icecekBox.DataSource = source;
            icecekBox.DisplayMember = "DispName";
            icecekBox.ValueMember = "Id";  

            if (parentDrinksBox != null)
            {
                parentDrinksBox.Items.Clear();

                parentDrinksBox.Items.Add("İçecek Seçiniz");
                parentDrinksBox.SelectedIndex = 0;
                foreach (var icecekEkle in iceceks)
                {
                    parentDrinksBox.Items.Add($"{icecekEkle.Ad} - {icecekEkle.Fiyat:C2}");
                }
            }
        }



        public FrmIcecekList()
        {
            InitializeComponent();
            LoadDrinks();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmIcecek icecekForm = new FrmIcecek();
            if (icecekForm.ShowDialog() == DialogResult.OK)
            {
                Icecek newDrinks = icecekForm.Icecek;
                if (newDrinks != null)
                {

                    int result = icecekRepo.AddIcecek(newDrinks);
                    if (result > 0)
                    {

                        MessageBox.Show("İçecek Eklendi");
                        LoadDrinks();
                        source.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("İçecek eklenirken bir hata oluştu.");
                    }

                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Icecek selectedIcecek = icecekBox.SelectedItem as Icecek;
            if (selectedIcecek != null)
            {
                FrmIcecek icecekForm = new FrmIcecek(selectedIcecek);
                icecekForm.Icecek.Id = selectedIcecek.Id;
                if (icecekForm.ShowDialog() == DialogResult.OK)
                {
                    Icecek updatedBurger = icecekForm.Icecek;
                    if (updatedBurger != null)
                    {
                        updatedBurger.Id = selectedIcecek.Id;

                        int result = icecekRepo.UpdtIcecek(updatedBurger);
                        if (result > 0)
                        {
                            MessageBox.Show("İçecek başarıyla güncellendi.");
                            LoadDrinks();
                        }
                        else
                        {
                            MessageBox.Show("İçecek güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir İçecek seçiniz.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (icecekBox.SelectedItem != null)
            {
                Icecek secIcecek = icecekBox.SelectedItem as Icecek;

                if (secIcecek != null)
                {
                    DialogResult res = MessageBox.Show(
                        $"{secIcecek.Ad} adlı içeceği silmek üzeresiniz. Emin misiniz?",
                        "Silme İşlemi",
                        MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        int result = icecekRepo.DelIcecek(secIcecek.Id);
                        if (result > 0)
                        {
                            MessageBox.Show("İçecek başarıyla silindi.");
                            LoadDrinks(); // Listeyi güncelle

                        }
                        else
                        {
                            MessageBox.Show("İçecek silinirken bir hata oluştu.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen öğe bir İçecek değil.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir İçecek seçiniz.");
            }
        }

       
    }
}
