using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosSobrePilhas
{
    public partial class Form1 : Form
    {
        Pilhas pilha = new Pilhas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpilhar_Click(object sender, EventArgs e)
        {
            try
            {
                Employees funcionario = new Employees();

                funcionario.Name = txtNome.Text;
                funcionario.Salary = int.Parse(txtSalario.Text);

                pilha.Push(funcionario);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("ERRO: {0}", error));
            }
        }

        private void btnDesempilhar_Click(object sender, EventArgs e)
        {
            try
            {
                Employees funcionario = pilha.Pop();
                MessageBox.Show(string.Format("Nome: {0}\nSalário: {1}",
                                            funcionario.Name.ToString(),
                                            funcionario.Salary.ToString()));
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("ERRO: {0}", error));
            }
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(pilha.Size().ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("ERRO: {0}", error));
            }
        }

        private void btnTopo_Click(object sender, EventArgs e)
        {
            try
            {
                Employees funcionario = pilha.Peek();
                MessageBox.Show(string.Format("Nome: {0}\nSalário: {1}",
                                            funcionario.Name.ToString(),
                                            funcionario.Salary.ToString()));
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("ERRO: {0}", error));
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                string lista = "";
                Pilhas pAux = new Pilhas();

                while (pilha.Size() > 0)
                {
                    lista += string.Format("Nome: {0}\nSalário: {1}\n\n",
                                            pilha.Peek().Name.ToString(),
                                            pilha.Peek().Salary.ToString());
                    pAux.Push(pilha.Pop());
                }
                while (pAux.Size() > 0)
                {
                    pilha.Push(pAux.Pop());
                }

                MessageBox.Show(lista);
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("ERRO: {0}", error));
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                int salario = 0;
                Pilhas pAux = new Pilhas();

                while(pilha.Size() > 0)
                {
                    salario += pilha.Peek().Salary;
                    pAux.Push(pilha.Pop());
                }
                while (pAux.Size() > 0)
                {
                    pilha.Push(pAux.Pop());
                }

                MessageBox.Show(salario.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("ERRO: {0}", error));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pilhas pAux = new Pilhas();
            while (pilha.Size() > 1)
            {
                pAux.Push(pilha.Pop());
            }

            MessageBox.Show("Base Removida com sucesso!");

            while (pAux.Size() > 0)
                pilha.Push(pAux.Pop());
        }
    }
}
