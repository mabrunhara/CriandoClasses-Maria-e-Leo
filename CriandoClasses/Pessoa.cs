using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoClasses
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private string sexo;

        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            Sexo = null;
        }
        public  Pessoa(string nome, int idade, double altura, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();

        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }

        }
     public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToUpper() == "F" ? "FEMININO" : "MASCULINO"; }
        }

        public double calcularPesoIdeal()
        {
            if (sexo.Equals("FEMININO"))
                return (62.1 * altura) - 44.7;
            else 
                return (72.7 *altura) -58;

        }

        public override string ToString()
        {
            return (String.Format("Nome: {0} \n Idade: {1} \n Altura: {2} \n Sexo: {3} \n", nome, Idade, altura, sexo)); 


        }

    }
}
