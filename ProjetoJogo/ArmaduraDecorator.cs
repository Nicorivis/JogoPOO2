public class ArmaduraDecorator : Decorator
{
    // Construtor que recebe um objeto Guerreiro e aumenta sua defesa
    public ArmaduraDecorator(Guerreiro guerreiro) : base(guerreiro)
    {
        guerreiro.Defesa += 5; // Aumenta a defesa do guerreiro em 5
    }
}
