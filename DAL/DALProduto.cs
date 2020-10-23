﻿using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProduto modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into produto(numSerie,tipoProduto,nome,apelido,idUN,idGrupo,idSubGrupo,idFornecedor,idMarca,precoCusto,porcentagemCusto,precoAvista,porcentagemAvista,precoPrazo,porcentagemDesconto,precoDesconto,estoqueAtual,estoqueMax,estoqueMin,controleEstoque,observacao,foto,status)" +
                " values (@numSerie,@tipoProduto,@dataCadastro,@nome,@apelido,@idUN,@idGrupo,@idSubGrupo,@idFornecedor,@idMarca,@precoCusto,@porcentagemCusto,@precoAvista,@porcentagemAvista,@precoPrazo,@porcentagemDesconto,@precoDesconto,@estoqueAtual,@estoqueMax,@estoqueMin,@controleEstoque,@observacao,@foto,@status);";
            cmd.Parameters.AddWithValue("@numSerie", modelo.NumSerie);
            cmd.Parameters.AddWithValue("@tipoProduto", modelo.TipoProduto);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@idUN", modelo.UNID);
            cmd.Parameters.AddWithValue("@idGrupo", modelo.GrupoID);
            cmd.Parameters.AddWithValue("@idSubGrupo", modelo.SubGruooID);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@idMarca", modelo.MarcaID);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
            cmd.Parameters.AddWithValue("@porcentagemDesconto", modelo.PorcentagemDesconto);
            cmd.Parameters.AddWithValue("@precoDesconto", modelo.PrecoDesconto);
            cmd.Parameters.AddWithValue("@estoqueAtual", modelo.EstoqueAtual);
            cmd.Parameters.AddWithValue("@estoqueMax", modelo.EstoqueMax);
            cmd.Parameters.AddWithValue("@estoqueMin", modelo.EstoqueMin);
            cmd.Parameters.AddWithValue("@controleEstoque", modelo.ControlarEstoque);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.Add("@foto", MySqlDbType.LongBlob);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Foto;
            }
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.ProdutoID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update produto set numSerie=@numSerie,tipoProduto=@tipoProduto,nome=@nome,apelido=@apelido,idUN=@idUN,idGrupo=@idGrupo,idSubGrupo=@idSubGrupo,idFornecedor=@idFornecedor,idMarca=@idMarca,precoCusto=@precoCusto,porcentagemCusto=@porcentagemCusto,precoAvista=@precoAvista,porcentagemAvista=@porcentagemAvista,precoPrazo=@precoPrazo,porcentagemDesconto=@porcentagemDesconto,precoDesconto=@precoDesconto,estoqueAtual=@estoqueAtual,estoqueMax=@estoqueMax,estoqueMin=@estoqueMin,controleEstoque=@controleEstoque,observacao=@observacao,foto=@foto,status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@numSerie", modelo.NumSerie);
            cmd.Parameters.AddWithValue("@tipoProduto", modelo.TipoProduto);
            cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@idUN", modelo.UNID);
            cmd.Parameters.AddWithValue("@idGrupo", modelo.GrupoID);
            cmd.Parameters.AddWithValue("@idSubGrupo", modelo.SubGruooID);
            cmd.Parameters.AddWithValue("@idFornecedor", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@idMarca", modelo.MarcaID);
            cmd.Parameters.AddWithValue("@precoCusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@porcentagemCusto", modelo.PorcentagemCusto);
            cmd.Parameters.AddWithValue("@precoAvista", modelo.PrecoAvista);
            cmd.Parameters.AddWithValue("@porcentagemAvista", modelo.PorcentagemAvista);
            cmd.Parameters.AddWithValue("@precoPrazo", modelo.PrecoPrazo);
            cmd.Parameters.AddWithValue("@porcentagemDesconto", modelo.PorcentagemDesconto);
            cmd.Parameters.AddWithValue("@precoDesconto", modelo.PrecoDesconto);
            cmd.Parameters.AddWithValue("@estoqueAtual", modelo.EstoqueAtual);
            cmd.Parameters.AddWithValue("@estoqueMax", modelo.EstoqueMax);
            cmd.Parameters.AddWithValue("@estoqueMin", modelo.EstoqueMin);
            cmd.Parameters.AddWithValue("@controleEstoque", modelo.ControlarEstoque);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.Add("@foto", MySqlDbType.LongBlob);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.Foto;
            }
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.ProdutoID);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from produto where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from produto where nome like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from produto where (nome like '%" + valor + "%' or (id like '%" + valor + "%') and status='A')", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from produto where (nome like '%" + valor + "%' or (id like '%" + valor + "%') and status='I')", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable CarregarGrid()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from produto order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                fbDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable CarregarGridAtivo()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from produto where status='A' order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                fbDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable CarregarGridInativo()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select * from produto where status='I' order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                fbDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProdutoID = Convert.ToInt32(registro["id"]);
                modelo.NumSerie = Convert.ToInt32(registro["numSerie"]);
                modelo.TipoProduto = Convert.ToString(registro["tipoProduto"]);
                modelo.DataCadastro = Convert.ToString(registro["dataCadastro"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Apelido = Convert.ToString(registro["apelido"]);
                modelo.UNID = Convert.ToInt32(registro["idUN"]);
                modelo.GrupoID = Convert.ToInt32(registro["idGrupo"]);
                modelo.SubGruooID = Convert.ToInt32(registro["idSubGrupo"]);
                modelo.FornecedorID = Convert.ToInt32(registro["idFornecedor"]);
                modelo.MarcaID = Convert.ToInt32(registro["idMarca"]);
                modelo.PrecoCusto = Convert.ToDecimal(registro["precoCusto"]);
                modelo.PorcentagemCusto = Convert.ToDecimal(registro["porcentagemCusto"]);
                modelo.PrecoAvista = Convert.ToDecimal(registro["precoAvista"]);
                modelo.PorcentagemAvista = Convert.ToDecimal(registro["porcentagemAvista"]);
                modelo.PrecoPrazo = Convert.ToDecimal(registro["precoPrazo"]);
                modelo.PorcentagemDesconto = Convert.ToDecimal(registro["porcentagemDesconto"]);
                modelo.PrecoDesconto = Convert.ToDecimal(registro["precoDesconto"]);
                modelo.EstoqueAtual = Convert.ToDecimal(registro["estoqueAtual"]);
                modelo.EstoqueMax = Convert.ToDecimal(registro["estoqueMax"]);
                modelo.EstoqueMin = Convert.ToDecimal(registro["estoqueMin"]);
                modelo.ControlarEstoque = Convert.ToChar(registro["controleEstoque"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.Status = Convert.ToChar(registro["status"]);
                try
                {
                    modelo.Foto = (byte[])registro["foto"];
                }
                catch { }
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public DataTable CarregaComboUN()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT id, sigla FROM unidademedida where status = 'A' ORDER BY sigla", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}