namespace TRABALHO{
    public class Venda
    {
        private Cliente cliente;
        private Vendedor vendedor;
        private Produto produto;
        private string quantidade;
        private string valorTotal = "";

        public Venda(){
        }

        public Cliente GetCliente(){
            return cliente;
        }

        public void SetCliente(Cliente cliente){
            this.cliente = cliente;
        }

        public Vendedor GetVendedor(){
            return vendedor;
        }

        public void SetVendedor(Vendedor vendedor){
            this.vendedor = vendedor;
        }

        public Produto GetProduto(){
            return produto;
        }
        public void SetProduto(Produto produto){
            this.produto = produto;
        }
    }
}