namespace Sistema_Controle_Financeiro
{
    partial class UC_HistoricoCompra
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
            this.rgvHistCompra = new Telerik.WinControls.UI.RadGridView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgvHistCompra
            // 
            this.rgvHistCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvHistCompra.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgvHistCompra.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistCompra.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvHistCompra.Name = "rgvHistCompra";
            this.rgvHistCompra.Size = new System.Drawing.Size(580, 289);
            this.rgvHistCompra.TabIndex = 1;
            this.rgvHistCompra.ThemeName = "VisualStudio2012Light";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 42);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(580, 289);
            this.radSplitContainer1.SplitterWidth = 8;
            this.radSplitContainer1.TabIndex = 3;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.rgvHistCompra);
            this.splitPanel2.Location = new System.Drawing.Point(0, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(580, 289);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.3763251F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 107);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.label1.Location = new System.Drawing.Point(188, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "HISTÓRICO DE COMPRAS";
            // 
            // UC_HistoricoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "UC_HistoricoCompra";
            this.Size = new System.Drawing.Size(580, 330);
            this.Load += new System.EventHandler(this.UC_HistoricoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvHistCompra;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
