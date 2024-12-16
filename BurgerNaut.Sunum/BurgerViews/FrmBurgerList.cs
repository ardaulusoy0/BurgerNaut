using BurgerNaut.VarlikKatmani;
using System;
using System.Windows.Forms;
using BurgerNaut.Veritabani.Repos;

namespace BurgerNaut.Sunum.BurgerViews
{
    public partial class FrmBurgerList : Form
    {
        private BindingSource source = new BindingSource();
        private BurgerRepository burgerRepo = new BurgerRepository();
        public ComboBox parentBurgerlerBox;

        private void LoadBurgers()
        {
            // Veritabanından burgerleri alıp listeye bağlıyoruz
            if (burgerRepo == null)
            {
                MessageBox.Show("Burger repository başlatılmadı.");
                return;
            }

            var burgers = burgerRepo.GetBurgers();
            if (burgers == null || burgers.Count == 0)
            {
                MessageBox.Show("Veritabanında burger bulunamadı.");
                return;
            }

            // BindingSource'a bağla ve ListBox'u güncelle
            source.DataSource = burgers;
            burgerBox.DataSource = null; // Önce sıfırla
            burgerBox.DataSource = source;
            burgerBox.DisplayMember = "Ad";  // Görünen alan Ad
            burgerBox.ValueMember = "Id";   // Arka planda Id kullan

            if(parentBurgerlerBox != null)
            {
                parentBurgerlerBox.Items.Clear();

                parentBurgerlerBox.Items.Add("Burger Seçiniz");
                parentBurgerlerBox.SelectedIndex = 0;
                foreach (var burgerEkle in burgers)
                {
                    parentBurgerlerBox.Items.Add($"{burgerEkle.Ad} - {burgerEkle.Fiyat:C2}");
                }
            }
        }

       
        public FrmBurgerList()
        {
            InitializeComponent();
            LoadBurgers(); 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmBurger burgerForm = new FrmBurger();
            if(burgerForm.ShowDialog() == DialogResult.OK)
            {
                Burger newBurger = burgerForm.Burger;
                if(newBurger != null)
                {
                    int result = burgerRepo.AddBurger(newBurger);
                    if(result > 0)
                    {
                        MessageBox.Show("Burger Eklendi");
                        LoadBurgers();
                        source.ResetBindings(false);
                    } else
                    {
                        MessageBox.Show("Burger eklenirken bir hata oluştu.");
                    }

                } else
                {
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Burger selectedBurger = burgerBox.SelectedItem as Burger;
            if (selectedBurger != null)
            {
                FrmBurger burgerForm = new FrmBurger(selectedBurger);
                burgerForm.Burger.Id = selectedBurger.Id;
                if (burgerForm.ShowDialog() == DialogResult.OK)
                {
                    Burger updatedBurger = burgerForm.Burger;
                    if (updatedBurger != null)
                    {
                        updatedBurger.Id = selectedBurger.Id;

                        int result = burgerRepo.UpdtBurger(updatedBurger);
                        if (result > 0)
                        {
                            MessageBox.Show("Burger başarıyla güncellendi.");
                            LoadBurgers();
                        }
                        else
                        {
                            MessageBox.Show("Burger güncellenirken bir hata oluştu.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir burger seçiniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Seçili burgeri silme
            if (burgerBox.SelectedItem != null)
            {
                Burger secBurger = burgerBox.SelectedItem as Burger;

                if (secBurger != null)
                {
                    DialogResult res = MessageBox.Show(
                        $"{secBurger.Ad} adlı burgeri silmek üzeresiniz. Emin misiniz?",
                        "Silme İşlemi",
                        MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        int result = burgerRepo.DelBurger(secBurger.Id);
                        if (result > 0)
                        {
                            MessageBox.Show("Burger başarıyla silindi.");
                            LoadBurgers(); // Listeyi güncelle

                        }
                        else
                        {
                            MessageBox.Show("Burger silinirken bir hata oluştu.");
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

        private void FrmBurgerList_Load(object sender, EventArgs e)
        {

        }
    }
}
