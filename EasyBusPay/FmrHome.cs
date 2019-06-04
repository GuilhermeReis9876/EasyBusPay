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

        public int IdUser { get; set; }
        public FmrHome(int idUser = 2)
        {
            InitializeComponent();
            IdUser = idUser;

            bool master = UserClass.ChecarMaster(IdUser);

            if(master)
            {
                btnNovaLinha.Enabled = true;
                btnGerenciarLinhas.Enabled = true;
            }
        }

        private void BtnNovaLinha_Click(object sender, EventArgs e)
        {
            FmrNovaLinha NovaLinha = new FmrNovaLinha();
            NovaLinha.Show();
        }
    }
}
