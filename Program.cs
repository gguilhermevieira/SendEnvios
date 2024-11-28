using SendEnvios.Models;

namespace SendEnvios;

class Program
{
    static void Main(string[] args)
    {
        List<Pedido> pedidos = new List<Pedido>();
        
        Console.WriteLine("Seja bem-vindo(a) ao SendEnvios!");
        
        MostraMenuInicial();
        var decisao = Console.ReadLine();

        while (decisao != "4")
        {
            if (decisao == "1")
            {
                Console.WriteLine("Cadastre seu pedido de envio:");

                Console.WriteLine("Digite seu nome:");
                var nome = Console.ReadLine();
        
                Console.WriteLine("Digite a nota fiscal:");
                var notaFiscal = Console.ReadLine();
        
                var pedido = new Pedido(pedidos.Count + 1, nome, notaFiscal);
        
                pedidos.Add(pedido);
            } else if (decisao == "2")
            {
                pedidos.ForEach(pedido => Console.WriteLine($"Id: {pedido.Id}, Nome:{pedido.Nome} - Nota Fiscal:{pedido.NotaFiscal}, Status: {pedido.Status}"));
            } else if (decisao == "3")
            {
                Console.WriteLine("Digite o número do pedido:");
                var numeroPedido = Convert.ToInt32(Console.ReadLine());
        
                var pedido = pedidos.First(pedido => pedido.Id == numeroPedido);
        
                if (pedido == null)
                    Console.WriteLine("Pedido não encontrado");
                
                else
                {
                    MostraMenuStatus();
                    var status = Console.ReadLine();
        
                    if (status == "1")
                        pedido.Status = StatusPedido.EmRota;
                    else if (status == "2")
                        pedido.Status = StatusPedido.Entregue;
                    else if (status == "3")
                        pedido.Status = StatusPedido.Cancelado;
                    
                }
            }
            
            MostraMenuInicial();
            decisao = Console.ReadLine();
        }
        
        void MostraMenuInicial()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Cadastrar um pedido de envio");
            Console.WriteLine("2 - Listar pedidos de envio");
            Console.WriteLine("3 - Alterar Status pedido");
            Console.WriteLine("4 - Sair");
        }
        
        void MostraMenuStatus()
        {
            Console.WriteLine("Qual status deseja?");
            Console.WriteLine("1 - Em rota");
            Console.WriteLine("2 - Entregue");
            Console.WriteLine("3 - Cancelado");
        }
    }

}