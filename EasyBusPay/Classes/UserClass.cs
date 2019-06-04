using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBusPay.Classes
{
    class UserClass
    {
        public int IdUser { get; set; }
        public string NomeUser { get; set; }
        public string EmailUser { get; set; }
        public string PasswordUser { get; set; }
        public char TipoUser { get; set; }
        public bool Master { get; set; }

        readonly ClassAcessoBD bd = new ClassAcessoBD();

        public DataTable Logar(string email, string password)
        {
            bd.Conectar();
            DataTable DadosLogin = bd.RetDataTable(String.Format("SELECT IdUser, NomeUser, EmailUser, TipoUser, Master FROM tb_user WHERE EmailUser = '{0}' AND PasswordUser = '{1}';", email, password));
            bd.Desconectar();

            if(DadosLogin.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return DadosLogin;
            }
        }

        public bool ChecarMaster(int IdUser)
        {
            bd.Conectar();
            DataTable DadosChecarMaster = bd.RetDataTable(String.Format("SELECT Master FROM tb_user WHERE IdUser = {0};", IdUser));
            bd.Desconectar();

            string master = DadosChecarMaster.Rows[0]["Master"].ToString();

            if (master == "False")
                return false;
            else
                return true;
        } 

    }
}
