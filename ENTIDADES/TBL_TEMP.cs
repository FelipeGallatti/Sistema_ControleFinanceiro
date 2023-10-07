using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class TBL_TEMP
    {
        //Trago todos os campos que vou querer apresentar e os que vou usas no combo.ValueMember
        public int ID_COMPRA { get; set; }
        public string DESCRICAO_COMPRA { get; set; }
        public string NOME_CATEGORIA { get; set; }
        public DateTime DATA_COMPRA { get; set; }
        public string NOME_PAGAMENTO { get; set; }
        public decimal VALOR { get; set; }

        // Construtor que aceita os argumentos necessários
        public TBL_TEMP(int idCompra, string descricaoCompra, string nomeCategoria, DateTime dataCompra, string nomePagamento, decimal valor)
        {
            ID_COMPRA = idCompra;
            DESCRICAO_COMPRA = descricaoCompra;
            NOME_CATEGORIA = nomeCategoria;
            DATA_COMPRA = dataCompra;
            NOME_PAGAMENTO = nomePagamento;
            VALOR = valor;
        }

        public override string ToString()
        {
            return $"{DESCRICAO_COMPRA} - {NOME_CATEGORIA} - {NOME_PAGAMENTO}";
        }
    }


}
