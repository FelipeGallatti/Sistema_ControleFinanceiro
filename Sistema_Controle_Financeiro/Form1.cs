﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Sistema_Controle_Financeiro
{
    public partial class Form1 : Form
    {
        NEGOCIOS.NEG_CADASTRAR_CONTA ObjNeg = new NEGOCIOS.NEG_CADASTRAR_CONTA();
        ENTIDADES.TBL_HISTORICO_COMPRAS ent = new ENTIDADES.TBL_HISTORICO_COMPRAS();


        public Form1()
        {
            InitializeComponent();
        }





        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UC_CadastrarDivida ucCadastrarDivida = new UC_CadastrarDivida();

            panel1.Controls.Add(ucCadastrarDivida);
            ucCadastrarDivida.Dock = DockStyle.Fill;
            ucCadastrarDivida.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnCadastrar.Size = new Size(151, 50);
            //btnPainel.Size = new Size(151, 50);
            //btnResumo.Size = new Size(151, 50);
            //btnHistorico.Size = new Size(151, 50);

            
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FormHistoricoCompra formHistoricoCompra = new FormHistoricoCompra();
            formHistoricoCompra.MdiParent = this;
            formHistoricoCompra.Show();
        }
    }
}
