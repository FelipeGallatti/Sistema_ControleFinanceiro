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

        public void IncluirCompra(TBL_HISTORICO_COMPRAS ent)
        {
            try
            {
              ObjDad.IncluirCompra(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
