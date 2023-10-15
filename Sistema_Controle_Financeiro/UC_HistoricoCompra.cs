using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Financeiro
{
    public partial class UC_HistoricoCompra : UserControl
    {
        NEGOCIOS.NEG_HISTORICO_COMPRA ObjNeg_Hist = new NEGOCIOS.NEG_HISTORICO_COMPRA();
        public UC_HistoricoCompra()
        {
            InitializeComponent();
        }

        private void CarregarGridViewHistorico()
        {
            try
            {
                rgvHistCompra.DataSource = ObjNeg_Hist.ListarHistoricoCompras();
                rgvHistCompra.Columns["ID_COMPRA"].IsVisible = false;
                rgvHistCompra.Columns["DESCRICAO_COMPRA"].HeaderText = "Descrição";
                rgvHistCompra.Columns["NOME_CATEGORIA"].HeaderText = "Categoria";
                rgvHistCompra.Columns["DATA_COMPRA"].HeaderText = "Data";
                rgvHistCompra.Columns["NOME_PAGAMENTO"].HeaderText = "Forma Pagamento";
                rgvHistCompra.Columns["VALOR"].HeaderText = "Valor";

                rgvHistCompra.Columns["DESCRICAO_COMPRA"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvHistCompra.Columns["NOME_CATEGORIA"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvHistCompra.Columns["DATA_COMPRA"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvHistCompra.Columns["NOME_PAGAMENTO"].TextAlignment = ContentAlignment.MiddleCenter;
                rgvHistCompra.Columns["VALOR"].TextAlignment = ContentAlignment.MiddleCenter;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void UC_HistoricoCompra_Load(object sender, EventArgs e)
        {
            CarregarGridViewHistorico();
        }
    }
}
