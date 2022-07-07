using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Views
{
    public class TelaAdmin : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblAdmin;
        Button btnCadastrarProduto;
        Button btnCadastrarQuarto;
        Button btnCadastrarFuncionario;
        Button btnQuartosReservados;
        Button btnCancel;

        public TelaAdmin()
        {
            this.MaximizeBox = false;

            this.btnCadastrarProduto = new Button();
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.Location = new Point(80, 110);
            this.btnCadastrarProduto.Size = new Size(150, 30);
            this.btnCadastrarProduto.Click += new EventHandler(this.handleCadastrarProdutoClick);

            this.btnCadastrarQuarto = new Button();
            this.btnCadastrarQuarto.Text = "Cadastrar Quarto";
            this.btnCadastrarQuarto.Location = new Point(80, 150);
            this.btnCadastrarQuarto.Size = new Size(150, 30);
            this.btnCadastrarQuarto.Click += new EventHandler(this.handleCadastrarQuartoClick);

            this.btnCadastrarFuncionario = new Button();
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.Location = new Point(80, 190);
            this.btnCadastrarFuncionario.Size = new Size(150, 30);
            this.btnCadastrarFuncionario.Click += new EventHandler(this.handleCadastrarFuncionarioClick);

            this.btnQuartosReservados = new Button();
            this.btnQuartosReservados.Text = "Quartos Reservados";
            this.btnQuartosReservados.Location = new Point(80, 230);
            this.btnQuartosReservados.Size = new Size(150, 30);
            this.btnQuartosReservados.Click += new EventHandler(this.handleQuartosReservadosClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Fechar";
            this.btnCancel.Location = new Point(100, 300);
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnCadastrarQuarto);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.btnQuartosReservados);
            this.Controls.Add(this.btnCancel);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 400);
            this.Text = "Menu Admin";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleCadastrarProdutoClick(object sender, EventArgs e)
        {
            CadastrarProduto menu = new CadastrarProduto();
            menu.ShowDialog();
        }

        private void handleCadastrarQuartoClick(object sender, EventArgs e)
        {
            CadastrarQuarto menu = new CadastrarQuarto();
            menu.ShowDialog();
        }

        private void handleCadastrarFuncionarioClick(object sender, EventArgs e)
        {
            CadastrarFuncionario menu = new CadastrarFuncionario();
            menu.ShowDialog();
        }

        private void handleQuartosReservadosClick(object sender, EventArgs e)
        {
            QuartosReservados menu = new QuartosReservados();
            menu.ShowDialog();
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
