namespace TRABALHO{
    public class Vendedor:Funcionario
    {
        public Vendedor(){
        }

        public Vendedor(string nome, string cpf, string rg, string dataNascimento, Endereco endereco, double salario): base(nome, cpf,rg,dataNascimento, endereco, salario){
        }

        public void SalarioGerente(){
            base.GetSalario();
            SetSalario( GetSalario() * 1.4);
        }
    }
}