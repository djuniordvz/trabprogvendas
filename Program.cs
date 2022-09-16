using System;
using System.Collections.Generic;
using TRABALHO;
class Program
{
    static List<Cliente> clientesCadastrados = new List<Cliente>();
    static List<Vendedor> vendedoresCadastrados = new List<Vendedor>();
    static List<Gerente> gerentesCadastrados = new List<Gerente>();
    static List<Produto> produtosCadastrados = new List<Produto>();
    static List<Venda> vendasCadastradas = new List<Venda>();

    static void Main(string[] args)
    {
        int selectedOption;

        Console.Clear();
        Console.WriteLine("                 Inicio!               ");
        Console.Write("\n\n");
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|        Bem Vindo ao Sistema!        |");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n\n");
        Console.WriteLine("      Tecle enter para continuar!      ");
        Console.ReadLine();

        do{

            Console.Clear();
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|            Menu Principal           |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");
            Console.WriteLine("1 - Cadastros");
            Console.WriteLine("2 - Vendas");
            Console.WriteLine("3 - Relatorios");
            Console.WriteLine("0 - Sair");
        

            selectedOption = int.Parse(Console.ReadLine());

            switch (selectedOption)
            {
                case 1:
                    TelaCadastros();
                    break;
                case 2:
                    Venda();
                    break;
                case 3:
                    TelaRelatorios();
                    break;
                default:
                    break;
            }
        } while (selectedOption != 0);
    }

    public static void TelaCadastros(){
        int cadselectedOption;

        do
        {

        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|            Menu Cadastros           |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Cadastrar Vendedor");
        Console.WriteLine("3 - Cadastrar Gerente");
        Console.WriteLine("4 - Cadastrar Produto");
        Console.WriteLine("0 - Voltar");

        cadselectedOption = int.Parse(Console.ReadLine());

        switch (cadselectedOption)
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 2:
                    CadastrarFuncionario(1);
                    break;
                case 3:
                    CadastrarFuncionario(2);
                    break;
                case 4:
                    CadastrarProduto();
                    break;
                default:
                    break;
            }
        } while (cadselectedOption != 0);
        
    }

    public static void TelaRelatorios(){
        int relatselectedOption;

        do
        {

        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|           Menu Relatorios           |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        Console.WriteLine("1 - Lista de clientes");
        Console.WriteLine("2 - Lista de produtos");
        Console.WriteLine("3 - Lista de vendas");
        Console.WriteLine("4 - Lista de vendedores");
        Console.WriteLine("5 - Gerencia");
        Console.WriteLine("0 - Voltar");

        relatselectedOption = int.Parse(Console.ReadLine());

        switch (relatselectedOption)
            {
                case 1:
                    ListaClientes();
                    break;
                case 2:
                    ListaProdutos();
                    break;
                case 3:
                    ListaVendas();
                    break;
                case 4:
                    ListaVendedores();
                    break;
                case 5:
                    ListaGerentes();
                    break;
                default:
                    break;
            }
        } while (relatselectedOption != 0);
        
    }

    public static void CadastrarCliente(){
        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|          Cadastrar Cliente          |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");

        Cliente cliente = new Cliente();
        cliente.DadosCadastroBase();
        clientesCadastrados.Add(cliente);
        Console.Write("Cadastrado com sucesso!");
    }

    public static void CadastrarFuncionario(int operacao){
        Console.Clear();
        if(operacao == 2){
            Gerente gerente = new Gerente();
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|           Cadastrar Gerente         |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");
            gerente.CadastrarFuncionario();
            gerentesCadastrados.Add(gerente);
            Console.Write("Vendedor cadastrado com sucesso!");
        } else {
            Vendedor vendedor = new Vendedor();
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|          Cadastrar Vendedor         |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");
            vendedor.CadastrarFuncionario();
            vendedoresCadastrados.Add(vendedor);
            Console.Write("Gerente cadastrado com sucesso!");
        }
    }

    public static void CadastrarProduto(){
        Console.Clear();
        Produto produto = new Produto();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|          Cadastrar Produto          |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        produto.CadastrarProduto();
        produtosCadastrados.Add(produto);
        Console.Write("Cadastrado com sucesso!");
        Console.ReadKey();
    }

    public static void Venda(){
        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|                Venda:               |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");

        string cpf;
        string nomeVendedor;
        string codProduto;
        int quantidade;

        Venda venda = new Venda();

        Console.WriteLine("Digite o CPF do cliente: ");
        cpf = Console.ReadLine();
        Cliente a = new Cliente();
        foreach (Cliente cliente in clientesCadastrados)
        {
            if(cliente.GetCpf() == cpf){
                a = cliente;
                break;
            }
        }
        venda.SetCliente(a);

        Console.WriteLine("Digite o nome do vendedor: ");
        nomeVendedor = Console.ReadLine();
        Vendedor b = new Vendedor();
        foreach (Vendedor vendedor in vendedoresCadastrados)
        {
            if(vendedor.GetNome() == nomeVendedor){
                b = vendedor;
                break;
            }
        }
        venda.SetVendedor(b);

        Console.WriteLine("Digite o codigo do produto: ");
        codProduto = Console.ReadLine();
        Produto c = new Produto();
        foreach (Produto produto in produtosCadastrados)
        {
            if(produto.GetCodigo() == codProduto){
                c = produto;
                break;
            }
        }
        venda.SetProduto(c);

        Console.WriteLine("Digite a quantidade: ");
        quantidade = int.Parse(Console.ReadLine());

        double valorUnitario = c.GetValorUnitario();
        double valorTotal = ((c.GetValorUnitario()) * quantidade);

        Console.WriteLine("Valor Unitario: R$ " + valorUnitario);
        Console.WriteLine("Valor Total venda: R$ " + valorTotal);

        Console.Write("Tecle enter para confirmar a venda!");
        Console.ReadLine();
        vendasCadastradas.Add(venda);
        Console.Write("Venda realizada com sucesso!");
        Console.ReadLine();

    }

    public static void ListaClientes(){

        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|            Lista Clientes           |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        Console.WriteLine("|    Código     |     Nome      |     CPF      |  Nascimento  |");
        Console.Write("\n\n");

        foreach (Cliente cliente in clientesCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", cliente.GetCodigo(), cliente.GetNome(), cliente.GetCpf(), cliente.GetDataNascimento()));
        }

        Console.ReadLine();

    }

    public static void ListaVendedores(){
        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|           Lista Vendedores          |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        Console.WriteLine("|     Nome     |     CPF      |  Nascimento  |   Salário   |");
        Console.Write("\n\n");

        foreach (Vendedor vendedor in vendedoresCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", vendedor.GetNome(), vendedor.GetCpf(), vendedor.GetDataNascimento(), vendedor.GetSalario()));
        }

        Console.ReadLine();
        
    }

    public static void ListaVendas(){
        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|             Lista Vendas            |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        Console.WriteLine("|   Cliente   |    Vendedor    |   Produto   |");
        Console.Write("\n\n");

        foreach (Venda venda in vendasCadastradas)
        {
            Console.WriteLine(String.Format("{0} {1} {2}", venda.GetCliente().GetNome(), venda.GetVendedor().GetNome(), venda.GetProduto().GetDescricao()));
        }

        Console.ReadLine();
        
    }

    public static void ListaGerentes(){
        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|               Gerencia              |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        Console.WriteLine("|     Nome     |     CPF      |  Nascimento  |   Salário   |");
        Console.Write("\n\n");

        foreach (Gerente gerente in gerentesCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", gerente.GetNome(), gerente.GetCpf(), gerente.GetDataNascimento(), gerente.GetSalario()));
        }

        Console.ReadLine();
        
    }

    public static void ListaProdutos(){
        Console.Clear();
        Console.WriteLine("_______________________________________");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|               Produtos              |");
        Console.WriteLine("|_____________________________________|");
        Console.Write("\n\n");
        Console.WriteLine("|    Código     |   Fabricante   |     Descricao     |  Valor Unitário  |");
        Console.Write("\n\n");

        foreach (Produto produto in produtosCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", produto.GetCodigo(), produto.GetFabricante(), produto.GetDescricao(), produto.GetValorUnitario()));
        }

        Console.ReadLine();
    }
}