public abstract class Decorator : Guerreiro
{
    // Referência ao objeto Guerreiro que está sendo decorado
    protected Guerreiro guerreiro;

    // Construtor que recebe um objeto Guerreiro e inicializa a base
    protected Decorator(Guerreiro guerreiro) : base(guerreiro.Nome, guerreiro.Ataque, guerreiro.Defesa, guerreiro.Vida)
    {
        this.guerreiro = guerreiro; // Armazena a referência do Guerreiro
    }

    // Propriedade que retorna o ataque do guerreiro decorado
    public override double Ataque => guerreiro.Ataque; // Acesso correto à propriedade de ataque

    // Propriedade que retorna a defesa do guerreiro decorado
    public override double Defesa => guerreiro.Defesa; // Acesso correto à propriedade de defesa
}
