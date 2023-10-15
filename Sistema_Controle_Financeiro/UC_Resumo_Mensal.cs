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
    public partial class UC_Resumo_Mensal : UserControl
    {
        NEGOCIOS.NEG_CADASTRAR_CONTA OBJNEG_CAD = new NEGOCIOS.NEG_CADASTRAR_CONTA();
        NEGOCIOS.NEG_RESUMO_MENSAL OBJNEG_RESUMO =  new NEGOCIOS.NEG_RESUMO_MENSAL();

        public UC_Resumo_Mensal()
        {
            InitializeComponent();
        }

        private void CarregarComboCategoria()
        {

            cmbCategoria.ValueMember = "ID_CATEGORIA";
            cmbCategoria.DisplayMember = "NOME_CATEGORIA";
            cmbCategoria.DataSource = OBJNEG_CAD.ListarCategorias();
            cmbCategoria.SelectedIndex = -1;
        }

        private void CarregarComboCategoriaPagamento()
        {

            cmbFormaPagamento.ValueMember = "ID_PAGAMENTO";
            cmbFormaPagamento.DisplayMember = "NOME_PAGAMENTO";
            cmbFormaPagamento.DataSource = OBJNEG_CAD.ListarCategoriaPagamento();
            cmbFormaPagamento.SelectedIndex = -1;
        }

        private void UC_Resumo_Mensal_Load(object sender, EventArgs e)
        {
            CarregarComboCategoria();
            CarregarComboCategoriaPagamento();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            radGridView2.DataSource = OBJNEG_RESUMO.ListarHistoricoMensal(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbFormaPagamento.SelectedValue));
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            radGridView2.DataSource = OBJNEG_RESUMO.ListarHistoricoMensal(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbFormaPagamento.SelectedValue));

        }
    }
}
