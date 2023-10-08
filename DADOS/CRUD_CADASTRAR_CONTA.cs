using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    
    public class CRUD_CADASTRAR_CONTA
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=Sistema_Controle_Financas";


        public List<TBL_HISTORICO_COMPRAS> ListarCompras()
        {
            try
            {
                using (var db = new conexao(connectionString))
                {
                    var lista = (from tbl in db.GetTable<TBL_HISTORICO_COMPRAS>()
                                 select tbl).ToList();

                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public List<TBL_CATEGORIA_COMPRAS> ListarCategorias()
        {
            try
            {
                using (conexao DB = new conexao(connectionString))
                {
                    var lista = (from tbl in DB.GetTable<TBL_CATEGORIA_COMPRAS>()
                                 select tbl).Distinct().ToList();

                    return lista;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<TBL_CATEGORIA_PAGAMENTO> ListarCategoriaPagamento()
        {

            try
            {
                using (var db = new conexao(connectionString))
                {
                    var listar = (from tbl in db.GetTable<TBL_CATEGORIA_PAGAMENTO>()
                                  select tbl).Distinct().ToList();
                    return listar;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString()) ;
            }
        }


        public void IncluirCompra(string descricao, int categoria, DateTime dtCompra, int formaPagamento, decimal valor)
        {
            try
            {
                using (var db = new conexao(connectionString))
                {
                    TBL_HISTORICO_COMPRAS ent = new TBL_HISTORICO_COMPRAS();
                    ent.DESCRICAO_COMPRA = descricao;
                    ent.CATEGORIA_COMPRA = categoria;
                    ent.DATA_COMPRA = dtCompra;
                    ent.FORMA_PAGAMENTO = formaPagamento;
                    ent.VALOR = valor;

                    db.GetTable<TBL_HISTORICO_COMPRAS>().InsertOnSubmit(ent);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
