using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteConectarDataGridViewCsharp
{
    public partial class Form1 : Form
    {
        string con = @"Data Source = c:\dados\financeiro.db; Version=3";
        bool novo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

      
        private void dataGridView1_Enter(object sender, EventArgs e)
        {
           
        }

     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetTitulos();
            if (dataGridView1.Rows.Count == 0)
            {
                alterarToolStripButton.Enabled = false;
                imprimirToolStripButton.Enabled = false;
                excluirToolStripButton.Enabled = false;
                baixarToolStripButton.Enabled = false;
            }
        }

 
        private void TravarControles(bool travado)
        {
            //form de edição
            mskVencimento.Enabled = !travado;
            txtValor.Enabled = !travado;
            txtIdCliente.Enabled = !travado;

            //barra de ferramentas
            novoToolStripButton.Enabled = travado;
            alterarToolStripButton.Enabled = travado;
            salvarToolStripButton.Enabled = !travado;
            excluirToolStripButton.Enabled = travado;
            baixarToolStripButton.Enabled = travado;

            //grade 
            btnBuscar.Enabled = travado;
            txtProcura.Enabled = travado;
            dataGridView1.Enabled = travado;
        }

        private void CriarCabecalhoGrade()
        {
            dataGridView1.Columns["fatura"].HeaderText = "Fatura";
            dataGridView1.Columns["fatura"].Width = 60;
            dataGridView1.Columns["fatura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["fatura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["parcela"].HeaderText = "Parc.";
            dataGridView1.Columns["parcela"].Width = 40;
            dataGridView1.Columns["parcela"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["parcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["vencimento"].HeaderText = "Vencimento";
            dataGridView1.Columns["vencimento"].Width = 75;
            dataGridView1.Columns["vencimento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["vencimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["valor"].HeaderText = "Valor";
            dataGridView1.Columns["valor"].Width = 60;
            dataGridView1.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["idCliente"].Visible = false;

            dataGridView1.Columns["nome"].HeaderText = "Nome do cliente";
            dataGridView1.Columns["nome"].Width = 170;

            dataGridView1.Columns["dataBaixa"].HeaderText = "Baixado";
            dataGridView1.Columns["dataBaixa"].Width = 75;
            dataGridView1.Columns["dataBaixa"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["dataBaixa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private bool GetTitulo(int fatura, int parcela)
        {
            var existeTitulo = false;
            using (SQLiteConnection cn = new SQLiteConnection(con))
            {
                cn.Open();

                var sql = "SELECT r.fatura, r.parcela, r.vencimento, r.valor, c.nome, r.idCliente, r.dataBaixa FROM ContasReceber r INNER JOIN Clientes c ON r.idCliente = r.idCliente WHERE fatura = " + fatura + " AND parcela = " + parcela;

                using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                txtFatura.Text = dr["fatura"].ToString();
                                txtParcela.Text = dr["parcela"].ToString();
                                mskVencimento.Text = dr["vencimento"].ToString();
                                txtValor.Text = Convert.ToDecimal(dr["valor"]).ToString("N2");
                                txtIdCliente.Text = dr["idCliente"].ToString();
                                lblNome.Text = dr["nome"].ToString();
                                lblDataBaixa.Text = dr["dataBaixa"].ToString();
                                existeTitulo = true;
                            }
                        }
                    }
                }
                return existeTitulo;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var fatura = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["fatura"].Value);
            var parcela = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["parcela"].Value);

            GetTitulo(fatura, parcela);

            if (dataGridView1.Rows.Count > 0)
            {
                alterarToolStripButton.Enabled = true;
                imprimirToolStripButton.Enabled = true;
                excluirToolStripButton.Enabled = true;
                if (lblDataBaixa.Text == "")
                    baixarToolStripButton.Enabled = true;
                else
                    baixarToolStripButton.Enabled = false;
            }
        }

        private void alterarToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

     

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
 
        }

 
        private void btnLimpar_Click(object sender, EventArgs e)
        {
           
        }

        private void baixarToolStripButton_Click(object sender, EventArgs e)
        {
           
           
        }


        private void LimparForm()
        {
            txtFatura.Text = "";
            txtParcela.Text = "";
            mskVencimento.Text = "";
            txtValor.Text = "";
            txtIdCliente.Text = "";
            lblNome.Text = "";
            lblDataBaixa.Text = "";
        }

        private void excluirToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void txtParcela_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtParcela_Leave(object sender, EventArgs e)
        {
 
        }

    }
}
