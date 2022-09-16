namespace TRABALHO{

    public abstract class CadastroBase
    {
        private int codigo = 00001;
        private string nome = "";
        private string cpf = "";
        private string rg = "";
        private string dataNascimento = "";
        private Endereco endereco;
        private static int ultimoCodigo;

        public CadastroBase(){
            ultimoCodigo++;
            this.codigo = ultimoCodigo;
            this.nome = "";
            this.cpf = "";
            this.rg = "";
            this.dataNascimento = "";
            this.endereco = new Endereco();
        }
        
        public int GetCodigo(){
            return codigo;
        }
        public void SetCodigo(int codigo){
            this.codigo = codigo;
        }

        public string GetNome(){
            return nome;
        }
        public void SetNome(string nome){
            this.nome = nome;
        }

        public string GetCpf(){
            return cpf;
        }
        public void SetCpf(string cpf){
            this.cpf = cpf;
        }

        public string GetRg(){
            return rg;
        }
        public void SetRg(string rg){
            this.rg = rg;
        }

        public string GetDataNascimento(){
            return dataNascimento;
        }
        public void SetDataNascimento(string dataNascimento){
            this.dataNascimento = dataNascimento;
        }

        public Endereco GetEndereco(){
            return endereco;
        }
        public void SetEndereco(Endereco endereco){
            this.endereco = endereco;
        }

        public void DadosCadastroBase(){
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|           Cadastro Base :           |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("RG: ");
            rg = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            dataNascimento= Console.ReadLine();

            endereco.CadastrarEndereco();
        }

        
    }
}