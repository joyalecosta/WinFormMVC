using System;

namespace MVC_Model
{
    public class Funcionario
    {
        public enum SexoPessoa
        {
            M = 1,
            F = 2
        }

        private string nome;
        private string sobrenome;
        private string id;
        private string departamento;
        private SexoPessoa sexo;

        public Funcionario(
            string nome,
            string sobrenome,
            string id,
            string departamento,
            SexoPessoa sexo)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.id = id;
            this.departamento = departamento;
            this.sexo = sexo;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public SexoPessoa Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}