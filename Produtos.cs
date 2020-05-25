using System;

public class Produto
{
	public Produto(string nome, string valor)
	{
		Id = Guid.NewGuid();
		Nome = nome;
		Valor = valor;
	}

	public Guid Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
}
