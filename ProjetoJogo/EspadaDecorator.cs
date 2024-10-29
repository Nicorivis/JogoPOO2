public class EspadaDecorator : Decorator
{
    // Construtor que recebe um objeto Guerreiro e aplica o efeito de aumento de ataque
    public EspadaDecorator(Guerreiro guerreiro) : base(guerreiro)
    {
        guerreiro.Ataque += 5; // Aumenta o ataque do guerreiro em 5
    }
}
