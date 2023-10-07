using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_HISTORICO_COMPRAS")] // Especifica o nome da tabela no banco de dados
    public class TBL_HISTORICO_COMPRAS
    {
        [Column(Name = "ID_COMPRA", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_COMPRA { get; set; }

        [Column(Name = "DESCRICAO_COMPRA")]
        public string DESCRICAO_COMPRA { get; set; }

        [Column(Name = "CATEGORIA_COMPRA")]
        public int CATEGORIA_COMPRA { get; set; }

        [Column(Name = "DATA_COMPRA")]
        public DateTime DATA_COMPRA { get; set; }

        [Column(Name = "FORMA_PAGAMENTO")]
        public int FORMA_PAGAMENTO { get; set; }

        [Column(Name = "VALOR")]
        public decimal VALOR { get; set; }
    }
}
