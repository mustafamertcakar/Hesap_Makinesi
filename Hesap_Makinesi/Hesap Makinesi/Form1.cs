using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
        
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private decimal ilkDeger = 0.0m;
        private decimal ikinciDeger = 0.0m;
        private decimal sonuc = 0.0m;
        private string operatorler = "+";
        public Form1()
        {
            InitializeComponent();
        }


        private void SifirBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "0";
            }
            else
            {
                Tb.Text += "0"; 
            }
        }

        private void NoktaBtn_Click(object sender, EventArgs e)
        {
            if (!Tb.Text.Contains("."))
            {
                Tb.Text += ".";
            }
        }

        private void BirBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "1";
            }
            else
            {
                Tb.Text += "1";
            }
        }

        private void İki_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "2";
            }
            else
            {
                Tb.Text += "2";
            }
        }

        private void UcBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "3";
            }
            else
            {
                Tb.Text += "3";
            }
        }

        private void DortBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "4";
            }
            else
            {
                Tb.Text += "4";
            }
        }

        private void BesBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "5";
            }
            else
            {
                Tb.Text += "5";
            }
        }

        private void AltiBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "6";
            }
            else
            {
                Tb.Text += "6";
            }
        }

        private void YediBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "7";
            }
            else
            {
                Tb.Text += "7";
            }
        }

        private void SekizBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "8";
            }
            else
            {
                Tb.Text += "8";
            }
        }

        private void DokuzBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text == "0")
            {
                Tb.Text = "9";
            }
            else
            {
                Tb.Text += "9";
            }
        }

        private void EksiArtiBtn_Click(object sender, EventArgs e)
        {
            if (Tb.Text.Contains("-"))
            {
                Tb.Text= Tb.Text.Trim('-');
            }
            else
            {
                Tb.Text = "-" + Tb.Text;
            }
        }

        private void EksiBtn_Click(object sender, EventArgs e)
        {
            ilkDeger = decimal.Parse(Tb.Text);
            Tb.Clear();
            operatorler = "-";
        }

        private void ArtiBtn_Click(object sender, EventArgs e)
        {
            ilkDeger = decimal.Parse(Tb.Text);
            Tb.Clear();
            operatorler = "+";
        }

        private void BolBtn_Click(object sender, EventArgs e)
        {
            ilkDeger = decimal.Parse(Tb.Text);
            Tb.Clear();
            operatorler = "/";
        }

        private void CarpBtn_Click(object sender, EventArgs e)
        {
            ilkDeger = decimal.Parse(Tb.Text);
            Tb.Clear();
            operatorler = "*";
        }

        private void YuzdeBtn_Click(object sender, EventArgs e)
        {
            ilkDeger = decimal.Parse(Tb.Text);
            Tb.Clear();
            operatorler = "%";
        }

        private void EsitBtn_Click(object sender, EventArgs e)
        {
            switch (operatorler)
            {
                case "-":
                    ikinciDeger = decimal.Parse(Tb.Text);
                    sonuc = ilkDeger - ikinciDeger;
                    Tb.Text = sonuc.ToString();
                    break;
                case "+":
                    ikinciDeger = decimal.Parse(Tb.Text);
                    sonuc = ilkDeger + ikinciDeger;
                    Tb.Text = sonuc.ToString();
                    break;
                case "/":
                    ikinciDeger = decimal.Parse(Tb.Text);
                    sonuc = ilkDeger / ikinciDeger;
                    Tb.Text = sonuc.ToString();
                    break;
                case "*":
                    ikinciDeger = decimal.Parse(Tb.Text);
                    sonuc = ilkDeger * ikinciDeger;
                    Tb.Text = sonuc.ToString();
                    break;
                case "%":
                    ikinciDeger = decimal.Parse(Tb.Text);
                    sonuc = ilkDeger % ikinciDeger;
                    Tb.Text = sonuc.ToString();
                    break;
            }
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            ilkDeger = 0.0m;
            ikinciDeger = 0.0m;
            Tb.Text = "0";
        }
    }
}
