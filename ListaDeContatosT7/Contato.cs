using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;


namespace ListaDeContatosT7
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        /*Propriedades (get e set)
        é um controle de acesso ás variaveis. */

        public string Nome { get { return nome; } set { nome = value; } }

        public string Sobrenome { get { return sobrenome; } set { sobrenome = value; } }

        public string Telefone
        {
            get
            {

                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    //País-Cidade-Telefone, ex +55-11-79367-9051
                    telefone = "-00-00000-0000";
                }
            }

        }
        //o método que tem o mesmo nome da classe
        //e não retorna nada, é chamado CONSTRUTOR
        //DA CLASSE
        public void contato()
        {
            Nome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11 99999-9999";
        }

        public void contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        //Sobreescreve o método ToString()
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", Telefone.Substring(0, 2), Telefone.Substring(2, 5), Telefone.Substring(7, 4));
            return saida;
        }
    }
}
