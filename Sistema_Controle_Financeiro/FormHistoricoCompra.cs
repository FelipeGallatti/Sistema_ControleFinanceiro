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
using System.Xml.Linq;
using Telerik.WinControls.UI;

namespace Sistema_Controle_Financeiro
{
    public partial class FormHistoricoCompra : Form
    {
        NEGOCIOS.NEG_HISTORICO_COMPRA ObjNeg_HistCompra = new NEGOCIOS.NEG_HISTORICO_COMPRA();
        private TBL_TEMP selectedItem;  // Variável para armazenar o item selecionado do DataGridView
        private int selectedID;

        public FormHistoricoCompra()
        {
            InitializeComponent();
        }

        //private void PreenchercamposDgv(GridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        // Obtenha a linha selecionada
        //        var row = rgvHistCompra.Rows[e.RowIndex];

        //        //txtNomeTarefa.Text = row.Cells["Nome_Tarefa"].Value.ToString();
        //        cb.ValueMember = row.Cells["ID_COMPRA"].Value.ToString();
        //        cb.DisplayMember = "TBL_TEMP";

        //    }
        //}

        private void FormHistoricoCompra_Load(object sender, EventArgs e)
        {
            rgvHistCompra.DataSource = ObjNeg_HistCompra.ListarHistoricoCompras();
        }



        private void rgvHistCompra_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha o ID_COMPRA selecionado
                selectedID = Convert.ToInt32(rgvHistCompra.Rows[e.RowIndex].Cells["ID_COMPRA"].Value);

                // Atualize a ComboBox selecionando o item correspondente ao selectedID
                //cb.SelectedValue = selectedID;
            }
        }
    }
}
