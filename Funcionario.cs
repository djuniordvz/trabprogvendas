namespace TRABALHO{
    public abstract class Funcionario:CadastroBase{

        private double salario;

        public Funcionario(){
        }
        public Funcionario(string nome, string cpf, string rg, string dataNascimento, Endereco endereco, double salario): base(){
            this.salario = salario;
        }

        public void CadastrarFuncionario(){
            base.DadosCadastroBase();
            
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|         Dados Funcionario:          |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");

            Console.Write("Salario base do funcionario: R$");
            salario = double.Parse(Console.ReadLine());
        }

        public double GetSalario(){
            return salario;
        }
        public void SetSalario(double salario){
            this.salario = salario;
        }
    }
}