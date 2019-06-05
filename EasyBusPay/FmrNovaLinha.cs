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
    public partial class FmrNovaLinha : Form
    {
        public FmrNovaLinha()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (!txtNumLinha.Text.Equals("") && !txtPontoFinal.Text.Equals("") && !txtPontoInicio.Text.Equals("") && !txtValorPassagem.Text.Equals(""))
            {
                Classes.LinhaClass LinhaClass = new Classes.LinhaClass();
                LinhaClass.NumeroLinha = txtNumLinha.Text;
                LinhaClass.PontoInicio = txtPontoInicio.Text;
                LinhaClass.PontoFinal = txtPontoFinal.Text;
                string valorPassagem = txtValorPassagem.Text;
                valorPassagem = valorPassagem.Replace("R$", "");
                valorPassagem = valorPassagem.Replace(",", ".");
                LinhaClass.ValorPassagem = valorPassagem;

                string returnQuery = LinhaClass.CadastrarLinha();

                if (returnQuery == "Linha já cadastrada")
                {
                    MessageBox.Show("Já existe uma linha com esse número!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (returnQuery == "Erro")
                {
                    MessageBox.Show("Não foi possível inserir, contate um administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (returnQuery == "Sucesso")
                {
                    MessageBox.Show("Linha Cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
