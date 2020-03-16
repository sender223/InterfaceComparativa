using System;
using System.Globalization;

namespace InterfaceComparativa.Entities {
    //classe do tipo Funcionario implementando a classe IComparable. 
    class Funcionario : IComparable {

        public string Nome { get; set; }
        public double Salario { get; set; }
        //construtor diferente
        public Funcionario(string csvFuncionario) {
            //criando vetores para separar cada conteudo pela ","
            string[] vetor = csvFuncionario.Split(',');
            //Nome vetor 0
            Nome = vetor[0];
            //Salario vetor 1
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        //metodo para converter a classe em string
        public override string ToString() {
            return Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);                
        }

        //metodo para comparar entre os funcionarios e retorna um numero inteiro 0 -1 1
        //faremos um comparativo pelo NOME.
        public int CompareTo(object obj) {
            //se o objeto for diferente de funcionario.
            if (!(obj is Funcionario)) {
                //lança uma exceção
                throw new ArgumentException("Erro de Comparação: argumento não é funcionario" );
            }
            //criamos uma variavel temporaria do tipo funcionario "outro"
            //e faremos o downcasting obj as Funcionario.
            Funcionario outro = obj as Funcionario;
            //retornando o comparativo = Nome.CompareTo(outro.Nome);
            return Nome.CompareTo(outro.Nome);
            //COMPARANDO SALARIO
            //Funcionario outro = obj as Funcionario;
            //retornando o comparativo = Nome.CompareTo(outro.Nome);
            //return Salario.CompareTo(outro.Salario);
        }
    }
}
