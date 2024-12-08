
namespace SqliteConectarDataGridViewCsharp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.baixarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtProcura = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.txtFatura = new System.Windows.Forms.TextBox();
            this.lblDataBaixa = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(551, 260);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.alterarToolStripButton,
            this.salvarToolStripButton,
            this.baixarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.excluirToolStripButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(224, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "ToolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "&Novo";
            this.novoToolStripButton.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // alterarToolStripButton
            // 
            this.alterarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alterarToolStripButton.Enabled = false;
            this.alterarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alterarToolStripButton.Image")));
            this.alterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterarToolStripButton.Name = "alterarToolStripButton";
            this.alterarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.alterarToolStripButton.Text = "&Alterar";
            this.alterarToolStripButton.Click += new System.EventHandler(this.alterarToolStripButton_Click);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Enabled = false;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // baixarToolStripButton
            // 
            this.baixarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.baixarToolStripButton.Enabled = false;
            this.baixarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("baixarToolStripButton.Image")));
            this.baixarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baixarToolStripButton.Name = "baixarToolStripButton";
            this.baixarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.baixarToolStripButton.Text = "&Baixar";
            this.baixarToolStripButton.Click += new System.EventHandler(this.baixarToolStripButton_Click);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Enabled = false;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // excluirToolStripButton
            // 
            this.excluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excluirToolStripButton.Enabled = false;
            this.excluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripButton.Image")));
            this.excluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirToolStripButton.Name = "excluirToolStripButton";
            this.excluirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.excluirToolStripButton.Text = "&Excluir";
            this.excluirToolStripButton.Click += new System.EventHandler(this.excluirToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(508, 24);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 53);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(422, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 53);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtProcura
            // 
            this.txtProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcura.Location = new System.Drawing.Point(79, 21);
            this.txtProcura.MaxLength = 12;
            this.txtProcura.Name = "txtProcura";
            this.txtProcura.Size = new System.Drawing.Size(327, 21);
            this.txtProcura.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtProcura);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(280, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(28, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(136, 243);
            this.txtIdCliente.MaxLength = 7;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(82, 21);
            this.txtIdCliente.TabIndex = 4;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcela
            // 
            this.txtParcela.Enabled = false;
            this.txtParcela.Location = new System.Drawing.Point(136, 122);
            this.txtParcela.MaxLength = 2;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(82, 21);
            this.txtParcela.TabIndex = 1;
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParcela.Enter += new System.EventHandler(this.txtParcela_Enter);
            this.txtParcela.Leave += new System.EventHandler(this.txtParcela_Leave);
            // 
            // txtFatura
            // 
            this.txtFatura.Enabled = false;
            this.txtFatura.Location = new System.Drawing.Point(136, 84);
            this.txtFatura.MaxLength = 7;
            this.txtFatura.Name = "txtFatura";
            this.txtFatura.Size = new System.Drawing.Size(82, 21);
            this.txtFatura.TabIndex = 0;
            this.txtFatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataBaixa
            // 
            this.lblDataBaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDataBaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataBaixa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataBaixa.Location = new System.Drawing.Point(136, 313);
            this.lblDataBaixa.Name = "lblDataBaixa";
            this.lblDataBaixa.Size = new System.Drawing.Size(82, 22);
            this.lblDataBaixa.TabIndex = 11;
            this.lblDataBaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(136, 201);
            this.txtValor.MaxLength = 12;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(82, 21);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.txtParcela);
            this.groupBox1.Controls.Add(this.txtFatura);
            this.groupBox1.Controls.Add(this.lblDataBaixa);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.mskVencimento);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mskVencimento
            // 
            this.mskVencimento.Enabled = false;
            this.mskVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskVencimento.Location = new System.Drawing.Point(136, 162);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.Size = new System.Drawing.Size(82, 21);
            this.mskVencimento.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(14, 270);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(204, 22);
            this.lblNome.TabIndex = 8;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baixa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vencimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parcela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(897, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLite 3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton novoToolStripButton;
        internal System.Windows.Forms.ToolStripButton alterarToolStripButton;
        internal System.Windows.Forms.ToolStripButton salvarToolStripButton;
        internal System.Windows.Forms.ToolStripButton baixarToolStripButton;
        internal System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        internal System.Windows.Forms.ToolStripButton excluirToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.TextBox txtProcura;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtIdCliente;
        internal System.Windows.Forms.TextBox txtParcela;
        internal System.Windows.Forms.TextBox txtFatura;
        internal System.Windows.Forms.Label lblDataBaixa;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.MaskedTextBox mskVencimento;
        internal System.Windows.Forms.Label lblNome;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}

