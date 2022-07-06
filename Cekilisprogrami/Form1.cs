using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cekilisprogrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblCekilisSayi.Text = rtxtAdaylar.Lines.Count().ToString();

            if(rtxtAdaylar.Lines.Count()>0)
            {
                nMiktar.Maximum = rtxtAdaylar.Lines.Count()-1;
            }else
            {
                nMiktar.Maximum = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgList.ColumnCount = 2;

            dtgList.Columns[0].Name = "Sıra No";
            dtgList.Columns[1].Name = "Ad/Soyad";

        }

        private void DtgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int _cekilisSay = 1;
        private void BtnCekilis_Click(object sender, EventArgs e)
        {
            
            int cekilisSayisi = Convert.ToInt32(nMiktar.Text);
            List<string> ListAdaylar = new List<string>(rtxtAdaylar.Text.Split('\n'));

            if(rtxtAdaylar.Text=="")
            {
                MessageBox.Show("Adayları Girmelisiniz");
            } else
            {
                Random uret = new Random();

                for (int i = 0; i<cekilisSayisi; i++)
                {
                  int kazananAday = uret.Next(0, ListAdaylar.Count);
                    dtgList.Rows.Add(_cekilisSay++,ListAdaylar[kazananAday]);
                    ListAdaylar.Remove(ListAdaylar[kazananAday]);
                }
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            rtxtAdaylar.Clear();
            dtgList.Rows.Clear();
            int _cekilisSay = 1;
            nMiktar.Value = 1;
        }

        private void NMiktar_ValueChanged(object sender, EventArgs e)
        {
            nMiktar.Maximum = rtxtAdaylar.Lines.Count();
        }
    }
}
