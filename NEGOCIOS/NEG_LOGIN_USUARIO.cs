using DADOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIOS
{

    public class NEG_LOGIN_USUARIO
    {
        DADOS.CRUD_LOGIN_USUARIO ObjDad_Login = new CRUD_LOGIN_USUARIO();
        public bool VerificaLogin(string usuario, string senha)
        {
            try
            {
                return ObjDad_Login.VerificaLogin(usuario, senha);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
