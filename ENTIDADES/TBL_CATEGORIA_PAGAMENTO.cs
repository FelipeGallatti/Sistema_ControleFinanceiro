using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_CATEGORIA_PAGAMENTO")] // Especifica o nome da tabela no banco de dados
    public class TBL_CATEGORIA_PAGAMENTO
    {
        [Column(Name = "ID_PAGAMENTO", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_PAGAMENTO { get; set; }

        [Column(Name = "NOME")]
        public string NOME_PAGAMENTO { get; set; }
    }
}
