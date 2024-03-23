namespace CRUD_ASP.NEST_Core_8;

public class Produto
{
    public int ProdutoId { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public string? ImagemURL { get; set; }

    public decimal Preco { get; set; }

    public float Estoque { get; set; }

    public DateTime DataCadastro { get; set; }

}
