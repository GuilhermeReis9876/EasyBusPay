using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBusPay
{
    public partial class FmrAbrirLinha : Form
    {
        public string NumeroLinha { get; set; }
        public string ValorPassagem { get; set; }
        public FmrAbrirLinha(string numeroLinha, string valorPassagem)
        {
            InitializeComponent();
            NumeroLinha = numeroLinha;
            ValorPassagem = valorPassagem;

            lblLinha.Text = lblLinha.Text + NumeroLinha;
            lblValor.Text = lblValor.Text + "R$ " + ValorPassagem[0] + ValorPassagem[1] + ValorPassagem[2] + ValorPassagem[3];

            try
            {
                int largura = 200;
                int altura = 200;
                picQrCode.Image = GerarQRCode(largura, altura, "Linha: " + NumeroLinha + " - " + "Valor: " + ValorPassagem.Replace(",", "."));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Bitmap GerarQRCode(int width, int height, string text)
        {
            var bw = new ZXing.BarcodeWriter();
            var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
            bw.Options = encOptions;
            bw.Format = ZXing.BarcodeFormat.QR_CODE;
            var resultado = new Bitmap(bw.Write(text));
            return resultado;
        }
    }
}
