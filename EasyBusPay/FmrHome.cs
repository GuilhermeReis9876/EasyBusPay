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
    public partial class FmrHome : Form
    {
        Classes.UserClass UserClass = new Classes.UserClass();
        Classes.LinhaClass LinhaClass = new Classes.LinhaClass();

        public int IdUser { get; set; }
        public FmrHome(int idUser = 1)
        {
            InitializeComponent();
            IdUser = idUser;

            bool master = UserClass.ChecarMaster(IdUser);

            if (master)
            {
                btnNovaLinha.Enabled = true;
                btnGerenciarLinhas.Enabled = true;
            }

            dgvLinhasAtivas.DataSource = LinhaClass.RetornarLinhasAtivas();

            int numeroLinhasAtivas = Convert.ToInt32(dgvLinhasAtivas.Rows.Count) - 1;
            lblSubTitle.Text = lblSubTitle.Text + " " + numeroLinhasAtivas;
        }

        private void BtnNovaLinha_Click(object sender, EventArgs e)
        {
            FmrNovaLinha NovaLinha = new FmrNovaLinha();
            NovaLinha.Show();
        }

        private void BtnAbrirRota_Click(object sender, EventArgs e)
        {
            if((dgvLinhasAtivas.Rows.Count - 1) != 0)
            {
                if (dgvLinhasAtivas.CurrentRow.Cells[0].Value.ToString() != null)
                {
                    FmrAbrirLinha AbrirLinha = new FmrAbrirLinha(dgvLinhasAtivas.CurrentRow.Cells[1].Value.ToString(), dgvLinhasAtivas.CurrentRow.Cells[4].Value.ToString());
                    AbrirLinha.Show();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha ativa!", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
