//Atividade Cibergestion: Construir um Cadastro de Funcionários usando C#
//Autor(a): Caroline Miranda
//Inicialização: 28/07/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastroColaboradores
{
    public partial class Form1 : Form
    {
        List<Funcionarios> funcionarios; //criação da lista genérica (Dinâmica)

        public Form1()
        {
            InitializeComponent();//inicializar a lista

            funcionarios = new List<Funcionarios>();

            comboTipo.Items.Add("Selecione o Tipo de Telefone");//opções colocadas no comboBox de Tipo.
            comboTipo.Items.Add("Celular");
            comboTipo.Items.Add("Residencial");
            comboTipo.Items.Add("Trabalho");
            comboTipo.Items.Add("WhatsApp");

            comboTipo.SelectedIndex = 0; //definindo a opção que aparecerá na caixinha de seleção (estético).

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1; // novo cadastro

            //Aqui estou percorrendo a lista de Funcionários para verificar se a pessoa já existe e se não existe consigo fazer um novo cadastro.
            foreach (Funcionarios funcionario in funcionarios)// verifica se a lista contém intens
            {
                
               if (funcionario.Telefone == maskedTelefone.Text) // verifica se o Telefone já está cadastrado, assim bloqueando o cadastro do mesmo número.
               {
                 index = funcionarios.IndexOf(funcionario); //atribui o cadastro de Nome dentro da lista funcionarios.
               }

                
            }

              if (txtNome.Text == "") // está dizendo que o campo nome não foi preenchido.
              {
                 MessageBox.Show("Preencha o campo nome.");
                 txtNome.Focus();
                 return;
              }

              if (maskedTelefone.Text == "(  )     -") // está dizendo que o campo não foi preenchido campo telefone
              {
                MessageBox.Show("Preencha o campo telefone.");
                maskedTelefone.Focus();
                return;// finaliza caso os campos não sejam preenchidos corretamente.
              }
                
                Funcionarios f = new Funcionarios();//criado objeto pessoa com todos os dados fornecidos.
                f.Nome = txtNome.Text;
                f.Telefone = maskedTelefone.Text;
                f.Tipo = comboTipo.SelectedItem.ToString();

            if (index < 0) // para um novo cadastro
            {
                funcionarios.Add(f);
            }
            

            Lista.Items.Clear();

            foreach (var item in funcionarios)
            {
                Lista.Items.Add(item.Nome);//aparece o nome na lista
                Lista.Items.Add(item.Telefone);//aparece o nome na lista
                Lista.Items.Add(item.Tipo);//aparece o nome na lista


            }
        }


        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;//verifica a lista de funcionario
            funcionarios.RemoveAt(indice);
            Listar();//metódo para remover os itens da lista assim que selecionados.
        }
        

        private void Listar()
        {
            Lista.Items.Clear();//limpar a lista

            foreach (Funcionarios f in funcionarios)
            {
                Lista.Items.Add(f.Nome);
                Lista.Items.Add(f.Telefone);
                Lista.Items.Add(f.Tipo);

            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e) 
        {
            
        }

      
    }
}
        


