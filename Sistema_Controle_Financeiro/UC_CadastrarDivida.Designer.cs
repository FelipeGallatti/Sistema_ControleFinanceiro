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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.rgvHistCompras = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeletarConta = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterarConta = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCompra = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarConta = new Telerik.WinControls.UI.RadButton();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.txtValor = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new Telerik.WinControls.UI.RadTextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompras.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletarConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
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
            this.lblTitulo.Location = new System.Drawing.Point(145, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 28);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Sistema de Controle de Finanças.";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(191, 171);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(222, 21);
            this.cmbCategoria.TabIndex = 40;
            // 
            // rgvHistCompras
            // 
            this.rgvHistCompras.Location = new System.Drawing.Point(7, 127);
            // 
            // 
            // 
            this.rgvHistCompras.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistCompras.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvHistCompras.Name = "rgvHistCompras";
            this.rgvHistCompras.ShowGroupPanel = false;
            this.rgvHistCompras.Size = new System.Drawing.Size(174, 177);
            this.rgvHistCompras.TabIndex = 51;
            this.rgvHistCompras.ThemeName = "VisualStudio2012Light";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Categorias";
            // 
            // btnDeletarConta
            // 
            this.btnDeletarConta.BackColor = System.Drawing.Color.Black;
            this.btnDeletarConta.ForeColor = System.Drawing.Color.White;
            this.btnDeletarConta.Location = new System.Drawing.Point(447, 256);
            this.btnDeletarConta.Name = "btnDeletarConta";
            this.btnDeletarConta.Size = new System.Drawing.Size(122, 48);
            this.btnDeletarConta.TabIndex = 50;
            this.btnDeletarConta.Text = "Remover Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data Compra";
            // 
            // btnAlterarConta
            // 
            this.btnAlterarConta.BackColor = System.Drawing.Color.Black;
            this.btnAlterarConta.ForeColor = System.Drawing.Color.White;
            this.btnAlterarConta.Location = new System.Drawing.Point(319, 256);
            this.btnAlterarConta.Name = "btnAlterarConta";
            this.btnAlterarConta.Size = new System.Drawing.Size(122, 48);
            this.btnAlterarConta.TabIndex = 49;
            this.btnAlterarConta.Text = "Alterar Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Forma de Pagamento";
            // 
            // dtCompra
            // 
            this.dtCompra.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtCompra.Location = new System.Drawing.Point(419, 171);
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
            this.label1.Location = new System.Drawing.Point(188, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Descrição";
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarConta.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarConta.Location = new System.Drawing.Point(191, 256);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(122, 48);
            this.btnCadastrarConta.TabIndex = 47;
            this.btnCadastrarConta.Text = "Adicionar Conta";
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(191, 220);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(222, 21);
            this.cmbFormaPagamento.TabIndex = 42;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(419, 220);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 24);
            this.txtValor.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Valor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(191, 127);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(378, 24);
            this.txtDescricao.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(5, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 181);
            this.panel2.TabIndex = 53;
            // 
            // UC_CadastrarDivida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.rgvHistCompras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletarConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterarConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarConta);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletarConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private Telerik.WinControls.UI.RadGridView rgvHistCompras;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnDeletarConta;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadButton btnAlterarConta;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDateTimePicker dtCompra;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnCadastrarConta;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private Telerik.WinControls.UI.RadTextBox txtValor;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadTextBox txtDescricao;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.Panel panel2;
    }
}
