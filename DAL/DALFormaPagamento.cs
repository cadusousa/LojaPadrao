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
    public class DALFormaPagamento
    {
        private DALConexao conexao;

        public DALFormaPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFormaPagamento modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into formapagamento(nome, qtdparcelas, diasvenc, status) values (@nome, @qtdparcelas, @diasvenc, @status);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@qtdparcelas", modelo.QtdParcelas);
            cmd.Parameters.AddWithValue("@diasvenc", modelo.DiasVencimento);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            conexao.Conectar();
            modelo.FormaPagamentoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFormaPagamento modelo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update formapagamento set nome=@nome, qtdparcelas=@qtdparcelas, diasvenc=@diasvenc, status=@status where id=@codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@qtdparcelas", modelo.QtdParcelas);
            cmd.Parameters.AddWithValue("@diasvenc", modelo.DiasVencimento);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@codigo", modelo.FormaPagamentoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from formapagamento where id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from formapagamento where nome like '%" + valor + "%' or id like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from formapagamento where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='A'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativo(String valor)
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from formapagamento where (nome like '%" + valor + "%' or (id like '%" + valor + "%')) and status='I'", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, qtdparcelas, diasvenc, status from formapagamento order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, qtdparcelas, diasvenc, status from formapagamento where status='A' order by id", conexao.StringConexao);
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
                MySqlDataAdapter fbDataAdapter = new MySqlDataAdapter("select id, nome, qtdparcelas, diasvenc, status from formapagamento where status='I' order by id", conexao.StringConexao);
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

        public ModeloFormaPagamento CarregaModeloFormaPagamento(int codigo)
        {
            ModeloFormaPagamento modelo = new ModeloFormaPagamento();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from formapagamento where id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FormaPagamentoId = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.QtdParcelas = Convert.ToInt32(registro["qtdparcelas"]);
                modelo.DiasVencimento = Convert.ToInt32(registro["diasvenc"]);
                modelo.Status = Convert.ToChar(registro["status"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
