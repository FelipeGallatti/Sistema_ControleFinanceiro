﻿namespace Sistema_Controle_Financeiro
{
    partial class FormHistoricoCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.rgvHistCompra = new Telerik.WinControls.UI.RadGridView();
            this.lblHistTransacoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra.MasterTemplate)).BeginInit();
            this.rgvHistCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cb);
            this.splitContainer1.Panel2.Controls.Add(this.rgvHistCompra);
            this.splitContainer1.Size = new System.Drawing.Size(401, 291);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(3, 32);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(395, 21);
            this.cb.TabIndex = 0;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // rgvHistCompra
            // 
            this.rgvHistCompra.Controls.Add(this.lblHistTransacoes);
            this.rgvHistCompra.Location = new System.Drawing.Point(0, 70);
            // 
            // 
            // 
            this.rgvHistCompra.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvHistCompra.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvHistCompra.Name = "rgvHistCompra";
            this.rgvHistCompra.Size = new System.Drawing.Size(401, 182);
            this.rgvHistCompra.TabIndex = 0;
            // 
            // lblHistTransacoes
            // 
            this.lblHistTransacoes.AutoSize = true;
            this.lblHistTransacoes.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistTransacoes.Location = new System.Drawing.Point(91, 196);
            this.lblHistTransacoes.Name = "lblHistTransacoes";
            this.lblHistTransacoes.Size = new System.Drawing.Size(229, 28);
            this.lblHistTransacoes.TabIndex = 0;
            this.lblHistTransacoes.Text = "Histórico de Transações";
            // 
            // FormHistoricoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 291);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistoricoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHistoricoCompra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHistoricoCompra_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvHistCompra)).EndInit();
            this.rgvHistCompra.ResumeLayout(false);
            this.rgvHistCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblHistTransacoes;
        private Telerik.WinControls.UI.RadGridView rgvHistCompra;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label1;
    }
}