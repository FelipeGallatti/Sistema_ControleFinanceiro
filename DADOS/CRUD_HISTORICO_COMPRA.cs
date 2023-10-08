using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_HISTORICO_COMPRA
    {
           
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=Sistema_Controle_Financas";
        public IEnumerable<object> ListarHistoricoCompras()
        {
			try
			{
				using (var db = new conexao(connectionString))
				{
                    var lista = (from hist in db.GetTable<TBL_HISTORICO_COMPRAS>()
                                 join catc in db.GetTable<TBL_CATEGORIA_COMPRAS>() on hist.CATEGORIA_COMPRA equals catc.ID_CATEGORIA
                                 join catp in db.GetTable<TBL_CATEGORIA_PAGAMENTO>() on hist.FORMA_PAGAMENTO equals catp.ID_PAGAMENTO
                                 select new
                                 {
                                     hist.ID_COMPRA,
                                     hist.DESCRICAO_COMPRA,
                                     catc.NOME_CATEGORIA,
                                     hist.DATA_COMPRA,
                                     catp.NOME_PAGAMENTO,
                                     hist.VALOR
                                 }).ToList();

                    return lista;
                        
                                 
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
        }


        public List<TBL_TEMP> PreencherCombo()
        {
            try
            {
                using (var db = new conexao(connectionString))
                {

                    var query = (from hist in db.GetTable<TBL_HISTORICO_COMPRAS>()
                                join catc in db.GetTable<TBL_CATEGORIA_COMPRAS>() 
                                on hist.CATEGORIA_COMPRA equals catc.ID_CATEGORIA
                                join catp in db.GetTable<TBL_CATEGORIA_PAGAMENTO>() 
                                on hist.FORMA_PAGAMENTO equals catp.ID_PAGAMENTO
                                select new TBL_TEMP(hist.ID_COMPRA, hist.DESCRICAO_COMPRA, catc.NOME_CATEGORIA, hist.DATA_COMPRA, catp.NOME_PAGAMENTO, hist.VALOR)).ToList();

                    return query;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
