namespace Arquivos
{
    partial class frmArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArquivos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkQuebra = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIrPara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdeLinhas = new System.Windows.Forms.TextBox();
            this.btnLocal = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstArquivos = new System.Windows.Forms.ListBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tslTexto = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkQuebra);
            this.splitContainer1.Panel1.Controls.Add(this.btnFiltrar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtIrPara);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtQtdeLinhas);
            this.splitContainer1.Panel1.Controls.Add(this.btnLocal);
            this.splitContainer1.Panel1.Controls.Add(this.txtLocal);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 30;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 406);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkQuebra
            // 
            this.chkQuebra.AutoSize = true;
            this.chkQuebra.Location = new System.Drawing.Point(719, 9);
            this.chkQuebra.Name = "chkQuebra";
            this.chkQuebra.Size = new System.Drawing.Size(61, 17);
            this.chkQuebra.TabIndex = 22;
            this.chkQuebra.Text = "Quebra";
            this.chkQuebra.UseVisualStyleBackColor = true;
            this.chkQuebra.CheckedChanged += new System.EventHandler(this.chkQuebra_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(650, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(61, 23);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ir Para Linha:";
            // 
            // txtIrPara
            // 
            this.txtIrPara.Location = new System.Drawing.Point(590, 6);
            this.txtIrPara.Name = "txtIrPara";
            this.txtIrPara.Size = new System.Drawing.Size(54, 20);
            this.txtIrPara.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Qtde Linhas:";
            // 
            // txtQtdeLinhas
            // 
            this.txtQtdeLinhas.Location = new System.Drawing.Point(452, 8);
            this.txtQtdeLinhas.Name = "txtQtdeLinhas";
            this.txtQtdeLinhas.Size = new System.Drawing.Size(54, 20);
            this.txtQtdeLinhas.TabIndex = 17;
            this.txtQtdeLinhas.Text = "200";
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(352, 6);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(30, 23);
            this.btnLocal.TabIndex = 16;
            this.btnLocal.Text = "...";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(47, 7);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(302, 20);
            this.txtLocal.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Local:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstArquivos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtTexto);
            this.splitContainer2.Size = new System.Drawing.Size(784, 372);
            this.splitContainer2.SplitterDistance = 349;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstArquivos
            // 
            this.lstArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstArquivos.FormattingEnabled = true;
            this.lstArquivos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstArquivos.IntegralHeight = false;
            this.lstArquivos.Location = new System.Drawing.Point(0, 0);
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.Size = new System.Drawing.Size(349, 372);
            this.lstArquivos.TabIndex = 13;
            this.lstArquivos.SelectedIndexChanged += new System.EventHandler(this.lstArquivos_SelectedIndexChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Location = new System.Drawing.Point(0, 0);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(431, 372);
            this.txtTexto.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prbStatus,
            this.tslTexto});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prbStatus
            // 
            this.prbStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // tslTexto
            // 
            this.tslTexto.Name = "tslTexto";
            this.tslTexto.Size = new System.Drawing.Size(135, 17);
            this.tslTexto.Text = "Bem vindo ao programa";
            // 
            // frmArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 428);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivos";
            this.Load += new System.EventHandler(this.frmArquivos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdeLinhas;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lstArquivos;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIrPara;
        private System.Windows.Forms.ToolStripStatusLabel tslTexto;
        private System.Windows.Forms.ToolStripProgressBar prbStatus;
        private System.Windows.Forms.CheckBox chkQuebra;

    }
}

