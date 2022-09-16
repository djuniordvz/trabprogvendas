namespace TRABALHO{
    public class Endereco{
        private string rua = "";
        private int numero;
        private string complemento = "";
        private string cep = "";
        private string cidade = "";
        private string bairro = "";
        private string estado = "";

        public Endereco(){
        }

        public string GetRua(){
            return rua;
        }
        public void SetRua(string rua){
            this.rua = rua;
        }

        public int GetNumero(){
            return numero;
        }
        public void SetNumero(int numero){
            this.numero = numero;
        }

        public string GetComplemento(){
            return complemento;
        }
        public void SetComplemento(string complemento){
            this.complemento = complemento;
        }

        public string GetCep(){
            return cep;
        }
        public void SetCep(string cep){
            this.cep = cep;
        }

        public string GetCidade(){
            return cidade;
        }
        public void SetCidade(string cidade){
            this.cidade = cidade;
        }

        public string GetBairro(){
            return bairro;
        }
        public void SetBairro(string bairro){
            this.bairro = bairro;
        }

        public string GetEstado(){
            return estado;
        }
        public void SetEstado(string estado){
            this.estado = estado;
        }

        public void CadastrarEndereco(){
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|           Dados Endereço:           |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");

            Console.Write("Rua: ");
            rua = Console.ReadLine();
            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Complemento: ");
            complemento = Console.ReadLine();
            Console.Write("CEP: ");
            cep = Console.ReadLine();
            Console.Write("Cidade: ");
            cidade = Console.ReadLine();
            Console.Write("Bairro: ");
            bairro = Console.ReadLine();
            Console.Write("Estado: ");
            estado = Console.ReadLine();
        }
    }
}