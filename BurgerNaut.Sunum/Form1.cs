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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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



        private void button1_Click(object sender, EventArgs e)
        {
            var burger = burgerlerBox.SelectedItem;
            var icecek = iceceklerBox.SelectedItem;

            if (burger != null && icecek != null)
            {
                BurgerRepository burgerRep = new BurgerRepository();
                IcecekRepository icecekRep = new IcecekRepository();

                var ekstraFiyat = 0;
                string boy = "Küçük";
                if (ortaBoy.Checked)
                {
                    ekstraFiyat += 10;
                    boy = "Orta";
                }
                else if (buyukBoy.Checked)
                {
                    ekstraFiyat += 15;
                    boy = "Büyük";
                }

                int checkedEkstra = 0;
                List<string> selectedEkstras = new List<string>();
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox checbox && checbox.Checked)
                    {
                        checkedEkstra++;
                        selectedEkstras.Add(checbox.Text);
                    }
                }
                string[] listEkstra = selectedEkstras.ToArray();
                ekstraFiyat = ekstraFiyat + (checkedEkstra * 5);

                int adet = (int)boxAdet.Value;

                // sepete ekleme verileri
                string boyut = boy;
                string burgerAd = burger.ToString().Split('-')[0].Trim();

                string icecekAd = icecek.ToString().Split('-')[0].Trim();
                if (icecekAd == null)
                {
                    icecekAd = "İçecek Yok";
                }

                    var burgerString = burgerlerBox.SelectedItem.ToString(); // Örnek: "Cheeseburger - 50"
                    burgerString = burgerString.Replace("₺", "").Trim();
                    var parts = burgerString.Split('-');
                    var fiyatText = parts[1].Trim();
                    var burgerFiyat = decimal.Parse(fiyatText);

                    string ekstralar = string.Join(",", selectedEkstras);
                    decimal toplamFiyat = (burgerFiyat + ekstraFiyat) * adet;
                    string sepet = $"{burgerAd} ({boyut}) \n {icecekAd} \n  Eks({ekstralar}) x {adet} | {toplamFiyat:C2}";
                    
                    sepetList.Items.Add(sepet);



            }
            else
            {
                MessageBox.Show("Hamburger ve İçecek seçmeden ilerleyemezsin.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sepetList.SelectedItem != null)
            {
                sepetList.Items.Remove(sepetList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sepetList.Items.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (sepetList.Items.Count > 0)
            {
                SatisRepository satisRepo = new SatisRepository();
                decimal toplamTutar = 0;
                var tempList = sepetList.Items.Cast<object>().ToList();
                foreach (var item in tempList)
                {
                    string sepet = item.ToString();
                    string[] parts = sepet.Split('₺');
                    if (parts.Length == 2)
                    {
                        decimal tutar = Convert.ToDecimal(parts[1].Trim());
                        toplamTutar += tutar;
                    }
                    string menuDetay = parts[0].Trim();
                    Satis satis = new Satis
                    {
                        Tarih = DateTime.Now,
                        Tutar = toplamTutar,
                        MenuDetay = menuDetay
                    };

                    DialogResult res = MessageBox.Show($"{toplamTutar:C2} tutarındaki siparişi tamamlamak üzeresin onaylıyor musun?", "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(res == DialogResult.Yes)
                    {
                        if (satisRepo.AddSatis(satis) > 0)
                        {
                            sepetList.Items.Clear();
                            MessageBox.Show("Sipariş Tamamlandı.");
                        }
                        else
                        {
                            MessageBox.Show("Sipariş kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else
                    {
                        MessageBox.Show("Sipariş iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            } else
            {
                MessageBox.Show("Sepet boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}