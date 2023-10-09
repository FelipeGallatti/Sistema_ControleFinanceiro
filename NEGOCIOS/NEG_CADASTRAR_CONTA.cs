using DADOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_CADASTRAR_CONTA
    {
        DADOS.CRUD_CADASTRAR_CONTA ObjDad = new CRUD_CADASTRAR_CONTA();

        public List<TBL_HISTORICO_COMPRAS> ListarCompras()
        {
            try
            {
                return ObjDad.ListarCompras();
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
                return ObjDad.ListarCategorias();
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
                return ObjDad.ListarCategoriaPagamento();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void IncluirCompra(string descricao, int categoria, DateTime dtCompra, int formaPagamento, decimal valor)
        {
            try
            {
                ObjDad.IncluirCompra(descricao, categoria, dtCompra, formaPagamento, valor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void AlterarCompra(int idcompra, string descricao, int categoria, DateTime dtCompra, int formaPagamento, decimal valor)
        {
            try
            {
                 ObjDad.AlterarCompra(idcompra, descricao, categoria, dtCompra, formaPagamento, valor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public void ExcluirCompra(int idcompra)
        {
            try
            {
                 ObjDad.ExcluirCompra(idcompra);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
