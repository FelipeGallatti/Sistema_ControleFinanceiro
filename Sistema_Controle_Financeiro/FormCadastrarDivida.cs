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
    public partial class FormCadastrarDivida : Form
    {
        NEGOCIOS.NEG_CADASTRAR_CONTA ObjNeg = new NEGOCIOS.NEG_CADASTRAR_CONTA();
        ENTIDADES.TBL_HISTORICO_COMPRAS ent = new ENTIDADES.TBL_HISTORICO_COMPRAS();
        public FormCadastrarDivida()
        {
            InitializeComponent();
        }
        private void CarregarComboCategoria()
        {

            cmbCategoria.ValueMember = "ID_CATEGORIA";
            cmbCategoria.DisplayMember = "NOME";
            cmbCategoria.SelectedIndex = -1;

        }

        private void CarregarComboCategoriaPagamento()
        {

            cmbFormaPagamento.ValueMember = "ID_PAGAMENTO";
            cmbFormaPagamento.DisplayMember = "NOME";
            cmbFormaPagamento.SelectedIndex = -1;

        }
        private void MontarEntidades()
        {
            try
            {
                ent.DESCRICAO_COMPRA = txtDescricao.Text;
                ent.CATEGORIA_COMPRA = Convert.ToInt32(cmbCategoria.SelectedValue);
                ent.FORMA_PAGAMENTO = Convert.ToInt32(cmbFormaPagamento.SelectedValue);
                ent.DATA_COMPRA = Convert.ToDateTime(dtCompra.Value);
                ent.VALOR = Convert.ToDecimal(txtValor.Text);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text.Equals(string.Empty)) { MessageBox.Show("Preencha a descrição.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (cmbCategoria.Text.Equals(-1)) { MessageBox.Show("Selecione a categoria da compra.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (cmbFormaPagamento.Text.Equals(-1)) { MessageBox.Show("Selecione a forma de pagamento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (txtValor.Text.Equals(string.Empty)) { MessageBox.Show("Informe o valor.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    ent = new ENTIDADES.TBL_HISTORICO_COMPRAS();
                    MontarEntidades();
                    ObjNeg.IncluirCompra(ent);
                    MessageBox.Show("Compra Incluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }


}
