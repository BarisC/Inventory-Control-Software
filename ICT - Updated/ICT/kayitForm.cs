using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Collections;


namespace ICT
{
    public partial class kayitForm : Form
    {
        string[] basliklar = new string[30]; // Kolonların base headerları tutulur.
        string[] kolonBicimleriList = new string[30]; // Kolonların biçimleri tutulur.
        string DosyaYolu; // Upload edilen excellin yolu.
        string DosyaAdi;  // Upload edilen excellin adı.
        string sicilNo; //Üyelerin sicil numaraları tutulur.
        int kolonSayac = 0; //Kolonlarda gezinmek için kullanılan sayaç.
        String metin; //Labeldan gelen dosya yolunu tutar.
        int kolonBicimSayac = 0;
        ArrayList kayitlarListe = new ArrayList(); //Girilmiş kayıtların tutulduğu dinamik dizi.
        int kayitlarListSayac = 0;//Dinamik dizinin boyutu.
        string sonMetin;
        string sonPara;
        string sonSayi;
        string sonKoordinat;
        string sonOlcu;
        int girdiTanimSayac = 0;//Kolon Tanımları için sayaç.
        int kayitSonu = 0;//Girdi Butonu Tamponu.
        ArrayList exceKayitListesi = new ArrayList();
        public kayitForm()
        {
            InitializeComponent();
            sicilGroup.Visible = true;
            kayitBaslaGroup.Visible = false;
            paraGroupBox.Visible = false;
            olcuGroupBox.Visible = false;
            sayiGroupBox.Visible = false;
            koordinatGroupBox.Visible = false;
            metinGroupBox.Visible = false;
            tamamlaKayit.Visible = false;
            girdiButon.Visible = false;
        }


        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }



        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {

            if (sicilNoText.Text.Length == 6 || sicilNoText.Text.Length == 7)
            {
                if (SayiMi(sicilNoText.Text) == true)
                {
                    DialogResult dialog = MessageBox.Show("Giriş Başarılı!");
                    sicilGroup.Visible = false;
                    kayitBaslaGroup.Visible = true;
                    sicilNo = sicilNoText.Text;
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Lütfen Geçerli Bir Sicil Numarası Giriniz!");
                sicilNoText.Clear();
            }
            //sicilGroup.Visible = false;
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void insertData()//Excel Bağlantısı kuruyoruz.
        {

            string password = "ttnet61";
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DosyaYolu + ";  Extended Properties='Excel 12.0 xml;HDR=YES;'");
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Records$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            baglanti.Close();
            kolonGetir();//Bağlantı kurulduktan sonra kolon bilgisi çekilmesi için kolonGetir çağırılır.
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void kolonGetir()//Kolon Bilgilerini diziye atıyoruz.
        {
            int kolonSayisi = dataGridView1.Columns.Count;
            
            for (int i = 0; i < kolonSayisi; i++)
            {
                basliklar[i] = dataGridView1.Columns[i].HeaderText;
            }
            kolonBicimleri(); //Kolonlar çekildikten sonra biçimlerine ayrışması için kolonBicimleri fonksiyonu çağırıylır.
            kolonTanim();//Admin tarafından belirlenen kolon isimlerini ayrıştırır.
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        void kolonBicimleri() //Bu fonksiyon kolon biçimlerini getirip bir diziye aktarır.
        {
            int kolonSayisi = dataGridView1.Columns.Count;
            char[] buffer = new char[kolonSayisi];
            string geciciMetin;
            char start = '(';
            char stop = ')';

            for (int i = 0; i < kolonSayisi - 2; i ++)
            {
                char[] bufferChar = new char[50];
                geciciMetin = basliklar[i];
                char[] ayir = geciciMetin.ToCharArray(); //String char dizisine çevrilir.
                int whiledeger = 0;
                int sonsuzSayac = 1;
                while(sonsuzSayac > 0) //Sonsuz döngü
                {
                    if (ayir[whiledeger] == start)
                    {
                        int bufferDeger = whiledeger + 1;
                        int bufferYeniDeger = 0;
                        while (ayir[bufferDeger] != stop)
                        {
                            bufferChar[bufferYeniDeger] = ayir[bufferDeger];
                            bufferYeniDeger++;
                            bufferDeger++;
                        }//Kelime üretilen döngü
                        break;
                    }
                    whiledeger++;
                }//Sonsuz sayaç
                string metinTur = new string(bufferChar); //Her adımda çıkan kelime stringe çevrilir. 
                listBox1.Items.Add(metinTur); //Her adımda çıkan stringler listbox'a eklenir. 
            }//Başlıkları sıra ile alır.

            
        }//Girdi Ekranı


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            void kolonTanim()//Kolon stringlerini ( karaterine kadar olan kısmın tutar listbox2'de.
            {
            int kolonSayisi = dataGridView1.Columns.Count;//Gridview boyutu alınır.
            char[] buffer2 = new char[kolonSayisi];
            string geciciMetinY;
            char start = '(';

            for (int i = 0; i < kolonSayisi; i++)
            {
                char[] bufferCharY = new char[50];
                geciciMetinY = basliklar[i];
                char[] ayirY = geciciMetinY.ToCharArray(); //String char dizisine çevrilir.
                int whiledegerY = 0;
                int sonsuzSayacY = 1;
                while (sonsuzSayacY > 0) //Sonsuz döngü
                {
                    if (ayirY[whiledegerY] != start)
                    {
                        bufferCharY[whiledegerY] = ayirY[whiledegerY];
                    }
                    else
                        break;
                    
                    whiledegerY++;
                    
                }//Sonsuz sayaç
                string metinTur2 = new string(bufferCharY);
                listBox4.Items.Add(metinTur2);
            }//Başlıkları sıra ile alır.
        }






////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        void girdiBasla()//GroupBoxlar hazır hale getiriliyor.
        {
            int listBoxBoyut = listBox1.Items.Count;//Listbox1'in boyutu
            if(kolonSayac < listBoxBoyut)
            {
                string bicim = listBox1.Items[kolonSayac].ToString();//Listbox1'in elemanlarını sırayla getirip bicim stringine atar.
                label1.Text = bicim;//Bicim kontrol lable'i




                if (label1.Text == "Metin")
                {
                    paraGroupBox.Visible = false;
                    olcuGroupBox.Visible = false;
                    sayiGroupBox.Visible = false;
                    metinGroupBox.Visible = true;
                    koordinatGroupBox.Visible = false;
                    metinKolonTanim.Text = listBox4.Items[girdiTanimSayac].ToString();
                    girdiTanimSayac++;

                }
                else if (label1.Text == "Ondalıksız" ||
                        label1.Text == "Ondalıklı")
                {
                    sayiLabel.Text = label1.Text;
                    paraGroupBox.Visible = false;
                    olcuGroupBox.Visible = false;
                    sayiGroupBox.Visible = true;
                    metinGroupBox.Visible = false;
                    koordinatGroupBox.Visible = false;
                    sayiEkleHazirlik();
                    sayiKolonTanim.Text = listBox4.Items[girdiTanimSayac].ToString();
                    girdiTanimSayac++;
                }
                else if (label1.Text == "TRY" ||
                        label1.Text == "DOLAR" ||
                        label1.Text == "EURO" ||
                        label1.Text == "STERLIN" ||
                        label1.Text == "YEN")
                {
                    paraLabel.Text = label1.Text;
                    paraGroupBox.Visible = true;
                    olcuGroupBox.Visible = false;
                    sayiGroupBox.Visible = false;
                    metinGroupBox.Visible = false;
                    koordinatGroupBox.Visible = false;
                    paraKolonTanim.Text = listBox4.Items[girdiTanimSayac].ToString();
                    girdiTanimSayac++;
                }
                else if (label1.Text == "km" ||
                        label1.Text == "m" ||
                        label1.Text == "cm" ||
                        label1.Text == "mm" ||
                        label1.Text == "dm2" ||
                        label1.Text == "km2" ||
                        label1.Text == "m2" ||
                        label1.Text == "cm2" ||
                        label1.Text == "m3/dak" ||
                        label1.Text == "m3")
                {
                    olcuLabel.Text = label1.Text;
                    paraGroupBox.Visible = false;
                    olcuGroupBox.Visible = true;
                    sayiGroupBox.Visible = false;
                    koordinatGroupBox.Visible = false;
                    metinGroupBox.Visible = false;
                    olcuKolonTanim.Text = listBox4.Items[girdiTanimSayac].ToString();
                    girdiTanimSayac++;
                }
                else if (label1.Text == "Koordinat")
                {

                    paraGroupBox.Visible = false;
                    olcuGroupBox.Visible = false;
                    sayiGroupBox.Visible = false;
                    koordinatGroupBox.Visible = true;
                    metinGroupBox.Visible = false;
                    koordinatKolonTanim.Text = listBox4.Items[girdiTanimSayac].ToString();
                    girdiTanimSayac++;

                }
                kolonSayac++;
                if (kolonSayac > listBoxBoyut)//kolonBicimleriList.Length - 2)
                {
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            else
            {
                tamamlaKayit.Visible = true;
            }
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        void ParaEkle()//TAMAMLANDI.
            {
                if(paraBox != null)
                {
                    if(SayiMi(sicilNoText.Text) == true)
                    {
                        sonPara = paraBox.Text;
                        kayitlarListe.Add(sonPara);
                        kayitlarListSayac++;
                        paraBox.Clear();
                        girdiBasla();
                    }
                }
                kontrolLabel.Text = sonPara;
            }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            void MetinEkle()//TAMAMLANDI.
            {
                sonMetin = metintxtGiris.Text;
                kontrolLabel.Text = sonMetin;
                kayitlarListe.Add(sonMetin);
                kayitlarListSayac++;
                exceKayitListesi.Add(sonMetin);
                metintxtGiris.Clear();
                girdiBasla();
            }



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            void SayiEkle()//TAMAMLANDI.
            {
                if (label1.Text == "Ondalıksız")
                {
                    sonSayi = sayiBox.Text;
                    kayitlarListe.Add(sonSayi); //Dinamik diziye kaydı yapılır.
                    kayitlarListSayac++;
                    exceKayitListesi.Add(sonSayi);
                    sayiBox.Clear();
                    girdiBasla();//Kayıt işlemi başarılı ise bir sonraki kayit için girdiBasla çağırılır.
            }
                else if (label1.Text == "Ondalıklı")
                {
                    if(ondalikBox.Text.Length > 3)
                    {
                        MessageBox.Show("Ondalık kısmı en fazla 3 basamak olabilir!");
                        sayiBox.Clear();
                        ondalikBox.Clear();
                        sayiEkleHazirlik();
                    } 
                    else if(ondalikBox.Text.Length <= 3)
                    {
                        sonSayi = sayiBox.Text + "," + ondalikBox.Text;
                        kayitlarListe.Add(sonSayi); //Dinamik diziye kaydı yapılır.
                        kayitlarListSayac++;
                        exceKayitListesi.Add(sonSayi);
                        sayiBox.Clear();
                        girdiBasla();//Kayıt işlemi başarılı ise bir sonraki kayit için girdiBasla çağırılır.
                    }
                }
                kontrolLabel.Text = sonSayi;
            }


        void sayiEkleHazirlik()//TAMAMLANDI.
            {
                if (label1.Text == "Ondalıksız")
                {
                    ondalikBox.Visible = false;
                    materialLabel2.Visible = false;
                }
                else if (label1.Text == "Ondalıklı")
                {
                    ondalikBox.Visible = true;
                }
            }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            void KoordinatEkle()//TAMAMLANDI.
            {   
                if(ko1.Text != "" && ko2.Text != "" && ko3.Text != "" && ko4.Text != "")
                {
                    sonKoordinat = ko1.Text + " " + ko2.Text + " " + ko3.Text + "." + ko4.Text;
                    kayitlarListe.Add(sonKoordinat);
                    kayitlarListSayac++;
                    exceKayitListesi.Add(sonKoordinat);
                    ko1.Clear();
                    ko2.Clear();
                    ko3.Clear();
                    ko4.Clear();
                    girdiBasla();
                }
                else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!!");
                ko1.Clear();
                ko2.Clear();
                ko3.Clear();
                ko4.Clear();
            }
                kontrolLabel.Text = sonKoordinat;
            }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            void OlcuEkle()//TAMAMLANDI.
            {
                if(olcuBox.Text != "" && olcuOndalikBox.Text != "")
                {
                    if(olcuOndalikBox.Text.Length >= 2)
                    {
                        sonOlcu = olcuBox.Text + "," + olcuOndalikBox.Text;
                        kayitlarListe.Add(sonKoordinat);
                        kayitlarListSayac++;
                        exceKayitListesi.Add(sonOlcu);
                        olcuBox.Clear();
                        olcuOndalikBox.Clear();
                        girdiBasla();
                }
                    else
                    {
                        MessageBox.Show("Virgül sonrası en az 2 basamak olmalı!");
                        olcuBox.Clear();
                        olcuOndalikBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız!");
                    olcuBox.Clear();
                    olcuOndalikBox.Clear();
                }
            }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void OpenFile()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Tüm dosyalar| *.*";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.ShowDialog();
            DosyaYolu = file.FileName;
            DosyaAdi = file.SafeFileName;
            insertData();
            kayitBaslaGroup.Visible = false;
            girdiButon.Visible = true;
        }

        

        public void WriteData()
        {
            excel excel = new excel(DosyaYolu, 1); //Üzerine yazılacak Excellw
            int c = 0;
            int sonsuz = 1;
            while(sonsuz > 0)
            {
                if (excel.ReadCell(c, 0).ToString().Length != 0)
                {
                    c++;
                }
                else
                    break;
            }
            for (int t = 0; t < listBox3.Items.Count; t++)//Kolonları sayar.
            {
                excel.WriteToCell(c, t, listBox3.Items[t].ToString());
            }
            excel.WriteToCell(c, listBox3.Items.Count, sicilNo);
            excel.WriteToCell(c, listBox3.Items.Count + 1, System.DateTime.Now.ToString());
            //excel.Save();
            excel.SaveAs(@"C:\Users\Baris\Desktop\Test2.xlsx");// Yazılmış dosyanın kayıt yeri.
            excel.Close();
            Application.Exit();
        }

        void excelSendRecords()
        {

            WriteData();
            Application.Restart();

        }

        //private void MaterialFlatButton4_Click(object sender, EventArgs e)
        //{
        //    //string output = "D://sahaBilgileri_Baris.rar";
        //    //File.SetAttributes(output, FileAttributes.Hidden);  BU FONKSİYON DOSYA GİZLER. LAZIM OLACAK.
        //    girdiBasla();
        //}

        private void MetinEkle_Click(object sender, EventArgs e)//Metin ekle fonksiyonu çağırılır.
        {
            MetinEkle();
        }

        private void ParaEkle_Click(object sender, EventArgs e)//Para ekle fonksiyonu çağırılır.
        {
            ParaEkle();
        }

        private void SayiEkle_Click(object sender, EventArgs e)//Sayı ekle fonksiyonu çağırılır.
        {
            SayiEkle();
        }

        private void OlcuEkle_Click(object sender, EventArgs e)//Ölçü ekle fonksiyonu çağırılır.
        {
            OlcuEkle();
        }

        private void KoordinatEkle_Click(object sender, EventArgs e)//Koordinat ekle fonksiyonu çağırılır.
        {
            KoordinatEkle();
        }

        private void MaterialFlatButton3_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void insertRecords_Click(object sender, EventArgs e)
        {
            
            if (kayitSonu < listBox1.Items.Count)
            {
                girdiBasla();
                kayitSonu++;
                girdiButon.Visible = false;
            }
            else
            {
                MessageBox.Show("Tüm Kayıtlar Girildi.");
                girdiButon.Visible = false;
                tamamlaKayit.Visible = true;
            }
        }

        private void KayitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void TamamlaKayit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kayitlarListe.Count; i++)
            {
                listBox3.Items.Add(kayitlarListe[i]);
            }
            excelSendRecords();
        }
    }
}


