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
    public class CadastrarProduto : Form
    {

        Label lblTitulo;
        Label lblDescricao;
        Label lblValor;

        TextBox txtDescricao;
        TextBox txtValor;

        Button btCadastrarProduto;
        Button btVoltar;


        public CadastrarProduto()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            //LABEL
            this.lblTitulo = new Label();
            this.lblTitulo.Text = "Cadastro de Produto";
            this.lblTitulo.Location = new Point(190, 50);
            this.lblTitulo.Size = new Size(200, 30);
            this.lblTitulo.ForeColor = Color.Green;
            this.lblTitulo.Font = new Font("Roboto", 15);

            //PRIMEIRA FILEIRA

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(190, 120);
            this.lblDescricao.Size = new Size(100, 30);
            this.lblDescricao.ForeColor = Color.Black;
            this.lblDescricao.Font = new Font("Roboto", 15);


            //SEGUNDA FILEIRA

            this.lblValor = new Label();
            this.lblValor.Text = "Valor";
            this.lblValor.Location = new Point(190, 200);
            this.lblValor.Size = new Size(100, 30);
            this.lblValor.ForeColor = Color.Black;
            this.lblValor.Font = new Font("Roboto", 15);

            //INPUT

            //PRIMEIRA FILEIRA
            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(190, 150);
            this.txtDescricao.Size = new Size(220, 30);


            //SEGUNDA FILEIRA
            this.txtValor = new TextBox();
            this.txtValor.Location = new Point(190, 230);
            this.txtValor.Size = new Size(220, 30);


            //BOTÕES
            this.btCadastrarProduto = new Button();
            this.btCadastrarProduto.Text = "Cadastrar Produto";
            this.btCadastrarProduto.Location = new Point(175, 300);
            this.btCadastrarProduto.Size = new Size(120, 30);
            this.btCadastrarProduto.Click += new EventHandler(this.handleConfirmClickInserirProduto);

            this.btVoltar = new Button();
            this.btVoltar.Text = "Voltar";
            this.btVoltar.Location = new Point(305, 300);
            this.btVoltar.Size = new Size(120, 30);
            this.btVoltar.Click += new EventHandler(this.handleVoltarClick);

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblValor);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);

            this.Controls.Add(this.btCadastrarProduto);
            this.Controls.Add(this.btVoltar);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);

        }

        private void handleVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void handleConfirmClickInserirProduto(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Confirma a operação?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Controllers.ProdutoController.IncluirProduto(this.txtDescricao.Text, float.Parse(this.txtValor.Text));
                    MessageBox.Show("Usuário cadastrado com sucesso.");
                    this.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}
