namespace TRABALHO{
    public class Gerente:Funcionario
    {
        public Gerente(){
        }
        
        public Gerente(string nome, string cpf, string rg, string dataNascimento, Endereco endereco, double salario): base(nome, cpf,rg,dataNascimento, endereco, salario){
        }

        public void SalarioGerente(){
            base.GetSalario();
            SetSalario( GetSalario() * 2.2);
        }
    }
}