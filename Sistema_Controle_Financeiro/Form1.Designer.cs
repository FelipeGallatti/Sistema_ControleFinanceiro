namespace Sistema_Controle_Financeiro
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.btnHistorico = new System.Windows.Forms.ToolStripButton();
            this.btnResumo = new System.Windows.Forms.ToolStripButton();
            this.btnPainel = new System.Windows.Forms.ToolStripButton();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrar,
            this.btnHistorico,
            this.btnResumo,
            this.btnPainel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(153, 330);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSize = false;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(151, 19);
            this.btnCadastrar.Text = "Cadastrar Dívida";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistorico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorico.Image")));
            this.btnHistorico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(151, 19);
            this.btnHistorico.Text = "Historico de Transações";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnResumo
            // 
            this.btnResumo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResumo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnResumo.ForeColor = System.Drawing.Color.White;
            this.btnResumo.Image = ((System.Drawing.Image)(resources.GetObject("btnResumo.Image")));
            this.btnResumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(151, 19);
            this.btnResumo.Text = "Resumo Mensal";
            this.btnResumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumo.Click += new System.EventHandler(this.btnResumo_Click);
            // 
            // btnPainel
            // 
            this.btnPainel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPainel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Image = ((System.Drawing.Image)(resources.GetObject("btnPainel.Image")));
            this.btnPainel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.Size = new System.Drawing.Size(151, 19);
            this.btnPainel.Text = "Painel de Gerenciamento";
            this.btnPainel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(153, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 330);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(733, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPainel;
        private System.Windows.Forms.ToolStripButton btnCadastrar;
        private System.Windows.Forms.ToolStripButton btnHistorico;
        private System.Windows.Forms.ToolStripButton btnResumo;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}

