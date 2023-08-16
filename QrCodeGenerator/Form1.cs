using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace QrCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            var fileName = rnd.Next();

            string qrLink = txt_link.Text;

            BarcodeWriter qr = new BarcodeWriter();

            qr.Format = BarcodeFormat.QR_CODE;

            //abcdcdfshdgf içermiyorsa sadece space içeriyorsa patlar
            if (!String.IsNullOrEmpty(txt_link.Text))
            {
                qr.Write(qrLink).Save(Application.StartupPath+ "QrCodeGenerator" + fileName + ".png");

                pic_qr.Image = Image.FromFile(Application.StartupPath + "QrCodeGenerator" + fileName + ".png");

                lbl_information.Text = txt_link.Text;

                txt_link.Text = "";
            }
            else
            {
                MessageBox.Show("Alanın doldurulması gereklidir.");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
