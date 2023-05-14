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
            Random rnd=new Random();

            var fileName = rnd.Next();

            string qrLink = txt_link.Text;

            BarcodeWriter qr = new BarcodeWriter();

            qr.Format = BarcodeFormat.QR_CODE;

            qr.Write(qrLink).Save(@"C:\Users\mako\Desktop\Qr\" + fileName + ".png");

            pic_qr.Image = Image.FromFile(@"C:\Users\mako\Desktop\Qr\" + fileName + ".png");
        }
    }
}
