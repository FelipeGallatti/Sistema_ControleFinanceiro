using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_RESUMO_MENSAL
    {
        private static string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=Sistema_Controle_Financas";

        public List<TBL_HISTORICO_COMPRAS> ListarHistoricoMensal(int categoria, int formaPagamento)
        {
			try
			{
				using (var db = new conexao(connectionString))
				{
					var lista = (from tbl in db.GetTable<TBL_HISTORICO_COMPRAS>()
								 where tbl.CATEGORIA_COMPRA == categoria &&
								 tbl.FORMA_PAGAMENTO == formaPagamento
								 select tbl).ToList();

					return lista;
				}

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
        }


    }
}
