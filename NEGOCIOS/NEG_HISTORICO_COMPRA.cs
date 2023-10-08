using DADOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_HISTORICO_COMPRA
    {
        DADOS.CRUD_HISTORICO_COMPRA ObjDad_HistCompras = new CRUD_HISTORICO_COMPRA();
        public IEnumerable<object> ListarHistoricoCompras()
        {
            try
            {
                return ObjDad_HistCompras.ListarHistoricoCompras();
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
               return ObjDad_HistCompras.PreencherCombo();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
