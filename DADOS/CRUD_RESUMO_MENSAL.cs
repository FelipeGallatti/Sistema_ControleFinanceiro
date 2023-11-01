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

        public List<object> ListarHistoricoMensal(int categoria, int formaPagamento)
        {
			try
			{
				using (var db = new conexao(connectionString))
				{
					var lista = (from tbl in db.GetTable<TBL_HISTORICO_COMPRAS>()
								 join cp in db.GetTable<TBL_CATEGORIA_PAGAMENTO>()
								 on tbl.FORMA_PAGAMENTO equals cp.ID_PAGAMENTO
								 join cc in db.GetTable<TBL_CATEGORIA_COMPRAS>()
								 on tbl.CATEGORIA_COMPRA equals cc.ID_CATEGORIA
								 where tbl.CATEGORIA_COMPRA == categoria &&
								 tbl.FORMA_PAGAMENTO == formaPagamento
								 select new
								 {
									 DESCRICAO = tbl.DESCRICAO_COMPRA,
									 FORMA_PAGAMENTO = cp.NOME_PAGAMENTO,
									 CATEGORIA_COMPRA = cc.NOME_CATEGORIA,
									 VALOR = tbl.VALOR,
									 DATA = tbl.DATA_COMPRA
								 });


					return lista.ToList<object>();
				}

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
        }


    }
}
