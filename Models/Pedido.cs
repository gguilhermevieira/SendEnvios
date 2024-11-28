namespace SendEnvios.Models;

public class Pedido
{
    public Pedido(int id, string nome, string notaFiscal)
    {
        Id = id;
        Nome = nome;
        NotaFiscal = notaFiscal;
        Status = StatusPedido.Pendente;
    }
    
    public int Id { get; set; }

    public string Nome { get; set; }

    public string NotaFiscal { get; set; }

    public StatusPedido Status { get; set; }

    public void Enviar()
    {
        Status = StatusPedido.EmRota;
    }

    public void Cancelar()
    {
        Status = StatusPedido.Cancelado;
    }
    
    
}