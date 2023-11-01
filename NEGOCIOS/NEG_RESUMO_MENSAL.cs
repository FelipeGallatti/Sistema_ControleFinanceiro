using DADOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{
    public class NEG_RESUMO_MENSAL
    {
        DADOS.CRUD_RESUMO_MENSAL ObjDad_Resumo = new CRUD_RESUMO_MENSAL();
        public List<object> ListarHistoricoMensal(int categoria, int formaPagamento)
        {
            try
            {
                return ObjDad_Resumo.ListarHistoricoMensal(categoria, formaPagamento);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
