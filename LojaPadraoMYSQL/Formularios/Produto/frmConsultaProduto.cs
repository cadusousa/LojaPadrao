﻿using BLL;
using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaPadraoMYSQL.Formularios
{
    public partial class frmConsultaProduto : Form
    {
        public void AtualizaCabecalhoGridItens()
        {
            dgvDados.Columns[0].HeaderText = "Cod";
            dgvDados.Columns[1].HeaderText = "N/S";
            dgvDados.Columns[2].HeaderText = "Tipo";
            dgvDados.Columns[3].HeaderText = "Cadastro";
            dgvDados.Columns[4].HeaderText = "Produto";
            dgvDados.Columns[5].HeaderText = "Apelido";
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[8].Visible = false;
            dgvDados.Columns[9].Visible = false;
            dgvDados.Columns[10].Visible = false;
            dgvDados.Columns[11].HeaderText = "Custo";
            dgvDados.Columns[12].HeaderText = "%";
            dgvDados.Columns[13].HeaderText = "Avista";
            dgvDados.Columns[14].HeaderText = "%";
            dgvDados.Columns[15].HeaderText = "Prazo";
            dgvDados.Columns[16].HeaderText = "%";
            dgvDados.Columns[17].HeaderText = "Desconto";
            dgvDados.Columns[18].Visible = false;
            dgvDados.Columns[19].Visible = false;
            dgvDados.Columns[20].Visible = false;
            dgvDados.Columns[21].Visible = false;
            dgvDados.Columns[22].Visible = false;
            dgvDados.Columns[23].Visible = false;
            dgvDados.Columns[24].HeaderText = "Sit";
        }
        //---------------------------VARIAVEL--------------------------------------------------------------
        public int id = 0;

        //---------------------------CONSTRUTOR INICIAL----------------------------------------------------
        public frmConsultaProduto()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            this.AtualizaCabecalhoGridItens();
        }

        //---------------------------CONSTRUTOR CARREGA DADOS QNDO FOR ALTERAR-----------------------------
        public frmConsultaProduto(bool selecao)
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            dgvDados.Select();
            this.AtualizaCabecalhoGridItens();
        }

        //---------------------------BOTAO ADICIONAR-------------------------------------------------------
        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            this.Opacity = 0;
            f.ShowDialog();
            this.Opacity = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
            cbStatus.SelectedIndex = 1;
        }

        //---------------------------BOTAO ALTERAR----------------------------------------------------------
        private void btEdt_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);

            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
                ModeloProduto modelo = bll.CarregaModeloProduto(id);
                frmCadastroProduto f = new frmCadastroProduto(modelo);
                this.Opacity = 0;
                f.ShowDialog();
                this.Opacity = 1;
                f.Dispose();
                dgvDados.DataSource = bll.CarregaGridAtivo();
                cbStatus.SelectedIndex = 1;
            }
        }

        //---------------------------BOTAO EXCLUIR----------------------------------------------------------
        private void btExc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult d = MessageBox.Show("Deseja excluir o Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLProduto bll = new BLLProduto(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDados.DataSource = bll.CarregaGridAtivo();
                        cbStatus.SelectedIndex = 1;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo usado em outro local");
            }
        }

        //---------------------------BOTAO SAIR-------------------------------------------------------------
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---------------------------CAMPO PESQUISA---------------------------------------------------------
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            pFiltro.Visible = true;
            if (cbStatus.SelectedIndex == 1)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                dgvDados.DataSource = bll.LocalizarAtivo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                dgvDados.DataSource = bll.LocalizarInativo(txtPesquisa.Text);
            }
            else if (cbStatus.SelectedIndex == 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                dgvDados.DataSource = bll.Localizar(txtPesquisa.Text);
            }
        }

        //---------------------------CARREGA GRID AO CADASTRAR----------------------------------------------
        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.CarregaGridAtivo();
        }

        //---------------------------FILTAR STATUS E CARREGA GRID-------------------------------------------
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 1)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                dgvDados.DataSource = bll.CarregaGridAtivo();
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                dgvDados.DataSource = bll.CarregaGridInativo();
            }
            else
            {
                txtPesquisa.Clear();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                dgvDados.DataSource = bll.CarregaGrid();
            }
        }

        //---------------------------DOUBLE CLICK FUNCIONA QNDO CHAMAMOS DE OUTRO FORMULARIO---------------- 
        //---------------------------PARA PESQUISAR E SELECIONAR--------------------------------------------
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (e.RowIndex >= 0)
            {
                this.id = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //---------------------------USA ENTER COMO TAB-----------------------------------------------------
        //---------------------------USA ESC PARA SAIR------------------------------------------------------
        private void frmConsultaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyValue.Equals(27)) //ESC
            {
                btSair_Click(sender, e);
            }
        }

        //---------------------------USA F1 PARA ADICIONAR---------------------------------------------------
        //---------------------------USA F2 PARA EDITAR------------------------------------------------------
        //---------------------------USA F3 PARA EXCLUIR-----------------------------------------------------
        private void frmConsultaProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btAdd_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btEdt_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btExc_Click(sender, e);
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            pFiltro.Visible = false;
        }
    }
}
