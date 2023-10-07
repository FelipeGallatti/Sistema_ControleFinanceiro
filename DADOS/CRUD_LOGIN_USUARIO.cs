using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_LOGIN_USUARIO
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7\SQLEXPRESS;integrated security=SSPI;Initial Catalog=Sistema_Controle_Financas";

        public bool VerificaLogin(string usuario, string senha)
        {
            try
            {

                using (var db = new conexao(connectionString))
                {
                    bool validar = false;
                    ENTIDADES.TBL_LOGIN_USUARIO listaUsuarios = (from tbl in db.GetTable<ENTIDADES.TBL_LOGIN_USUARIO>()
                                                                       where tbl.USUARIO == usuario && tbl.SENHA == senha
                                                                       select tbl).FirstOrDefault();

                    if (listaUsuarios != null)
                    {
                        validar = true;
                    }

                        return validar;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
