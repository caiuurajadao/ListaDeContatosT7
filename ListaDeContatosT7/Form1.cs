using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Contato[] contatos = new Contato[1];

        private void escrever(Contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("contato.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);
            }

            escreverEmArquivo.Close();
        }
        private void Escrever(Contato contato)
        {
            StreamWriter escreverEmArquivos = new StreamWriter("Contatos.txt");
            escreverEmArquivos.WriteLine(contatos.Length + 1);
            escreverEmArquivos.WriteLine(contato.Nome);
            escreverEmArquivos.WriteLine(contato.Telefone);

            for (int i = 0; i < contatos.Length; i++)
            {
                escreverEmArquivos.WriteLine(contatos[i].Nome);
                escreverEmArquivos.WriteLine(contatos[i].Sobrenome);
                escreverEmArquivos.WriteLine(contatos[i].Telefone);
            }

            escreverEmArquivos.Close();
        }

        private void Ler()
        {
            StreamReader lerArquivo = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(lerArquivo.ReadLine())];

            for (int x = 0; x < contatos.Length; x++)
            {
                contatos[x] = new Contato();
                contatos[x].Nome = lerArquivo.ReadLine();
                contatos[x].Sobrenome = lerArquivo.ReadLine();
                contatos[x].Telefone = lerArquivo.ReadLine();
            }
            lerArquivo.Close();


        }

        private void Exibir()
        {
            listBoxContatos.Items.Clear();
            for (int x = 0; x < contatos.Length; x++)
            {
                listBoxContatos.Items.Add(contatos[x].ToString());
            }
        }
        private void LimparFormulario()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar um objeto de clasee contato
            Contato contato = new Contato();
            contato.Nome = textBox1.Text;
            contato.Sobrenome = textBox1.Text;
            contato.Telefone = textBox1.Text;

            //listBoxContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Organizar();
            Ler();
            Exibir();
            LimparFormulario();
        }
        private void Organizar()
        {
            Contato temporário;
            bool troca = true;

            do
            {
                troca = false;
                for (int x = 0; x < contatos.Length - 1;)
                {
                    if (contatos[x].Nome.CompareTo(contatos[x + 1].Nome) > 0)
                    {
                        temporário = contatos[x];
                        contatos[x] = contatos[x + 1];
                        contatos[x + 1] = temporário;
                        troca = true;
                    }
                }
            } while (troca == true);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Organizar();
            Exibir
        }
    }

}
