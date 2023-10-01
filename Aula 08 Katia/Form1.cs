using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_08_Katia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pet> listpet = new List<Pet>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Nome = txtNome.Text;
            pet.Idade = int.Parse(txtIdade.Text);
            pet.Especie = cbxEspecie.Text;
            listpet.Add(pet);
            limpar();
        }
        private void limpar()
        {
            txtNome.Text = null;
            txtIdade.Text = null;
            cbxEspecie.SelectedIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            for (int i = 0; i < listpet.Count; i++)
            {
                if (listpet[i].Nome.Equals(txtNome.Text))
                {
                    txtIdade.Text = listpet[i].Idade.ToString();
                    cbxEspecie.Text = listpet[i].Especie;
                    indice = 1;
                    i = 100000; //tamanho maximo
                }
            }
            if(indice == 0)
            {
                MessageBox.Show("Pet não encontrado");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listpet.Count; i++)
            {
                if (listpet[i].Nome.Equals(txtNome.Text))
                {
                    listpet.RemoveAt(i);
                    MessageBox.Show("Removido com sucesso!");
                }
            }
        }
    }
}
