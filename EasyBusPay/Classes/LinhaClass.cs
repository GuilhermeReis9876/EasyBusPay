using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBusPay.Classes
{
    class LinhaClass
    {
        public int IdLinha { get; set; }
        public string NumeroLinha { get; set; }
        public string PontoInicio { get; set; }
        public string PontoFinal { get; set; }
        public string ValorPassagem { get; set; }
        public bool LinhaAtiva { get; set; }
        public bool Catraca { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public DataTable RetornarTodasLinhas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_linha;"));
            bd.Desconectar();

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }

        public DataTable RetornarLinhasAtivas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT IdLinha AS 'Código da linha', NumeroLinha AS 'Número da Linha', PontoInicio AS 'Ponto Inicial', PontoFinal AS 'Ponto Final', ValorPassagem AS 'Valor da Passagem', LinhaAtiva AS 'Status Linha' FROM tb_linha WHERE LinhaAtiva = 1;"));
            bd.Desconectar();

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }

        public string CadastrarLinha()
        {
            try
            {
                
                if(VerificarLinhaDuplicada(NumeroLinha))
                {
                    return "Linha já cadastrada";
                }
                else
                {
                    bd.Conectar();
                    bd.ExecutarComandosSql(String.Format("INSERT INTO tb_linha (NumeroLinha, PontoInicio, PontoFinal, ValorPassagem) VALUES ('{0}', '{1}', '{2}', '{3}');", NumeroLinha, PontoInicio, PontoFinal, ValorPassagem));
                    bd.Desconectar();

                    return "Sucesso";
                }
            }
            catch
            {
                return "Erro";
            }
        }

        private bool VerificarLinhaDuplicada(string NumeroLinha)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM tb_linha WHERE NumeroLinha = '{0}';", NumeroLinha));
            bd.Desconectar();

            return dt.Rows.Count != 0;
        }
    }
}
