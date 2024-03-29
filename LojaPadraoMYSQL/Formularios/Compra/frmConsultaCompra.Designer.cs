﻿namespace LojaPadraoMYSQL.Formularios
{
    partial class frmConsultaCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCompra));
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pFiltro = new System.Windows.Forms.Panel();
            this.cbTipoBuscaData = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbTipoBuscaData = new System.Windows.Forms.CheckBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFaturado = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.btClonar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdt = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btExc = new System.Windows.Forms.Button();
            this.pNomeForm = new System.Windows.Forms.Panel();
            this.lbNomeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pFiltro.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            this.pNomeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.White;
            this.txtPesquisar.Location = new System.Drawing.Point(6, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(451, 24);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Location = new System.Drawing.Point(3, 42);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(829, 385);
            this.dgvDados.TabIndex = 13;
            // 
            // pFiltro
            // 
            this.pFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pFiltro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFiltro.Controls.Add(this.cbTipoBuscaData);
            this.pFiltro.Controls.Add(this.dateTimePicker2);
            this.pFiltro.Controls.Add(this.dateTimePicker1);
            this.pFiltro.Controls.Add(this.label1);
            this.pFiltro.Controls.Add(this.label2);
            this.pFiltro.Controls.Add(this.chbTipoBuscaData);
            this.pFiltro.Controls.Add(this.rbTodos);
            this.pFiltro.Controls.Add(this.rbCancelado);
            this.pFiltro.Controls.Add(this.rbFaturado);
            this.pFiltro.Controls.Add(this.rbAberto);
            this.pFiltro.ForeColor = System.Drawing.Color.White;
            this.pFiltro.Location = new System.Drawing.Point(18, 285);
            this.pFiltro.Name = "pFiltro";
            this.pFiltro.Size = new System.Drawing.Size(309, 152);
            this.pFiltro.TabIndex = 14;
            // 
            // cbTipoBuscaData
            // 
            this.cbTipoBuscaData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoBuscaData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbTipoBuscaData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBuscaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoBuscaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoBuscaData.ForeColor = System.Drawing.Color.White;
            this.cbTipoBuscaData.FormattingEnabled = true;
            this.cbTipoBuscaData.Items.AddRange(new object[] {
            "CADASTRO",
            "EMISSÃO"});
            this.cbTipoBuscaData.Location = new System.Drawing.Point(135, 37);
            this.cbTipoBuscaData.Name = "cbTipoBuscaData";
            this.cbTipoBuscaData.Size = new System.Drawing.Size(150, 28);
            this.cbTipoBuscaData.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(167, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Até";
            // 
            // chbTipoBuscaData
            // 
            this.chbTipoBuscaData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbTipoBuscaData.AutoSize = true;
            this.chbTipoBuscaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTipoBuscaData.ForeColor = System.Drawing.Color.White;
            this.chbTipoBuscaData.Location = new System.Drawing.Point(133, 15);
            this.chbTipoBuscaData.Name = "chbTipoBuscaData";
            this.chbTipoBuscaData.Size = new System.Drawing.Size(136, 24);
            this.chbTipoBuscaData.TabIndex = 30;
            this.chbTipoBuscaData.Text = "Busca por data";
            this.chbTipoBuscaData.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(13, 14);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbCancelado
            // 
            this.rbCancelado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelado.ForeColor = System.Drawing.Color.White;
            this.rbCancelado.Location = new System.Drawing.Point(13, 104);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(103, 24);
            this.rbCancelado.TabIndex = 2;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbFaturado
            // 
            this.rbFaturado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbFaturado.AutoSize = true;
            this.rbFaturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFaturado.ForeColor = System.Drawing.Color.White;
            this.rbFaturado.Location = new System.Drawing.Point(13, 74);
            this.rbFaturado.Name = "rbFaturado";
            this.rbFaturado.Size = new System.Drawing.Size(92, 24);
            this.rbFaturado.TabIndex = 1;
            this.rbFaturado.Text = "Faturado";
            this.rbFaturado.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            this.rbAberto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAberto.AutoSize = true;
            this.rbAberto.Checked = true;
            this.rbAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAberto.ForeColor = System.Drawing.Color.White;
            this.rbAberto.Location = new System.Drawing.Point(13, 44);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(75, 24);
            this.rbAberto.TabIndex = 0;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbBotoes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbBotoes.Controls.Add(this.btClonar);
            this.gbBotoes.Controls.Add(this.btImprimir);
            this.gbBotoes.Controls.Add(this.btAdd);
            this.gbBotoes.Controls.Add(this.btEdt);
            this.gbBotoes.Controls.Add(this.txtPesquisar);
            this.gbBotoes.Controls.Add(this.btSair);
            this.gbBotoes.Controls.Add(this.btExc);
            this.gbBotoes.Location = new System.Drawing.Point(3, 421);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(829, 72);
            this.gbBotoes.TabIndex = 15;
            this.gbBotoes.TabStop = false;
            // 
            // btClonar
            // 
            this.btClonar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btClonar.FlatAppearance.BorderSize = 0;
            this.btClonar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btClonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btClonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btClonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClonar.Image = ((System.Drawing.Image)(resources.GetObject("btClonar.Image")));
            this.btClonar.Location = new System.Drawing.Point(463, 14);
            this.btClonar.Name = "btClonar";
            this.btClonar.Size = new System.Drawing.Size(55, 55);
            this.btClonar.TabIndex = 379;
            this.btClonar.UseVisualStyleBackColor = true;
            this.btClonar.Click += new System.EventHandler(this.btClonar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.Location = new System.Drawing.Point(707, 11);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(55, 55);
            this.btImprimir.TabIndex = 13;
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(524, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(55, 55);
            this.btAdd.TabIndex = 9;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdt
            // 
            this.btEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEdt.FlatAppearance.BorderSize = 0;
            this.btEdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btEdt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btEdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdt.Image = ((System.Drawing.Image)(resources.GetObject("btEdt.Image")));
            this.btEdt.Location = new System.Drawing.Point(585, 11);
            this.btEdt.Name = "btEdt";
            this.btEdt.Size = new System.Drawing.Size(55, 55);
            this.btEdt.TabIndex = 10;
            this.btEdt.UseVisualStyleBackColor = true;
            this.btEdt.Click += new System.EventHandler(this.btEdt_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(768, 11);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(55, 55);
            this.btSair.TabIndex = 12;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExc
            // 
            this.btExc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExc.FlatAppearance.BorderSize = 0;
            this.btExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExc.Image = ((System.Drawing.Image)(resources.GetObject("btExc.Image")));
            this.btExc.Location = new System.Drawing.Point(646, 11);
            this.btExc.Name = "btExc";
            this.btExc.Size = new System.Drawing.Size(55, 55);
            this.btExc.TabIndex = 11;
            this.btExc.UseVisualStyleBackColor = true;
            this.btExc.Click += new System.EventHandler(this.btExc_Click);
            // 
            // pNomeForm
            // 
            this.pNomeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNomeForm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pNomeForm.Controls.Add(this.lbNomeForm);
            this.pNomeForm.Location = new System.Drawing.Point(3, 0);
            this.pNomeForm.Name = "pNomeForm";
            this.pNomeForm.Size = new System.Drawing.Size(829, 36);
            this.pNomeForm.TabIndex = 18;
            // 
            // lbNomeForm
            // 
            this.lbNomeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomeForm.AutoSize = true;
            this.lbNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeForm.ForeColor = System.Drawing.Color.White;
            this.lbNomeForm.Location = new System.Drawing.Point(321, 6);
            this.lbNomeForm.Name = "lbNomeForm";
            this.lbNomeForm.Size = new System.Drawing.Size(199, 24);
            this.lbNomeForm.TabIndex = 0;
            this.lbNomeForm.Text = "CONSULTA COMPRA";
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.pNomeForm);
            this.Controls.Add(this.pFiltro);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.gbBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pFiltro.ResumeLayout(false);
            this.pFiltro.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            this.gbBotoes.PerformLayout();
            this.pNomeForm.ResumeLayout(false);
            this.pNomeForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExc;
        private System.Windows.Forms.Button btEdt;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Panel pFiltro;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbFaturado;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.Button btClonar;
        private System.Windows.Forms.ComboBox cbTipoBuscaData;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbTipoBuscaData;
        private System.Windows.Forms.Panel pNomeForm;
        private System.Windows.Forms.Label lbNomeForm;
    }
}