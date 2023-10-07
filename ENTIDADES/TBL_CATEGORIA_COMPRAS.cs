using System;
using System.Data.Linq.Mapping;
using System.Threading;
using System.Xml.Linq;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_CATEGORIA_COMPRAS")] // Especifica o nome da tabela no banco de dados
    public class TBL_CATEGORIA_COMPRAS
    {
        [Column(Name = "ID_CATEGORIA", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_CATEGORIA { get; set; }

        [Column(Name = "NOME")]
        public string NOME_CATEGORIA { get; set; }
    }
}

