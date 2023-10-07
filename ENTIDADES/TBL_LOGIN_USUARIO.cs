using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTIDADES
{

    [Table(Name = "dbo.TBL_LOGIN_USUARIO")] // Especifica o nome da tabela no banco de dados
    public class TBL_LOGIN_USUARIO
    {
        [Column(Name = "ID_LOGIN", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_LOGIN { get; set; }

        [Column(Name = "USUARIO")]
        public string USUARIO { get; set; }

        [Column(Name = "SENHA")]
        public string SENHA { get; set; }
    }
}

