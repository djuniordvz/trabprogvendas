namespace TRABALHO{
    public class Produto
    {
        private string codigo = "";
        private string fabricante = "";
        private string descricao = "";
        private double valorUnitario;

        public Produto(){
        }

        public Produto(string codigo, string fabricante, string descricao, double valorUnitario){
            this.codigo = codigo;
            this.fabricante = fabricante;
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
        }

        public string GetCodigo(){
            return codigo;
        }
        public void SetCodigo(string codigo){
            this.codigo = codigo;
        }

        public string GetFabricante(){
            return fabricante;
        }
        public void SetFabricante(string fabricante){
            this.fabricante = fabricante;
        }

        public string GetDescricao(){
            return descricao;
        }
        public void SetDescricao(string descricao){
            this.descricao = descricao;
        }

        public double GetValorUnitario(){
            return valorUnitario;
        }
        public void SetValorUnitario(double valorUnitario){
            this.valorUnitario = valorUnitario;
        }

        public void CadastrarProduto(){
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|            Dados Produto:           |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");

            Console.Write("Código: ");
            codigo = Console.ReadLine();
            Console.Write("Fabricante: ");
            fabricante = Console.ReadLine();
            Console.Write("Descricao: ");
            descricao = Console.ReadLine();
            Console.Write("Valor unitário: ");
            valorUnitario = double.Parse(Console.ReadLine());
        }

    }
}