using System;

namespace Professor
{
    class Professor
    {
        private String nome;
        private int codigo;
        private int contacto;
        private String curso;
        private String turma;
        private double horas;
        private double salario;

        public Professor(int codigo, int contacto, string curso, string turma, double horas, double salario)
        {
            this.codigo = codigo;
            this.contacto = contacto;
            this.curso = curso;
            this.turma = turma;
            this.horas = horas;
            this.salario = salario;
        }

        public Professor()
        {
                
        }
        
        public string Nome { get => nome; set => nome = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Contacto { get => contacto; set => contacto = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Turma { get => turma; set => turma = value; }
        public double Horas { get => horas; set => horas = value; }
        public double Salario { get => salario; set => salario = value; }

        ToString()

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
