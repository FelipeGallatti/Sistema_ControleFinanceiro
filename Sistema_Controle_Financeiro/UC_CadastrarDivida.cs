using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Sistema_Controle_Financeiro
{
    public partial class UC_CadastrarDivida : UserControl
    {
        NEGOCIOS.NEG_CADASTRAR_CONTA OBJNEG_CAD = new NEGOCIOS.NEG_CADASTRAR_CONTA();

        int idcompra;

        private void LimparCampos()
        {
            try
            {
                txtDescricao.Text = string.Empty;
                txtValor.Text = string.Empty;
                cmbCategoria.SelectedIndex = -1;
                cmbFormaPagamento.SelectedIndex = -1;
                dtCompra.Value = DateTime.Today;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        private void CarregarGridviewHistorico()
        {
            rgvHistCompras.DataSource = OBJNEG_CAD.ListarCompras();
            rgvHistCompras.Columns[0].IsVisible = false;
            rgvHistCompras.Columns[2].IsVisible = false;
            rgvHistCompras.Columns[3].IsVisible = false;
            rgvHistCompras.Columns[4].IsVisible = false;
            rgvHistCompras.Columns[5].IsVisible = false;

            rgvHistCompras.Columns[1].HeaderText = "Descrição";
            rgvHistCompras.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
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
        public UC_CadastrarDivida()
        {
            InitializeComponent();
        }

        private void UC_CadastrarDivida_Load(object sender, EventArgs e)
        {
            CarregarGridviewHistorico();
            CarregarComboCategoria();
            CarregarComboCategoriaPagamento();


        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text == string.Empty) { MessageBox.Show("Preencha a descrição.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else if (cmbCategoria.SelectedIndex == -1) { MessageBox.Show("Selecione a categoria.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else if (cmbFormaPagamento.SelectedIndex == -1) { MessageBox.Show("Selecione a forma de pagamento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else if (txtValor.Text == string.Empty) { MessageBox.Show("Preencha o valor.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                {

                    OBJNEG_CAD.IncluirCompra(txtDescricao.Text, Convert.ToInt32(cmbCategoria.SelectedValue), dtCompra.Value, Convert.ToInt32(cmbFormaPagamento.SelectedValue), Convert.ToDecimal(txtValor.Text));
                    MessageBox.Show("Conta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarGridviewHistorico();
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }


        private async void btnAlterarConta_Click(object sender, EventArgs e)
        {
            try
            {
                OBJNEG_CAD.AlterarCompra(idcompra, txtDescricao.Text, Convert.ToInt32(cmbCategoria.SelectedValue), dtCompra.Value, Convert.ToInt32(cmbFormaPagamento.SelectedValue), Convert.ToDecimal(txtValor.Text));
                CarregarGridviewHistorico();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void rgvHistCompras_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha o ID_COMPRA selecionado
                txtDescricao.Text = rgvHistCompras.Rows[e.RowIndex].Cells["DESCRICAO_COMPRA"].Value.ToString();
                txtValor.Text = rgvHistCompras.Rows[e.RowIndex].Cells["VALOR"].Value.ToString();
                dtCompra.Value = Convert.ToDateTime(rgvHistCompras.Rows[e.RowIndex].Cells["DATA_COMPRA"].Value);
                cmbCategoria.SelectedValue = rgvHistCompras.Rows[e.RowIndex].Cells["CATEGORIA_COMPRA"].Value;
                cmbFormaPagamento.SelectedValue = rgvHistCompras.Rows[e.RowIndex].Cells["FORMA_PAGAMENTO"].Value;
                idcompra = Convert.ToInt32(rgvHistCompras.Rows[e.RowIndex].Cells["ID_COMPRA"].Value);

                // Atualize a ComboBox selecionando o item correspondente ao selectedID
                //cb.SelectedValue = selectedID;
            }
        }

        private void btnDeletarConta_Click(object sender, EventArgs e)
        {
            try
            {
                OBJNEG_CAD.ExcluirCompra(idcompra);
                CarregarGridviewHistorico();
                LimparCampos();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
