namespace Sistema_Controle_Financeiro
{
    partial class UC_CadastrarDivida
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.rgvHistCompras = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCompra = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.txtValor = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new Telerik.WinControls.UI.RadTextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdicionarConta = new Telerik.WinControls.UI.RadButton();
            this.btnAlterarConta = new Telerik.WinControls.UI.RadButton();
            this.btnRemoverCompra = new Telerik.WinControls.UI.RadButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompras.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoverCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 80);
            this.panel1.TabIndex = 52;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(151, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 28);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Sistema de Controle de Finanças.";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(191, 176);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(222, 21);
            this.cmbCategoria.TabIndex = 40;
            // 
            // rgvHistCompras
            // 
            this.rgvHistCompras.Location = new System.Drawing.Point(7, 117);
            // 
            // 
            // 
            this.rgvHistCompras.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistCompras.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvHistCompras.Name = "rgvHistCompras";
            this.rgvHistCompras.ShowGroupPanel = false;
            this.rgvHistCompras.Size = new System.Drawing.Size(174, 177);
            this.rgvHistCompras.TabIndex = 51;
            this.rgvHistCompras.ThemeName = "VisualStudio2012Light";
            this.rgvHistCompras.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvHistCompras_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Categorias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Forma de Pagamento";
            // 
            // dtCompra
            // 
            this.dtCompra.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtCompra.Location = new System.Drawing.Point(419, 176);
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(150, 24);
            this.dtCompra.TabIndex = 48;
            this.dtCompra.TabStop = false;
            this.dtCompra.Text = "domingo, 8 de outubro de 2023";
            this.dtCompra.Value = new System.DateTime(2023, 10, 8, 1, 52, 22, 377);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Descrição";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(191, 225);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(222, 21);
            this.cmbFormaPagamento.TabIndex = 42;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(419, 225);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 24);
            this.txtValor.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Valor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(191, 132);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(378, 24);
            this.txtDescricao.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 179);
            this.panel2.TabIndex = 53;
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarConta.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarConta.Location = new System.Drawing.Point(191, 260);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(122, 34);
            this.btnAdicionarConta.TabIndex = 54;
            this.btnAdicionarConta.Text = "Adicionar conta";
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // btnAlterarConta
            // 
            this.btnAlterarConta.BackColor = System.Drawing.Color.Black;
            this.btnAlterarConta.ForeColor = System.Drawing.Color.White;
            this.btnAlterarConta.Location = new System.Drawing.Point(319, 261);
            this.btnAlterarConta.Name = "btnAlterarConta";
            this.btnAlterarConta.Size = new System.Drawing.Size(122, 34);
            this.btnAlterarConta.TabIndex = 55;
            this.btnAlterarConta.Text = "Alterar Conta";
            this.btnAlterarConta.Click += new System.EventHandler(this.btnAlterarConta_Click);
            // 
            // btnRemoverCompra
            // 
            this.btnRemoverCompra.BackColor = System.Drawing.Color.Black;
            this.btnRemoverCompra.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCompra.Location = new System.Drawing.Point(447, 261);
            this.btnRemoverCompra.Name = "btnRemoverCompra";
            this.btnRemoverCompra.Size = new System.Drawing.Size(122, 34);
            this.btnRemoverCompra.TabIndex = 56;
            this.btnRemoverCompra.Text = "Remover Conta";
            this.btnRemoverCompra.Click += new System.EventHandler(this.btnRemoverCompra_Click);
            // 
            // UC_CadastrarDivida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoverCompra);
            this.Controls.Add(this.btnAlterarConta);
            this.Controls.Add(this.btnAdicionarConta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.rgvHistCompras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormaPagamento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.panel2);
            this.Name = "UC_CadastrarDivida";
            this.Size = new System.Drawing.Size(580, 330);
            this.Load += new System.EventHandler(this.UC_CadastrarDivida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompras.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionarConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoverCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private Telerik.WinControls.UI.RadGridView rgvHistCompras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDateTimePicker dtCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private Telerik.WinControls.UI.RadTextBox txtValor;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtDescricao;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadButton btnAdicionarConta;
        private Telerik.WinControls.UI.RadButton btnAlterarConta;
        private Telerik.WinControls.UI.RadButton btnRemoverCompra;
    }
}
