using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace ICT
{

    public partial class admin : Form
    {
        public int sayac = 0;
        string[] kolonlarDizi = new string[50];


        public admin()
        {
            InitializeComponent();
            ondalikBox.Visible = false;
            paraBox2.Visible = false;
            olcuBox.Visible = false;
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Para Birimi")
            {
                paraBox2.Visible = true;
                ondalikBox.Visible = false;
                olcuBox.Visible = false;
            }
            else if(comboBox1.Text == "Ölçü Birimi")
            {
                olcuBox.Visible = true;
                paraBox2.Visible = false;
                ondalikBox.Visible = false;
            }
            else if(comboBox1.Text == "Sayı")
            {
                ondalikBox.Visible = true;
                paraBox2.Visible = false;
                olcuBox.Visible = false;
            }
            else if(comboBox1.Text == "Koordinat")
            {
                ondalikBox.Visible = false;
                paraBox2.Visible = false;
                olcuBox.Visible = false;
            }
            else if(comboBox1.Text == "Metin")
            {
                ondalikBox.Visible = false;
                paraBox2.Visible = false;
                olcuBox.Visible = false;
            }
        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            saveDatagrid(sayac);
            sayac += 1;
            ondalikBox.Visible = false;
            paraBox2.Visible = false;
            olcuBox.Visible = false;
            kolonText.Clear(); //Textbox içeriği temizlenir.
           
        }


        void saveDatagrid(int girdi)
        {
            String met = "";
            if (comboBox1.Text == "Sayı")
            {
                met = kolonText.Text + "  (" + ondalikBox.Text + ")";
            }
            else if (comboBox1.Text == "Metin")
            {
                met = kolonText.Text + "  (" + "Metin" + ")";
            }
            else if(comboBox1.Text == "Para Birimi")
            {
                met = kolonText.Text + "  (" + paraBox2.Text + ")";
            }
            else if (comboBox1.Text == "Ölçü Birimi")
            {
                met = kolonText.Text + "  (" + olcuBox.Text + ")";
            }
            else if (comboBox1.Text == "Koordinat")
            {
                met = kolonText.Text + "  (" + "Koordinat" + ")";
            }


            kolonlarDizi[girdi] = met;



            listBox1.Items.Add(kolonText.Text);
        }










        void saveData()
        {
            ChooseFolder();
            string sifre = sifreTxtBox.Text;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sayfa1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Records";
            for (int i = 0; i < sayac; i++)
            {
                worksheet.Cells[1, i + 1] = kolonlarDizi[i];
            }
            worksheet.Cells[1, sayac + 1] = "SicilNo (Ondalıksız)";
            worksheet.Cells[1, sayac + 2] = "Tarih (Metin)";
           



            //string encPass = encryptionName(sifreTxtBox.Text);
            String dosyaAdı;
            dosyaAdı = projeAdi.Text + "-" + projeSahibi.Text;
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = dosyaAdı;
            saveFileDialoge.DefaultExt = ".xlsx";
            string lastPath = path.Text;
            workbook.SaveAs(lastPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            path.Text = path.Text + dosyaAdı;
            app.Quit();
            Application.Exit();
        }

        public void ChooseFolder()//Bir dizinin path'ini getirir.
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)//folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Text = saveFileDialog1.FileName;
            }
        }


        public void ChooseFolder2()//Bir dizinin path'ini getirir.
        {

            path.Text = sifreTxtBox.Text;
            
        }


        public string encryptionName(string girdi)//Excel şifresinin şifrelenmesi. 
        {
            string pass = girdi; //Gelen şifre tutulur.
            int passLength = pass.Length;//Şifrenin uzunluğu.

            char[] ayir3 = pass.ToCharArray();//Gelen şifre diziye aktarılır.
            string encryptionPass;//Son çıktı olacak parametre tanımı.
            string[] total = new string[50];//For döngüsünde şifrenin tutulacağı değişken
            for (int sayac = 0; sayac < ayir3.Length; sayac++)
            {
                char deger = ayir3[sayac];
                switch (deger)
                {
                    case 'a': total[passLength - sayac] = "10"; break;
                    case 'b': total[passLength - sayac] = "11"; break;
                    case 'c': total[passLength - sayac] = "12"; break;
                    case 'd': total[passLength - sayac] = "13"; break;
                    case 'e': total[passLength - sayac] = "14"; break;
                    case 'f': total[passLength - sayac] = "15"; break;
                    case 'g': total[passLength - sayac] = "16"; break;
                    case 'h': total[passLength - sayac] = "17"; break;
                    case 'i': total[passLength - sayac] = "18"; break;
                    case 'j': total[passLength - sayac] = "19"; break;
                    case 'k': total[passLength - sayac] = "20"; break;
                    case 'l': total[passLength - sayac] = "21"; break;
                    case 'm': total[passLength - sayac] = "22"; break;
                    case 'n': total[passLength - sayac] = "23"; break;
                    case 'o': total[passLength - sayac] = "24"; break;
                    case 'p': total[passLength - sayac] = "25"; break;
                    case 'r': total[passLength - sayac] = "26"; break;
                    case 's': total[passLength - sayac] = "27"; break;
                    case 't': total[passLength - sayac] = "28"; break;
                    case 'u': total[passLength - sayac] = "29"; break;
                    case 'v': total[passLength - sayac] = "30"; break;
                    case 'y': total[passLength - sayac] = "31"; break;
                    case 'z': total[passLength - sayac] = "32"; break;
                    case 'x': total[passLength - sayac] = "33"; break;
                    case 'q': total[passLength - sayac] = "34"; break;
                    case 'w': total[passLength - sayac] = "35"; break;

                    case 'A': total[passLength - sayac] = "36"; break;
                    case 'B': total[passLength - sayac] = "37"; break;
                    case 'C': total[passLength - sayac] = "38"; break;
                    case 'D': total[passLength - sayac] = "39"; break;
                    case 'E': total[passLength - sayac] = "40"; break;
                    case 'F': total[passLength - sayac] = "41"; break;
                    case 'G': total[passLength - sayac] = "42"; break;
                    case 'H': total[passLength - sayac] = "43"; break;
                    case 'I': total[passLength - sayac] = "44"; break;
                    case 'J': total[passLength - sayac] = "45"; break;
                    case 'K': total[passLength - sayac] = "46"; break;
                    case 'L': total[passLength - sayac] = "47"; break;
                    case 'M': total[passLength - sayac] = "48"; break;
                    case 'N': total[passLength - sayac] = "49"; break;
                    case 'O': total[passLength - sayac] = "50"; break;
                    case 'P': total[passLength - sayac] = "51"; break;
                    case 'R': total[passLength - sayac] = "52"; break;
                    case 'S': total[passLength - sayac] = "53"; break;
                    case 'T': total[passLength - sayac] = "54"; break;
                    case 'U': total[passLength - sayac] = "55"; break;
                    case 'V': total[passLength - sayac] = "56"; break;
                    case 'Y': total[passLength - sayac] = "57"; break;
                    case 'Z': total[passLength - sayac] = "58"; break;
                    case 'X': total[passLength - sayac] = "59"; break;
                    case 'Q': total[passLength - sayac] = "60"; break;
                    case 'W': total[passLength - sayac] = "61"; break;

                    case '1': total[passLength - sayac] = "62"; break;
                    case '2': total[passLength - sayac] = "63"; break;
                    case '3': total[passLength - sayac] = "64"; break;
                    case '4': total[passLength - sayac] = "65"; break;
                    case '5': total[passLength - sayac] = "66"; break;
                    case '6': total[passLength - sayac] = "67"; break;
                    case '7': total[passLength - sayac] = "68"; break;
                    case '8': total[passLength - sayac] = "69"; break;
                    case '9': total[passLength - sayac] = "70"; break;
                    case '0': total[passLength - sayac] = "71"; break;
                    case '.': total[passLength - sayac] = "72"; break;
                    case ',': total[passLength - sayac] = "73"; break;
                    case '?': total[passLength - sayac] = "74"; break;
                    case '-': total[passLength - sayac] = "75"; break;
                    case '_': total[passLength - sayac] = "76"; break;
                    case '/': total[passLength - sayac] = "77"; break;
                    case '@': total[passLength - sayac] = "78"; break;
                }
            }
            encText.Text = ConvertStringArrayToString(total);
            encryptionPass = ConvertStringArrayToString(total);
            return encryptionPass;
        }
         static string ConvertStringArrayToString(string[] array)
        {
            //
            // Bu metod ile string builder nesne'mizi oluşturup
            // foreach döngüsü ve StringBuilder'in Append metodu
            // ilede stringimizi oluşturuyoruz
            //
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
            }
            return builder.ToString();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
