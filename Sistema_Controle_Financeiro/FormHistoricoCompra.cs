using ENTIDADES;
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
    public partial class FormHistoricoCompra : Form
    {
        NEGOCIOS.NEG_HISTORICO_COMPRA ObjNeg_HistCompra = new NEGOCIOS.NEG_HISTORICO_COMPRA();
        public FormHistoricoCompra()
        {
            InitializeComponent();
        }

        private void FormHistoricoCompra_Load(object sender, EventArgs e)
        {
            rgvHistCompra.DataSource = ObjNeg_HistCompra.ListarHistoricoCompras();
            int id = 1;
            cb.DisplayMember =  "TBL_TEMP";
            cb.ValueMember = "ID_COMPRA";
            cb.DataSource = ObjNeg_HistCompra.PreencherCombo(id);
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = cb.SelectedValue.ToString();
        }
    }
}
