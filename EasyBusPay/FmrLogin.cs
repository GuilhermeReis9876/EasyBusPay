using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBusPay
{
    public partial class FmrLogin : Form
    {
        public FmrLogin()
        {
            InitializeComponent();

        }

        Classes.UserClass UserClass = new Classes.UserClass();
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals("") || txtEmail.Text.Equals("Digite seu email") || txtPassword.Text.Equals("") || txtPassword.Text.Equals("Digite sua senha"))
            {
                MessageBox.Show("Preencha todos os campos","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = UserClass.Logar(txtEmail.Text, txtPassword.Text);

                if (dt != null)
                {
                    string IdUser = dt.Rows[0]["IdUser"].ToString();
                    FmrHome home = new FmrHome(Convert.ToInt32(IdUser));
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
    }
}
