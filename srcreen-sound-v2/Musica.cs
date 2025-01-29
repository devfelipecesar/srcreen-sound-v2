class Musica //cria classe
{
    public string Nome { get; set; }  // criacao de propriedades
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}"; //Lambda ou aerofunction

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus.");
        }
    }
}
